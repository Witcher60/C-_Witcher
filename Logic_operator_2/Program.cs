namespace Logic_operator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Завдання 1

            //int income = 150; //дохід за 100 рядків
            //int penalty_money = 20; //штраф за кожне третє запізнення
            //while (true)
            //{
            //    Console.WriteLine("Оберіть дію:\n1. Розрахувати кількість рядків коду для бажаного доходу та кількості запізнень.\n2. Розрахувати кількість запізнень для кількості рядків коду та бажаного доходу.\n3. Розрахувати дохід за кількість рядків коду та кількість запізнень.\n4. Вийти.");
            //    string choice = Console.ReadLine();
            //    if (choice == "1")
            //    {
            //        Console.Write("Введіть бажаний дохід Васі: ");
            //        decimal desirable_income = Convert.ToDecimal(Console.ReadLine());
            //        Console.Write("Введіть кількість запізнень: ");
            //        int penalties = Convert.ToInt32(Console.ReadLine());
            //        decimal total_penalty = (penalties / 3) * penalty_money;
            //        decimal total_income_need = desirable_income + total_penalty;
            //        decimal lines_of_code_need = (total_income_need / income) * 100;
            //        Console.WriteLine($"Васі потрібно написати {lines_of_code_need} рядків коду, щоб отримати такий дохід.");
            //    }
            //    else if (choice == "2")
            //    {
            //        Console.Write("Введіть кількість рядків коду, написаних Васею: ");
            //        decimal lines_of_code = Convert.ToDecimal(Console.ReadLine());
            //        Console.Write("Введіть бажаний обсяг зарплати: ");
            //        decimal desirable_income = Convert.ToDecimal(Console.ReadLine());
            //        decimal total_income = (lines_of_code / 100) * income;
            //        decimal max_penalties = (total_income - desirable_income) / penalty_money * 3;
            //        if (max_penalties < 0)
            //        {
            //            Console.WriteLine("Васі не вистачить доходу навіть без запізнень.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Вася може запізнитися максимум {Math.Floor(max_penalties)} разів.");
            //        }

            //    }
            //    else if (choice == "3")
            //    {
            //        Console.Write("Введіть кількість рядків коду, написаних Васею: ");
            //        decimal lines_of_code = Convert.ToDecimal(Console.ReadLine());
            //        Console.Write("Введіть кількість запізнень: ");
            //        int penalties = Convert.ToInt32(Console.ReadLine());
            //        decimal total_income = (lines_of_code / 100) * income;
            //        decimal total_penalty = (penalties / 3) * penalty_money;
            //        decimal final_income = total_income - total_penalty;
            //        if (final_income < 0)
            //        {
            //            Console.WriteLine("Васі не заплатять взагалі через штрафи.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Васі заплатять {final_income} доларів.");

            //        }
            //    }
            //}
            // Завдання 2 
            double brick_a, brick_b, brick_c;
            double hole_x, hole_y;
            Console.Write("Введіть довжину ребра a цегли: ");   
            brick_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть довжину ребра b цегли: ");
            brick_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть довжину ребра c цегли: ");
            brick_c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть довжину сторони x отвору: ");
            hole_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть довжину сторони y отвору: ");
            hole_y = Convert.ToDouble(Console.ReadLine());
            if ((brick_a <= hole_x && brick_b <= hole_y) || (brick_a <= hole_y && brick_b <= hole_x) ||
                (brick_a <= hole_x && brick_c <= hole_y) || (brick_a <= hole_y && brick_c <= hole_x) ||
                (brick_b <= hole_x && brick_c <= hole_y) || (brick_b <= hole_y && brick_c <= hole_x))
            {
                Console.WriteLine("Цегла пройде в отвір.");
            }
            else
            {
                Console.WriteLine("Цегла не пройде в отвір.");
            }
        }
    }
}
