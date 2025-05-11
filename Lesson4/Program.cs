namespace Lesson4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out var age))
            {
                age = 0;
            }
            
            // TODO: Write some control logic where:
            // TODO: If their first name is missing (BullOrEmpty) display 'Missing first name'
            // TODO: Else if their age is missing (0) display 'Missing age'
            // TODO: Else if their age is below 10 display 'Too young'
            // TODO: Otherwise display 'Congrats!'
            // TODO: Then go fill out the tests :)
        }
    }
}