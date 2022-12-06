using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * height;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }

                int spaceToTake = int.Parse(command);
                if (spaceToTake > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {spaceToTake - freeSpace} Cubic meters more.");
                    break;
                }

                freeSpace -= spaceToTake;
                if (freeSpace == 0)
                {
                    Console.WriteLine($"0 Cubic meters left.");
                    break;

                }
            }
        }
    }
}
