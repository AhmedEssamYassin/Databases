using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DBapplication
{
    public static class MaterialThemeManager
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(System.IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public static void SetDarkMode(Form form, bool isDark)
        {
            try
            {
                int useImmersiveDarkMode = isDark ? 1 : 0;
                DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));
            }
            catch
            {
                // Ignore if running on older OS versions where DWM API is not available
            }
        }

        public static void Initialize(MaterialForm form)
        {
            var manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(form);
            UpdateTheme(manager);
            SetDarkMode(form, manager.Theme == MaterialSkinManager.Themes.DARK);
        }

        public static void ToggleTheme()
        {
            var manager = MaterialSkinManager.Instance;
            manager.Theme = manager.Theme == MaterialSkinManager.Themes.DARK ? 
                MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            
            bool isDark = manager.Theme == MaterialSkinManager.Themes.DARK;
            foreach (Form form in Application.OpenForms)
            {
                SetDarkMode(form, isDark);
            }
        }

        private static void UpdateTheme(MaterialSkinManager manager)
        {
            manager.ColorScheme = new ColorScheme(
                Primary.Indigo500, Primary.Indigo700, 
                Primary.Indigo100, Accent.Pink200, 
                TextShade.WHITE
            );
        }

        public static void StyleSidebarPanel(Panel sidebar, bool isDark)
        {
            if (isDark)
            {
                sidebar.BackColor = Color.FromArgb(21, 32, 54);
            }
            else
            {
                sidebar.BackColor = Color.FromArgb(235, 237, 240);
            }

            foreach (Control ctrl in sidebar.Controls)
            {
                if (ctrl is Button btn && !(btn is MaterialButton))
                {
                    StyleSidebarButton(btn, isDark);
                }
            }
        }

        private static void StyleSidebarButton(Button btn, bool isDark)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(15, 0, 0, 0);
            btn.Font = new Font("Roboto", 10.5f, FontStyle.Regular);
            btn.ForeColor = isDark ? Color.FromArgb(220, 224, 230) : Color.FromArgb(40, 40, 40);
            btn.BackColor = Color.Transparent;
            btn.Cursor = Cursors.Hand;

            // Remove existing handlers to prevent duplicate attachments
            btn.MouseEnter -= SidebarButton_MouseEnter;
            btn.MouseLeave -= SidebarButton_MouseLeave;

            btn.MouseEnter += SidebarButton_MouseEnter;
            btn.MouseLeave += SidebarButton_MouseLeave;
        }

        private static void SidebarButton_MouseEnter(object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
            bool isDark = MaterialSkinManager.Instance.Theme == MaterialSkinManager.Themes.DARK;
            btn.BackColor = isDark ? Color.FromArgb(45, 55, 75) : Color.FromArgb(215, 215, 220);
        }

        private static void SidebarButton_MouseLeave(object sender, System.EventArgs e)
        {
            var btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            var manager = MaterialSkinManager.Instance;
            bool isDark = manager.Theme == MaterialSkinManager.Themes.DARK;

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 38;

            dgv.BackgroundColor = isDark ? Color.FromArgb(33, 37, 43) : Color.White;
            dgv.GridColor = isDark ? Color.FromArgb(43, 49, 62) : Color.FromArgb(226, 232, 240);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = manager.ColorScheme.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = manager.ColorScheme.PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;

            dgv.RowsDefaultCellStyle.BackColor = isDark ? Color.FromArgb(33, 37, 43) : Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = isDark ? Color.FromArgb(220, 224, 230) : Color.FromArgb(33, 37, 43);
            dgv.RowsDefaultCellStyle.SelectionBackColor = manager.ColorScheme.AccentColor;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Regular);
            dgv.RowsDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = isDark ? Color.FromArgb(40, 44, 52) : Color.FromArgb(248, 249, 250);
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = isDark ? Color.FromArgb(220, 224, 230) : Color.FromArgb(33, 37, 43);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = manager.ColorScheme.AccentColor;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Regular);
            dgv.AlternatingRowsDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        public static void AutoFitGridColumns(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            int totalColumnsWidth = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible) totalColumnsWidth += col.Width;
            }

            if (totalColumnsWidth < dgv.Width)
            {
                DataGridViewColumn fillCol = null;
                if (dgv.Columns.Contains("Address")) fillCol = dgv.Columns["Address"];
                else if (dgv.Columns.Contains("Lname")) fillCol = dgv.Columns["Lname"];
                else if (dgv.Columns.Contains("SName")) fillCol = dgv.Columns["SName"];
                else if (dgv.Columns.Contains("Pname")) fillCol = dgv.Columns["Pname"];

                if (fillCol == null)
                {
                    // Fall back to the last visible non-button column
                    for (int i = dgv.Columns.Count - 1; i >= 0; i--)
                    {
                        if (dgv.Columns[i].Visible && !(dgv.Columns[i] is DataGridViewButtonColumn))
                        {
                            fillCol = dgv.Columns[i];
                            break;
                        }
                    }
                }

                if (fillCol != null)
                {
                    fillCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
