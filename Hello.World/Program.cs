namespace Hello.World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // take day from user and get the name of the day
            string day, month, year;

            Console.WriteLine("Enter Your BirthDate");
            DateOnly birthdate = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine($"{birthdate.DayOfWeek}");
           

            Console.WriteLine($"{birthdate.DayOfWeek} of Month {birthdate: MMMM} Year {birthdate.Year}");
        }
    }
}
