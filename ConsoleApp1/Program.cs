namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Chec1() & Chec2())
            {
                Console.WriteLine();
            }
        }

        static bool Chec1()
        {
            Console.WriteLine("Chec1");
            return false;
        }
        
        static bool Chec2()
        {
            Console.WriteLine("Chec2");
            return true;
        }
    }
}