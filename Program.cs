using System;

namespace ZooProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooController zoo = ZooController.GetInstance();
            SeedData(zoo);

            bool running = true;
            while (running)
            {
                PrintMenu();
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        zoo.ShowAllCreatures();
                        break;
                    case "2":
                        AddMammal(zoo);
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n--- Zoo Management ---");
            Console.WriteLine("1. Show animals");
            Console.WriteLine("2. Add mammal");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
        }

        private static void SeedData(ZooController zoo)
        {
            zoo.AddCreature(new Mammal("Barsik", 5, "Forest", "Predator", true));
            zoo.AddCreature(new Bird("Kesha", 2, "Jungle", "Herbivore", 0.5));
        }

        private static void AddMammal(ZooController zoo)
        {
            try
            {
                Console.Write("Name: ");
                string name = Console.ReadLine() ?? "Unknown";

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Habitat: ");
                string habitat = Console.ReadLine() ?? "Wild";

                Console.Write("Diet: ");
                string diet = Console.ReadLine() ?? "Omnivore";

                Console.Write("Has fur (true/false): ");
                bool hasFur = bool.Parse(Console.ReadLine() ?? "false");

                Mammal newMammal = new Mammal(name, age, habitat, diet, hasFur);
                zoo.AddCreature(newMammal);
                Console.WriteLine("Mammal added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Input error: {ex.Message}");
            }
        }
    }
}