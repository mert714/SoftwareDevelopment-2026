namespace StudentsRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Възраст:");

            if (int.TryParse(Console.ReadLine(), out int age))

            {
                Console.WriteLine($"Възраст{age}");
            }
            else
            {
                Console.WriteLine("Невалидна възраст");
            }


            static void Zadacha2()
            {
                Console.Write("Клас на ученика: ");

                if (byte.TryParse(Console.ReadLine(), out byte grade))
                {
                    Console.WriteLine($"Клас: {grade}");
                }
                else
                {
                    Console.WriteLine("Невалиден клас.");
                }
            }

            static void Zadacha3()
            {
                Console.Write("Среден успех: ");

                if (double.TryParse(Console.ReadLine(), out double grade))
                {
                    Console.WriteLine($"Среден успех: {grade}");
                }
                else
                {
                    Console.WriteLine("Невалиден среден успех.");
                }
            }

            static void Zadacha4()
            {
                Console.Write("Парична стойност: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal money))
                {
                    Console.WriteLine($"Парична стойност: {money}");
                }
                else
                {
                    Console.WriteLine("Невалидна парична стойност.");
                }
            }

            static void Zadacha5()
            {
                Console.Write("Има ли стипендия (true/false): ");

                if (bool.TryParse(Console.ReadLine(), out bool hasScholarship))
                {
                    Console.WriteLine(hasScholarship);
                }
                else
                {
                    Console.WriteLine("Невалиден отговор.");
                }
            }

            static void Zadacha6()
            {
                Console.Write("Въведете буква на паралелката");

                if (char.TryParse(Console.ReadLine(), out char ch))
                {
                    Console.WriteLine(ch); 
                
                }
                else
                {
                    Console.WriteLine("Несъществуваща паралелка");
                }
                    }

            static void Zadacha7()
            {
                Console.Write("Дата на раждане: ");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    Console.WriteLine($"Дата: {birthDate:d}");
                }
                else
                {
                    Console.WriteLine("Невалидна дата.");
                }
            }

            static void Zadacha8()
            {
                DateTime birthDate;

                while (true)
                {
                    Console.Write("Дата на раждане: ");

                    if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    {
                        break;
                    }

                    Console.WriteLine("Невалидна дата. Опитайте отново.");
                }

                Console.WriteLine($"Въведена дата: {birthDate:d}");
            }

            static void Zadacha9()
            {
                static void Zadacha9()
                {
                    int age;

                    Console.Write("Възраст: ");

                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Въведете цяло число:");
                    }

                    Console.WriteLine($"Възраст: {age}");
                }
            }
        }

    }
}
