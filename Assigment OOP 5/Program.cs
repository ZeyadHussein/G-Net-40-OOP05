namespace Assigment_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1: Theoretical Questions
            #region Question 1: What is an interface in C#?
            /*
            Q1: What is an interface in C#? Why do we use interfaces
            instead of depending on concrete classes directly?
            Mention at least three benefits of using interfaces.
            */

            //Answer:
            // An interface in C# is a contract that defines a set of methods,
            //properties, or events that a class must implement.
            //It does not contain implementation — only signatures.
           
            // We use interfaces instead of concrete classes to achieve abstraction
            //and loose coupling.
            
            // Benefits:
            //1) Loose Coupling – Code depends on abstraction, not implementation.
            //2) Flexibility & Extensibility – We can replace implementations without changing code.
            //3) Polymorphism – Different classes can be treated the same way.
            //4) Testability – Easier to mock interfaces in unit testing.
            #endregion
            #endregion
        }
    }
}
