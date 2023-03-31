namespace FindMaximumValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Test Maximum with Generics Problem");

            Console.WriteLine("Please enter the first number");
            string name1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string name2 = Console.ReadLine();

            Console.WriteLine("Please enter the third number");
            string name3 = Console.ReadLine();

            string val = FindMaxString_UC3.MaximumFloatNumber(name1, name2, name3);
            Console.WriteLine("{0} IS GREATER  VALUE.", val);
        }
    }
}