namespace FindMaximumValue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Test Maximum with Generics Problem");

            int[] valuesInt = { 1, 2, 3, 4, 5 };
            double[] valuesDouble = { 10.4, 6.7, 8.2, 9.5, 7.3 };
            string[] valuesString = { "ram", "shiv", "radha" };

            FindMax<int> obj = new FindMax<int>(valuesInt);
            int MaxInt = obj.TestMaximum();
            Console.WriteLine("Maximum value in integer is: " + MaxInt);
            Console.WriteLine("**********************************************");


            FindMax<double> obj1 = new FindMax<double>(valuesDouble);
            double MaxDouble = obj1.TestMaximum();
            Console.WriteLine("Maximum value in double is: " + MaxDouble);
            Console.WriteLine("**********************************************");

            FindMax<string> obj2 = new FindMax<string>(valuesString);
            string MaxString = obj2.TestMaximum();
            Console.WriteLine("Maximum value in string is: " + MaxString);
            Console.WriteLine("**********************************************");

        }
    }
}