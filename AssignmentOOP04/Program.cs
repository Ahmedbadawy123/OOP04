namespace AssignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            //Q1 Abstraction :

            // a) What is Abstraction in Object - Oriented Programming ?
            // Is The Process Of Hiding The Implementation Details And Showing Only The Essential Features Of An Object To The User [ Focus On What , Hide The How]

            // b) Why is abstraction considered one of the four pillars of OOP
            // Because It Reduces Complexity , Improves Maintainability , Enhances Security , Promotes Flexibilty and Reusiblity .


            // Q2 Abstract Classes vs. Interfaces:

            // a) What is the difference between an Abstract Class and an Interface?
            // Abstract Class : Can Have Abstract and Concrete Methods , Can Have Fields , Can Use Any Access Modifier , Class Can Inherit One Abstarct Class , Can Have CTOR , Provide Base Functionality and Common Behavior.
            // Interface : Is A Contract , Can Have Default and Static Methods , Cannot Have Fields , Members Are Public By Default and Interface Is Internal By Default [Have Internal , Public , Private ,Protected] , Class Can Implement Multiple Interfaces , Cannot Have CTOR .

            // b) When would you choose an Interface instead of an Abstract Class?
            // When Want To Define A Common Bahavior For UnRelated Classes , To Achieve Loose Coupling , To Support Multiple Inheritance Of Type , When Building A Plugin-Based Or Scalable System . 

            // c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // No, C# Does Not Support Multiple Class Inheritance.
            // Yes, A Class Can Implement Multiple Interfaces.

            #endregion

            #region Part 02 — Practical

            DeliveryAddress addr1 = new DeliveryAddress("Cairo" , "Main St", 123);
            DeliveryAddress addr2 = new DeliveryAddress("Giza" , "Elharam" , 456);
            DeliveryAddress addr3 = new DeliveryAddress("Berlin", "Main St", 33);

            StandardShipment std = new StandardShipment("SH001", "Laptop", 3m, 80m, addr1);
            ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, addr2, 30m);
            InternationalShipment intl = new InternationalShipment("SH003", "Television", 8m, 120m, addr3, "Germany", 100m);

            DeliveryCenter center = new DeliveryCenter("Giza");
            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(intl);


            center.PrintAllShipments();

       
            center.PrintTrackingStatuses();

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine($"Standard Shipment Insurance : {std.CalculateInsurance():0.00} EGP");
            Console.WriteLine($"Express Shipment Insurance : {exp.CalculateInsurance():0.00} EGP");
            Console.WriteLine($"International Shipment Insurance : {intl.CalculateInsurance():0.00} EGP");

            ITrackable[] trackables = new ITrackable[] { std, exp, intl };

 
            IInsurable[] insurables = new IInsurable[] { std, exp, intl };

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
        }

            #endregion
    
    }
}
