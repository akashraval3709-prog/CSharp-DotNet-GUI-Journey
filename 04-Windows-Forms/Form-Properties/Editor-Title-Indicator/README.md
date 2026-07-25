# 📝 Editor Title Indicator

A Windows Forms application demonstrating how to update the **Form Title** dynamically to indicate whether a document has unsaved changes.

## 📄 Files

```text
Program.cs
Form1.cs
Form1.Designer.cs
Form1.resx
```

## 💡 Logic

- Set the default form title when the application starts.
- Display an asterisk (`*`) in the title while the user edits the text.
- Restore the original title after clicking the **Save** button.
- Demonstrate runtime modification of the `Form.Text` property using Windows Forms events.

## 📚 Concepts Used

- Windows Forms
- Form Properties
- Form.Text
- TextBox
- Button
- Form Load Event
- TextChanged Event
- Button Click Event
- Event Handling

## ▶️ Sample Output

```text
Application Starts
↓
MyDocument.txt - Editor

User Types
↓
MyDocument.txt* - Editor

Click Save
↓
MyDocument.txt - Editor
```

## 📂 Project Structure

```text
04-Windows-Forms
│
└── Form-Properties
    │
    └── Editor-Title-Indicator
        ├── Program.cs
        ├── Form1.cs
        ├── Form1.Designer.cs
        ├── Form1.resx
        ├── README.md
        └── Screenshot.png
```

## 🎯 Learning Outcome

- Learn how to modify the `Form.Text` property at runtime.
- Understand Windows Forms event handling.
- Build applications that reflect document status in the title bar.
- Practice interactive GUI programming in C#.

---

👨‍💻 **Akash Raval**
