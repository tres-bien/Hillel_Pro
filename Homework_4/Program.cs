namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumOfOddSquaredNumbers();

            string[] names = { "Liam", "Olivia", "Noah", "Emma", "Oliver", "Charlotte", "Elijah", "Amelia", "James", "Ava",
                     "William", "Sophia", "Benjamin", "Isabella", "Lucas", "Mia", "Henry", "Evelyn", "Theodore", "Harper" };
            var rand = new Random();
            var people = new People();

            for (int i = 0; i < 100; i++)
            {
                people.Create(new Person { Name = names[rand.Next(names.Length)], Age = (byte)rand.Next(100) });
            }

            people.Show();
            Console.WriteLine();
            people.Show(people.FilterByAgeMore(20));
            Console.WriteLine();
            people.Show(people.FilterByAgeMore(20).GetPenultimate());

            Console.WriteLine();
            people.Show(people.FilterByAgeAndSortAlfabetical(20));
            Console.WriteLine();
            people.Show(people.FilterByAgeAndSortAlfabetical(20).GetPenultimate());

            Console.WriteLine();
            people.Show(people.FilterByAgeAndGroupByAge(20));
            Console.WriteLine();
            people.Show(people.FilterByAgeAndGroupByAge(20).GetPenultimate());
        }

        private static void SumOfOddSquaredNumbers()
        {
            byte[] age = new byte[100];

            for (byte i = 0; i < age.Length; i++)
            {
                age[i] = i;
            }
            Console.WriteLine(age.Where(x => x % 2 != 0).Select(x => x * x).Sum());
        }
    }
}