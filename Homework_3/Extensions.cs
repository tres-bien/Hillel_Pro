namespace Homework_3
{
    internal static class Extensions
    {

        public static void DoubleWork<T>(this T value) where T : IPull, IPush
        {
            value.Pull();
            value.Push();
        }
    }
}