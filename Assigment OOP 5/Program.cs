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

            #region Q2
            /*
            Q2:
            a) What is the problem with this design?
            b) How would you fix it?
            c) After fixing, can you call translator.Greet() directly?
            */

            /// Answer:

            /// a)
            /// Both interfaces contain a method with the same name (Greet).
            /// Currently, Translator implements only one public Greet()
            /// that serves both interfaces.
            /// This means both interfaces behave the same way,
            /// which defeats the purpose of having two separate contracts.

            /// b)
            /// We fix it using Explicit Interface Implementation.

            /// This technique is called:
            /// ➤ Explicit Interface Implementation

            /// c)
            /// No, you CANNOT call translator.Greet() directly.
            /// Because explicit implementations are not public methods.
            ///
            /// You must cast:
            /// CODE PART


            /// Translator translator = new Translator();
            /// ((IEnglishSpeaker)translator).Greet();  // Hello
            /// ((IArabicSpeaker)translator).Greet();   // Ahlan

            #endregion

            #region Question 3:Explain shallow copy vs deep copy.
            /*
            Q3: Explain shallow copy vs deep copy.
            */

            /// Answer:

            /// Shallow Copy:
            /// Copies value types normally,
            /// but copies references for reference-type fields.
            /// Both objects share the same referenced objects.

            /// Deep Copy:
            /// Creates completely independent copies,
            /// including all referenced objects.

            /// Risk of shallow copy:
            /// If the object contains reference-type fields,
            /// modifying the copied object's reference will affect the original.

            /// Use shallow copy:
            /// When object contains only value types
            /// or shared references are acceptable.

            /// Use deep copy:
            /// When full independence is required.
            #endregion

            #region Qouestion 4: Determine the output and explain why.
            /*
            Q4: Determine the output and explain why.
            */

            //test part:
            //Employee e1 = new Employee
            //{
            //    Title = "Dev",
            //    Dept = new Department { Name = "IT" }
            //};

            //Employee e2 = e1.ShallowCopy();

            //e2.Title = "QA";
            //e2.Dept.Name = "Testing";

            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");

            /*
            Expected Output:

            Dev - Testing
            QA - Testing

            Explanation: e2 is a shallow copy.Title is a string (immutable reference), so changing e2.Title does NOT affect e1.

            BUT Dept is a reference type. Both e1 and e2 reference the SAME Department object.

            So when: e2.Dept.Name = "Testing";

            It affects both objects.

            Therefore:e1.Title remains "Dev"  e1.Dept.Name becomes "Testing"
            */
            #endregion

            #endregion

            #region Part 2:  Practical (Extending the Movie Ticket Booking System)
        
            Cinema cinema = new Cinema();
            cinema.Open();

            StandardTicket t1 = new StandardTicket("Inception", "A5", 80);
            VIPTicket t2 = new VIPTicket("Avengers", 200, true, 50);
            IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            Console.WriteLine("\n--- Clone Test ---");

            VIPTicket clone = (VIPTicket)t2.Clone();
            clone.MovieName = "Interstellar";

            Console.Write("Original : ");
            t2.Print();
            Console.Write("Clone    : ");
            clone.Print();

            Console.WriteLine("\n--- After Cancellation ---");
            t1.Cancel();
            t1.Print();

            BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

            cinema.Close();


            #endregion
        }
    }
}
