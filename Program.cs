namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();

            Console.WriteLine(aCalculator.CountWords("This is a test."));
        }
    }
}
