using static System.Console;

namespace Lab8
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public uint Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salary}";
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            var anna = new Employee { Id = 1, Name = "Anna", Gender = Gender.Female, Salary = 1_000_000 };
            var jhon = new Employee { Id = 1, Name = "Jhon", Gender = Gender.Male, Salary = 3_700_000 };
            var joe = new Employee { Id = 1, Name = "Joe", Gender = Gender.Male, Salary = 2_890_000 };
            var maria = new Employee { Id = 1, Name = "Maria", Gender = Gender.Female, Salary = 5_000_000 };
            var peter = new Employee { Id = 1, Name = "Peter", Gender = Gender.Male, Salary = 2_260_000 };

#region Del1
            WriteLine("Del 1");

            // Skapa en stack med objekten:
            Stack<Employee> emplStack = new Stack<Employee>();
            emplStack.Push(anna);
            emplStack.Push(jhon);
            emplStack.Push(joe);
            emplStack.Push(maria);
            emplStack.Push(peter);

            #region Skriver ut alla objekt i min stack:

            WriteLine("\n------------------------------------------------------------");

            foreach (var empl in emplStack)
            {
                ItemsLeftInStack<Employee>(emplStack);
                WriteLine(empl);
            }

            #endregion

            #region Hämta alla genom Pop metoden:

            WriteLine("\n------------------------------------------------------------");

            WriteLine("Retrive using Pop method:");
            
            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Pop());

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Pop());

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Pop());

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Pop());

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Pop());

            // lägger alla tillbaka
            emplStack.Push(anna);
            emplStack.Push(jhon);
            emplStack.Push(joe);
            emplStack.Push(maria);
            emplStack.Push(peter);

            #endregion

            #region Hämta alla objecten Peek metoden

            WriteLine("\n------------------------------------------------------------");
            
            WriteLine("Retrive using Peek method:");

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Peek());

            ItemsLeftInStack<Employee>(emplStack);
            WriteLine(emplStack.Peek());

            #endregion

            #region Kolla om objekt nummer 3 finns kvar i stacken

            if (emplStack.ToArray()[2] != null)
                WriteLine("Emp3 is in stack");
            else
                WriteLine("Emp3 is not in stack");
            #endregion

            #endregion Del1


            #region Del2

            WriteLine("\n------------------------------------------------------------");

            WriteLine("Del 2\n");

            List<Employee> emplList = new List<Employee>()
            {
                anna, jhon, joe, maria, peter
            };

            if (emplList.Contains(joe))
                WriteLine("Joe object exist in the list");
            else
                WriteLine("Joe object does not exist in the list");

            WriteLine();

            var firstMale = emplList.Find(e => e.Gender == Gender.Male);
            WriteLine(firstMale);

            WriteLine();

            var allMales = emplList.FindAll(e => e.Gender == Gender.Male);
            foreach (var male in allMales)
                WriteLine(male);


            #endregion Del2

        }

        static void ItemsLeftInStack<T>(Stack<T> stackItems) where T: class
        {
            WriteLine($"Items left in the stack = {stackItems.Count()}");
        }
    }
}