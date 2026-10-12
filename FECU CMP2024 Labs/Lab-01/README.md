# Lab 1 — Enter Movie / Actors Form

## Requirement 1: Enter Movie Form (Form 1)

Create a movie form with the following behavior:

- A text field for the movie **title**.
- A **"Genre" checkbox**. Initially, the Genre groupbox and its controls are **disabled**.
  - On checking the checkbox, the genre groupbox (radio buttons + textbox) becomes **enabled**.
- Genre radio buttons: **Comedy**, **Horror**, **Other** (with a textbox for custom genre).
- An **Accessibility** groupbox with radio buttons: **Private**, **Public**.
- An **"Add Actors"** button:
  - If any input control is empty (except Genre when disabled), show a **descriptive error messagebox**.
  - If "Other" genre is selected but the textbox is empty, show a **descriptive error messagebox**.
  - Otherwise, open Form 2 (Actors Form), passing the current movie data (title, genre if any, accessibility).

---

## Requirement 2: Actors Form (Form 2)

Create an actors form with the following behavior:

- An **Actors combobox** containing **5 to 10 hard-coded actors**.
- An **"Add Actor"** button:
  - Adds a new row to the DataGridView containing: movie title, genre (if any), accessibility, and the selected actor.
  - A **green label** becomes visible with the message: **"Actor is added"**.
- On choosing another actor from the combobox:
  - The green label becomes **invisible** again.
- An **"Add New Movie"** button:
  - Opens Form 1 to add a new movie.
- **Note:** The DataGridView must retain **all previously added movies**, not just the current one.
