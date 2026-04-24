#  Order Notification System

##  Project Description

This is a console application that simulates placing an order and notifying multiple services (Email & SMS) using Delegates and Events in C#.

---

##  Concepts Used

###  Delegate

I used a delegate in the form of:

```csharp
Action<Order>
```

This delegate is used to reference methods that handle order notifications.

---

###  Event

The event is implemented in the `OrderService` class:

```csharp
public event Action<Order>? OnOrderPlaced;
```

This event is triggered when an order is placed and is used to notify all subscribed services.

---

###  Lambda Expression

I used a lambda expression in `Program.cs`:

```csharp
orderService.OnOrderPlaced += o => Console.WriteLine(o.FormatMessage());
```

This simplifies writing a method inline without creating a separate function.

---

###  Extension Method

I created an extension method in `OrderExtensions.cs`:

```csharp
public static string FormatMessage(this Order order)
```

This method formats the order details into a readable message.

---

###  Func

I used `Func` in `OrderService` to filter orders before sending notifications:

```csharp
Func<Order, bool> filter = o => o.Price > 100;
```

Only orders with price greater than 100 will trigger notifications.

---

###  Action

`Action<Order>` is used as a delegate type for the event to execute notification methods without returning a value.

---

###  Predicate

Although `Predicate<T>` was not explicitly used, the same logic was achieved using `Func<Order, bool>` which serves a similar purpose (returning true/false).

---

##  How It Works

1. An order is created.
2. The order is passed to `OrderService`.
3. If it passes the filter condition, the event is triggered.
4. All subscribed services (Email & SMS) are notified.
5. A formatted message is printed using an extension method.

---

## Output Example

```
Order Placed
Email sent for order 1
SMS sent for order 1
Order #1 for Ali costs 150
```

---

##  Project Structure

```
Models/
Services/
Extensions/
Program.cs
Program.cs
```
