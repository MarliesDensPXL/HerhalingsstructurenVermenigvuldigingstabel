namespace Vermenigvuldigingstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vermenigvuldigingstafels");
            Console.ResetColor();
            Console.WriteLine();

            bool isValid = false;
            int number;

            do
            { 
                Console.Write("Geef een getal tussen 1 en 10: ");
                isValid = (int.TryParse(Console.ReadLine(), out number)) && number <= 10 && number > 0;

            } while (isValid == false);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"\t{i}");
            }

            Console.WriteLine();
            Console.ResetColor();

            for (int i = 1; i <= number; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{i} ");
                Console.ResetColor();

                for (int y = 1; y <= number; y++)
                {
                    
                    Console.Write($"\t{i * y}");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
