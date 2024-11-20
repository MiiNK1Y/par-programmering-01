namespace par_programmering_01
{
    internal class WithMenu
    {
        public static void Run()
        {
            writeMenu();
            char selected = getSelected();
            if (selected == 'q')
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
            Console.WriteLine("[1] Reverse string\n[2] Make uppercase\n[3] Make lowercase");
        }

        public static char getSelected()
        {
            Console.Write("\nSelect [1/2/3]: ");
            var input = Console.ReadLine() ?? "q";

            if (input.Length > 2 || input == " " || input == "q")
            {
                return 'q';
            }
            else
            {
                return Convert.ToChar(input);
            }
        }
    }
}
