namespace FindMaximumValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Test Maximum with Generics Problem");

            Console.WriteLine("Please enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double val = FindMaxFloat_UC2.MaximumFloatNumber(num1, num2, num3);
            Console.WriteLine("{0} IS GREATER  NUMBER.", val);
        }
    }
}