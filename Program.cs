namespace FindMaximumValue
{
    class Program
    {
        public static void Main()
        {
            int[] valuesInt = { 1, 2, 3, 4, 5 };
            double[] valuesDouble = { 10.4, 6.7, 8.2, 9.5, 7.3 };
            string[] valuesString = { "ram", "shiv", "radha", "mohan" };

            FindMax<int> obj = new FindMax<int>(valuesInt);
            obj.PrintMax();
            Console.WriteLine("**********************************************");


            FindMax<double> obj1 = new FindMax<double>(valuesDouble);
            obj1.PrintMax();
            Console.WriteLine("**********************************************");

            FindMax<string> obj2 = new FindMax<string>(valuesString);
            string MaxString = obj2.TestMaximum();
            obj2.PrintMax();

        }
    }
}