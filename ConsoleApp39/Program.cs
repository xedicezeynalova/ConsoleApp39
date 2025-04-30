namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime DateOfTheBirth = new DateTime(2007, 07, 07);
             TimeSpan ts = DateTime.Now - DateOfTheBirth;
             Console.WriteLine(ts.TotalDays);
        }
    }
}
