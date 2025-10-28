# 🍝 Facade Pattern Example (C#)

<p align="center">
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/">
    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/>
  </a>
</p>

---

This project demonstrates the **Facade Design Pattern** using a **restaurant ordering system** example in C#.

The **Facade Pattern** provides a **unified and simplified interface** to a set of interfaces in a subsystem.  
In this example, the customer interacts only with the `RestaurantFacade`, which internally manages the **Waiter**, **Kitchen**, and **Billing** subsystems.

---

## 🧩 How It Works

1. **Kitchen (Subsystem)**  
   - Handles food preparation.

2. **Waiter (Subsystem)**  
   - Takes orders and serves food to customers.

3. **Billing (Subsystem)**  
   - Handles bill generation and payment.

4. **RestaurantFacade (Facade)**  
   - Provides a simplified method `OrderFood()` that manages all the steps internally.

5. **Program (Client)**  
   - The client interacts only with the facade — no need to directly call the individual subsystems.


---

## ⚙️ Key Concepts

| Concept | Description |
|----------|--------------|
| **Subsystems** | Independent parts of the system (Kitchen, Waiter, Billing). |
| **Facade** | Simplifies complex interactions by exposing one clean method (`OrderFood`). |
| **Client** | Uses the Facade instead of dealing with multiple subsystems directly. |

---

## 💡 When to Use the Facade Pattern

Use this pattern when:
- You want to **simplify complex system interactions** for clients.
- You want to **decouple clients** from subsystems.
- You’re building a **layered architecture**, and need a clean entry point to a set of classes.

---

## 🏗️ Pattern Type
**Structural Pattern** – focuses on how classes and objects are composed to form larger systems while hiding complexity.


