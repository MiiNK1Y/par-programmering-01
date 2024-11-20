namespace par_programmering_01
{
    internal static class WithMenu
    {
        public static string newString = "";

        public static void Run()
        {
            writeMenu();
            char selected = getSelected();
            string myString;

            switch (selected)
            {
                case '1':
                    myString = getString();
                    newString = Reverse.Run(myString);
                    Console.WriteLine($"Your string, reversed: {newString}");
                    //ReverseString();
                    break;
                case '2':
                    //ToUpperCase();
                    break;
                case '3':
                    //ToLowerCase();
                    break;
                default:
                    return;
            }
        }

        public static void writeMenu()
        {
            Console.WriteLine("Enter 'q' to exit.\n");
            Console.WriteLine("[1] Reverse string\n[2] Make uppercase\n[3] Make lowercase");
        }

        public static string getString()
        {
            Console.Write("Your string: ");
            string myString = Console.ReadLine() ?? " ";
            return myString;
        }

        public static char getSelected()
        {
            Console.Write("\nSelect [1/2/3]: ");
            var input = Console.ReadLine() ?? "q";
            return Convert.ToChar(input);
        }
    }
}
