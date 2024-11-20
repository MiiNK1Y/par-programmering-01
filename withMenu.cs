namespace linux
{
    internal class WithMenu
    {
        public static void Run()
        {
            writeMenu();
            var selected = getSelected();
            if (!selected)
            {
                return;
            }
            else
            {
                Console.WriteLine($"You wrote: {selected}");
            }
        }

        public static void writeMenu()
        {
            Console.WriteLine("Enter 'q' to exit.\n");
            Console.Write("[1] Reverse string\n[2] Make uppercase\n[3] Make lowercase");
        }

        public static char getSelected()
        {
            Console.Write("\nSelect [1/2/3]: ");
            var input = Console.ReadLine();

            if (input.length > 2 || input == " " || input == "q")
            {
                return 0;
            }
            else
            {
                return Convert.ToChar(input);
            }
        }
    }
}
