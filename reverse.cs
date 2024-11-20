namespace par_programmering_01
{
    public static class Reverse
    {
        public static void Run()
        {
            Console.WriteLine("Hei, Skriv inn en tekst du ønsker å få reversert :)");

            Console.Write("Din input: ");
            var input = Console.ReadLine() ?? "";
            string reversedInput = "";

            foreach (var letter in input)
            {
                reversedInput = letter + reversedInput;
            }

            Console.WriteLine($"Du skrev: {input}\nReversert blir det: {reversedInput}");
        }
    }
}
