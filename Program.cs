namespace NextLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator aCalculator = new Calculator();
            Console.WriteLine(aCalculator.Move("hello"));
        }
    }
}
