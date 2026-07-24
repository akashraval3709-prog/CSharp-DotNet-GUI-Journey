# 🪟 Dynamic Form Title

A Windows Forms application demonstrating how to change the **Form Title** dynamically using a **TextBox**, **Button**, and Form events.

## 📄 Files

```text
Program.cs
Form1.cs
Form1.Designer.cs
Form1.resx
```

## 💡 Logic

- Set a default form title when the application starts.
- Update the title while the user types in the TextBox.
- Save the document title when the **Save** button is clicked.
- Demonstrate runtime modification of the `Form.Text` property.

## 📚 Concepts Used

- Windows Forms
- Form Properties
- Form.Text
- TextBox
- Button
- Click Event
- TextChanged Event
- Form Load Event

## ▶️ Sample Output

```
MyDocument.txt - Editor

Typing...
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
    └── Dynamic-Form-Title
        ├── Program.cs
        ├── Form1.cs
        ├── Form1.Designer.cs
        ├── Form1.resx
        ├── README.md
        └── Screenshot.png
```

## 🎯 Learning Outcome

- Understand the `Form.Text` property.
- Learn how to change form properties at runtime.
- Handle user interactions using Windows Forms events.
- Build interactive GUI applications with C#.

---

👨‍💻 **Akash Raval**
