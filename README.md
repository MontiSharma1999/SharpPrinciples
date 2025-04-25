# SharpPrinciples

A C#/.NET Core console application exploring key programming principles, patterns, and clean code practices.  
Built to demonstrate **solid architecture**, **modularity**, and **best coding habits**.

---

## 🚀 Features

- 📌 Demonstrates C# fundamentals
- 💡 Implements SOLID principles
- 🔁 Clean separation of concerns
- 🧪 Scalable and testable structure

---

## 🧱 Tech Stack

- C# (.NET Core)
- Visual Studio / VS Code
- Git + GitHub

---
## **SOLID Principles**

The **SOLID** principles are followed throughout this repository to promote clean code, better maintainability, and scalability.

### **1. Single Responsibility Principle (SRP)**
A class should have only one reason to change, meaning it should only have one responsibility.

**Example:**
- An **Order Validation Service** that only validates orders and does not create them.

---

### **2. Open/Closed Principle (OCP)**
A class should be open for extension but closed for modification. You should be able to add new functionality without changing existing code.

**Example:**
- Using the **Decorator Design Pattern** to control behaviors when interacting with the repository from the service layer.

---

### **3. Liskov Substitution Principle (LSP)**
Objects of a derived class should be able to replace objects of the base class without affecting the functionality of the program.

**Example:**
- A **Caching Service** and a **Repository Service** both implement the `IRepository` interface and can be used interchangeably to fetch data.

---

### **4. Interface Segregation Principle (ISP)**
Clients should not be forced to depend on interfaces they do not use. Split large interfaces into smaller, more specific ones.

**Example:**
- Breaking the repository interface into smaller interfaces for **reading**, **writing**, and **deleting** data and then combining them when needed.

---

### **5. Dependency Inversion Principle (DIP)**
High-level modules should not depend on low-level modules. Both should depend on abstractions.

**Example:**
- Using **Dependency Injection** to inject the `IRepository` interface into the service layer, promoting loose coupling between layers.

---

## ✍️ Author

**Monti Sharma** – Passionate about clean code and .NET architecture  
📫 [GitHub Profile](https://github.com/MontiSharma1999)  
🔗 [LinkedIn](https://www.linkedin.com/in/montisharma/)

---

## 📁 Project Structure

```bash
SharpPrinciples/
├── Geometry/
│   └── Circle.cs            # Circle-related geometric logic
├── Shared/
│   └── Printer.cs           # Shared printing utility
├── Program.cs               # Entry point
├── SharpPrinciples.csproj   # Project file
├── bin/                     # Build output (ignored by git)
├── obj/                     # Intermediate build files (ignored by git)
└── .gitignore

