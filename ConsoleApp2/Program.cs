namespace ConsoleApp2
{

    using System;
    using System.Security.Claims;
            class Program
            {
                static void Main()
                {
            #region Q1What is abstraction in OOP? How is it different from encapsulation? Give a real-world example (not from the session) that shows the difference between the two.
            //// Abstraction in OOP is the concept of hiding the complex implementation details and showing only the necessary features of an object.
            //// It allows us to focus on what an object does rather than how it does it.
            //// Encapsulation, on the other hand, is the concept of bundling data and methods that operate on that data within a single unit (class) and restricting access to some of the object's components.
            //// For example, consider a car.
            //// The abstraction of a car would be the interface that allows you to start the engine, accelerate, brake, and steer. You don't need to know how the engine works or how the braking system functions to use the car.
            //// Encapsulation would be the actual implementation of the car's internal components, such as the engine, transmission, and braking system, which are hidden from the user and can only be accessed through the defined interface (abstraction).
            //// In this example, the abstraction is the user interface of the car (steering wheel, pedals, etc.), while encapsulation is the internal workings of the car that are hidden from the user.

            #endregion
            #region Q2
            //// 1. An abstract class can have both abstract and non-abstract methods, while an interface can only have abstract methods (until C# 8.0, which introduced default implementations in interfaces).
            //// 2. A class can inherit
            //// from only one abstract class, but it can implement multiple interfaces.
            //// 3. An abstract class can have fields and constructors, while an interface cannot have fields and constructors.
            //// 4. An abstract class can provide a default implementation for some methods, while an interface cannot provide any implementation (until C# 8.0).
            //// You would choose an abstract class when you want to provide a common base class with shared
            //// implementation for related classes. You would choose an interface when you want to define a contract that multiple classes can implement, regardless of their position in the class hierarchy.
            #endregion


            #region Q3
            ////the answer to a) is no, because Appliance is an abstract class and cannot be instantiated directly. You would need to create an instance of a concrete subclass (like Toaster or WashingMachine) that inherits from Appliance.
            ////the answer to b) is that PowerConsumption() is abstract because it must be implemented by any concrete subclass of Appliance, as the power consumption will vary between different types of appliances. Status() is virtual because it provides a default implementation (returning "Standby") that can be overridden by subclasses if they have a different status. Label() is concrete because it provides a complete implementation that can be used by all subclasses without modification.
            ////the answer to c) is that it will return "Standby" because the Toaster class does not override the Status() method, so it uses the default implementation provided by the Appliance class.
            #endregion


            #region Q4 
            ////            a) What is a partial class? Why would a developer split Calculator into two files?
            //// A partial class allows a single class definition to be split across multiple physical files.Developers use this to:
            ////1.Organize large classes by separating different concerns(e.g., UI logic vs.business logic).
            ////2.Separate generated code from manual code(common in UI frameworks like WinForms or WPF).
            ////3.Allow multiple developers to work on the same class simultaneously without merge conflicts.
            ////b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            ////A partial method has its signature defined in one part of a partial class and its implementation optionally provided in another.
            ////If the implementation is deleted, the code will still compile.The C# compiler simply removes the call to the partial method and the signature itself during compilation if no implementation is found.
            ////c) What is an extension method? What are the three rules for writing one?
            ////An extension method allows you to "add" methods to existing types without creating a new derived type or modifying the original type.
            ////Rules:
            ////1.The method must be defined inside a static class.
            ////2.The method itself must be static.
            ////3.The first parameter must use the this keyword followed by the type being extended.
            ////d) What will the following code print?
            ////Plain Text
            ////Log: result = 20
            ////$20.00
            #endregion
            #region part2

            //Cinema cinema = new Cinema();
            //        cinema.Open();

            //        // a. Compiler prevents: Ticket t = new Ticket("Test", "A1", 100);

            // StandardTicket t1 = new StandardTicket("Inception", "A5", 80);
            //        VIPTicket t2 = new VIPTicket("Avengers", "L1", 200);
            //        IMAXTicket t3 = new IMAXTicket("Dune", "S1", 130);

            //        t1.Book(); t2.Book(); t3.Book();
            //        cinema.AddTicket(t1); cinema.AddTicket(t2); cinema.AddTicket(t3);

            //        cinema.PrintAllTickets();

            //        Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");
            //        Ticket[] tickets = cinema.GetAllTickets();
            //        foreach (var t in tickets)
            //            Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");

            //        Console.WriteLine("--- Extension Method: Receipt ---\n" + t2.GenerateReceipt());

            //        Console.WriteLine("--- Extension Method: Total Revenue ---");
            //        Console.WriteLine($"Total Revenue: {tickets.CalculateTotalRevenue():F2}");

            //        cinema.Close();
            #endregion
        }
    }
        }




     
