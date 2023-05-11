using static System.Net.Mime.MediaTypeNames;

namespace Homework_5_Simple_solution
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press any key to show text");
            Console.ReadLine();

            var task1 = Task.Run(() => TextReader.Read(1000, ConsoleColor.DarkBlue));
            var task2 = Task.Run(() => TextReader.Read(100, ConsoleColor.Yellow));
            var task3 = Task.Run(() => TextReader.Read(500, ConsoleColor.Green));

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        internal static class TextReader
        {
            private static object mock = new();

            private static List<string> GetPaths()
            {
                List<string> paths = Directory.EnumerateFiles(@"G:\myFolder\Hillel_Pro\Homework_5\Text", "*.txt", SearchOption.AllDirectories).ToList();
                return paths;
            }

            public static async Task Read(int delay, ConsoleColor color)
            {
                string text = string.Empty;
                foreach (string path in GetPaths())
                {
                    var readStream = new StreamReader(File.OpenRead(path));
                    while (!readStream.EndOfStream)
                    {
                        text = await readStream.ReadLineAsync();
                        Write(text, color);
                    }
                    await Task.Delay(delay);
                }
            }

            public static async void Write(string text, ConsoleColor color)
            {
                lock (mock)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(text);
                    Console.ResetColor();
                }
            }
        }
    }
}