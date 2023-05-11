using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
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
