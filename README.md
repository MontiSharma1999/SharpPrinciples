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

## Single Responsibility Principle : 
a class should have single responsibility, and only one reason to change  
to achieve: make sure a class have only relatable methods inside it  
e.g. : we can assume like that we have class OrderManager that responsibilities  
   1. PlaceOrder  
   2. GenerateInvoice  
   3. SendEmail  
it is a voilation of SRP or bad code  
now, how we can change our class to follow SRP  
Create seprate class for each things bcoz each responsibility is different from other  
so, we can create different different class for this like  
   1. OrderService -> PlaceOrder (contains order related services)  
   2. InvoiceService -> GenerateInvoice  
   3. EmailService -> SendEmail  

---

## Open & Closed Principle : 
A entity should be open for extension and closed for modification  
e.g. we can assume like that we have class Paymentprocessor and its working is simple get amount  
and payment type and process the payment.  

without following OCP is like we create method in this class where we passing payment method as a string  
what goes wrong this is, if we add another payment method then we need to change Paymentprocessor class  
where we need to add one more check for new payment method  

So, prevent or avoid a voilation of OCP what we need to do is  
add Interface for PaymentMethod that have Pay method and create classes for PaymentMethod's(UPI, Card, NetBanking) and Pass this Interface into Paymentprocessor class method  

---

## Liskov Substitution Principle : 
A derived class object is purely a substitute for its base class.  
e.g. like we have base class bird and in this a virtual method is fly()  
then if we inherit this into derived class name penguin or ostrich both are parts of bird but they can't fly  
so, the conclusion is we can say that a derived class object is not fully a substitute for its base class.  

So, what we do in this, in my POV remove uncommon functionality from base class, only contains those are common like eat, sleep in above case, let derived class handle fly functionality it self.  

---

## Interface Segregation Principle : 
A class should only depend on methods it actually uses.  
in other words -> Keep interfaces small and focused so clients only use what they need.  
e.g. we have interface like IMachine it have definition of Print(), Scan(), and Copy() methods  
and Classes whose are implementing this interface, BasicPrinter and SmartPrinter  
but what is the catch here  
BasicPrinter have only printing functionality but it is forced to implement Scan and Copy  
thus, here we are voilating the ISP  

To avoid this, we should break a big interface into smaller ones focused on related tasks.  
Like, IPrinter for Printing and IScanner for Scanning and ICopier for Copy and Now, BasicPrinter will only  
implement IPrinter interface, while SmartPrinter will implement all interfaces according to its functionality.  

---

## Dependency Inversion Principle : 
It says High-level modules are not directly depends or connect on Low-level modules, they both depends on abstraction.  
e.g. like we have NotificationService that composite(has-a relationship) EmailService and SMSService  
and we instantiate objects of EmailService and SMSService in the constructor using 'new' Keyword  
it is leading to tight coupling, basically using new keyword we tightly coupled them and this make is harder to test or replace EmailService and SMSService with mockversions  
Or, If we interduce new service like WhatsApp message or any Service in the future then we need to change in NotificationService's class code thus we voilate DIP  

To avoid this what we need to create INotificationChannel interface that have definition of Send()  
And All Services(EmailService, SMSService) implement this interface and  
In NotificationService we create private variable of INotificationChannel(it called Abstraction), then instantiate into constructor using INotificationChannel parameter  

```csharp
private INotificationChannel channel; 
public NotificationService(INotificationChannel notificationChannel)<br>
{
	channel = notificationChannel;
}
```
public NotificationService(INotificationChannel notificationChannel) this part refers the Constructor Injection
	it is type of Dependency Injection.
 
# SOLID Principles Summary Table

| Principle | Definition | Voilate | Functionalities | Prevent or Avoid Voilate | Separated Functions |
|----------|-------------|---------|------------------|---------------------------|---------------------|
| **SRP** | a class should have single responsibility | OrderManager | PlaceOrder, GenerateInvoice, SendEmail | OrderService, InvoiceService, EmailService | PlaceOrder, GenerateInvoice, SendEmail |
| **OCP** | open for extension and closed for modification | Paymentprocessor | payment method using string | IPaymentMethod, UPI, Card, NetBanking | Pay |
| **LSP** | derived class object is substitute of base class | Bird → Penguin | Fly | Remove Fly from base class | Eat, Sleep in base class |
| **ISP** | only depend on methods it uses | IMachine | Print, Scan, Copy | IPrinter, IScanner, ICopier | split into focused interfaces |
| **DIP** | high-level module depends on abstraction | NotificationService with new EmailService() | Send | INotificationChannel + Constructor Injection | EmailService, SMSService |



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

