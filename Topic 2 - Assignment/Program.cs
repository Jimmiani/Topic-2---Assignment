namespace Topic_2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Emmett Cornies
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(2024 - 16);
            Thread.Sleep(500);
            Console.WriteLine((14 + 15 + 16) / 3);
            Thread.Sleep(500);
            Console.WriteLine(Math.Round((14.0 + 15 + 16 + 17) / 4, 2));
            Thread.Sleep(500);
            Console.WriteLine(Math.Round(Math.PI * (3 * 3), 1) + "cm^2");
            Thread.Sleep(500);
            Console.WriteLine("C# looks at both values on each side of the plus sign, and if either both of them are strings or one string and one numerical value it will concatenate. If Both values are numerical, it will perform addition");
            Console.ReadLine();
        }
    }
}
