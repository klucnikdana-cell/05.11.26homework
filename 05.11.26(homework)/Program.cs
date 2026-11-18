namespace _05._11._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------TASK1-----------");
            Console.WriteLine($"Max: {ArithmeticMax.Max(30, 20, 46)}");

            Console.WriteLine("\n----------TASK2-----------");
            Console.WriteLine($"Min: {ArithmeticMin.Min(70, 40, 20)}");

            Console.WriteLine("\n----------TASK3-----------");
            int[] numbers = { 25, 25, 25 };
            Console.WriteLine($"Sum: {ArithmeticMethod.Sum(numbers)}");

        }
    }
}
