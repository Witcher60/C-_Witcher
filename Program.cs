namespace Logic_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Завдання 1 
            byte bal1 = 0, bal2 = 0, bal3 = 0, bal4 = 0, bal5 = 0;
            Console.WriteLine("Введіть 5 оцінок студента (від 1 до 12):");
            bal1 = Convert.ToByte(Console.ReadLine());
            bal2 = Convert.ToByte(Console.ReadLine());
            bal3 = Convert.ToByte(Console.ReadLine());
            bal4 = Convert.ToByte(Console.ReadLine());
            bal5 = Convert.ToByte(Console.ReadLine());
            double MidleBal = (bal1 + bal2 + bal3 + bal4 + bal5) / 5.0;
            if (MidleBal >= 4)
            {
                Console.WriteLine($"Студент допущений до іспиту. Середній бал: {MidleBal}");
            }
            else
            {
                Console.WriteLine($"Студент не допущений до іспиту. Середній бал: {MidleBal}");
            }

            //Завдання 2
            double distAB = 0.0, distBC = 0.0, weight = 0.0, distAC = 0.0;
            double fuel_plane = 300.0;
            Console.WriteLine("Введіть відстань між пунктами А і В (км):");
            distAB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть відстань між пунктами В і С (км):");
            distBC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть вагу вантажу (кг):");
            weight = Convert.ToDouble(Console.ReadLine());
            distAC = distAB + distBC;
            double fuel_per_km = 0.0;
            if (weight <= 500.0)
            {
                fuel_per_km = 1.0;
            }
            else if (weight <= 1000.0)
            {
                fuel_per_km = 4;
            }
            else if (weight <= 1500.0)
            {
                fuel_per_km = 7.0;
            }
            else if (weight <= 2000.0)
            {
                fuel_per_km = 9.0;
            }
            else
            {
                Console.WriteLine("Літак не піднімає вантаж більше ніж 2000 кг.");
                return;
            }
            double total_fuel_need = distAC * fuel_per_km;
            double fuel_needed_in_B = total_fuel_need - fuel_plane;
            double fuel_needed_in_AB = distAB * fuel_per_km;
            if (fuel_needed_in_AB > fuel_plane)
            {
                Console.WriteLine("Неможливо подолати відстань між пунктами А і В з даною вагою вантажу.");
            }
            else
            {
                if (fuel_needed_in_B > 0)
                {
                    Console.WriteLine($"Мінімальна кількість палива, необхідна для дозаправки в пункті В: {fuel_needed_in_B} літрів.");
                }
                else
                {
                    Console.WriteLine("Дозаправка в пункті В не потрібна.");
                }
            }
            }
        }
    }
