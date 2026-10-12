# Lab 2 — Course Registration App (Login + Register)

## Problem Definition

Build a course registration app where the user first logs in (Form 1) and then registers for courses (Form 2).

---

## Requirement 1: Login Form (Form 1)

1. If any username is entered (not empty) **and** the password is `"123"`, then:
   - Display a message box: `"Hello <username>"` with the entered name.
   - Open Form 2 (Register Form).
2. Otherwise, an **error message is displayed in red**.
3. The error message is **initially not visible**.
4. The password characters are displayed as **asterisks**.
5. A **"Show Password"** checkbox toggles password visibility. (Hint: `PasswordChar = '\0'` to show.)

---

## Requirement 2: Register Form (Form 2)

Initially disable adding, deleting, editing, or reordering of the DataGridView.

1. A **disabled Student textbox** initially contains the **username** of the logged-in user (passed from Form 1).
2. Initially, add **5 courses** to the course combobox.
3. On selecting a course from the combobox:
   - **(a)** If the chosen course is already in the DataGridView, show a **red error message**.
   - **(b)** The time slots combobox items **change** depending on the chosen course. Each course has different time slots (2–4 hard-coded slots per course).
   - **(c)** The disabled **"Hours" textbox** updates with the number of hours of the chosen course. Two courses = 2 hours, three courses = 3 hours.
4. On clicking the **"Add Course"** button:
   - **(a)** If the chosen course is already in the DataGridView, show a **red error message** (handles consecutive additions).
   - **(b)** A new row is added to the DataGridView with: course, timeslot, and hours.
   - **(c)** The disabled **"Total Hours" textbox** is updated with the cumulative total of all added course hours.
