# 🎮 Player Deep Copy

A C# console application demonstrating **Deep Copy** using a **Copy Constructor**. The program creates an independent copy of a player's score array, ensuring changes made to the copied object do not affect the original object.

## 📚 Features

- Create a player with an array of scores.
- Copy a player object using a copy constructor.
- Clone the score array for independent storage.
- Modify copied player scores without affecting the original player.
- Demonstrate deep copy with arrays.

## 📖 Concepts Covered

- Object-Oriented Programming (OOP)
- Constructors
- Copy Constructor
- Deep Copy
- Arrays
- Array.Clone()
- Indexers

## 📂 Project Structure

```text
Player-Deep-Copy
│
├── Program.cs
├── README.md
└── Screenshot.png
```

## ▶️ Sample Output

```text
--- Player Array Deep Copy Demo ---

[ Before Modifying Player 2 Scores ]

Player Name: Akash
Scores: 50 80 100

Player Name: Akash
Scores: 50 80 100

[ After Setting player2[0] = 99 ]

Player 1
Scores: 50 80 100

Player 2
Scores: 99 80 100
```

## 🎯 Learning Outcome

- Learn how to perform deep copying of arrays.
- Understand why reference types require deep copies.
- Practice implementing copy constructors with arrays.
- Understand object independence after copying.

---

👨‍💻 **Akash Raval**
