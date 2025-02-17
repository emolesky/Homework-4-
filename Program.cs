namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            Console.WriteLine(aCalculator.FirstNVowels("Sharpening skills" ,3));
        }
    }
}
