namespace par_programmering_01
{
    internal static class Reverse
    {
        public static string Run(string myString)
        {
            string reversedInput = "";

            foreach (var letter in myString)
            {
                reversedInput = letter + reversedInput;
            }
            return reversedInput;
        }
    }
}
