namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var train = new Train();

            train.DoubleWork<Train>();

            var factore = new Factory<Train>();
        }
    }
}