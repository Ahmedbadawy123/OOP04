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
        }
    }
}
