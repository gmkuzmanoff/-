using System;

namespace Квадратно_уравнение
{
    class Program
    {
        double a, b, c, D, x1, x2;


        public void EnterA()
        {
            Console.WriteLine("\nВъведи (a) : ");
            a = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("Условие: a ≠ 0 (числото трябва да е различно от нула)");
                Console.WriteLine("\nВъведи (a) : ");
                a = double.Parse(Console.ReadLine());
            }
        }
        public void EnterB()
        {
            Console.WriteLine("Въведи (b) : ");
            b = double.Parse(Console.ReadLine());
        }
        public void EnterC()
        {
            Console.WriteLine("Въведи (c) : ");
            c = double.Parse(Console.ReadLine());
        }
        public void Diskriminanta()
        {
            Console.WriteLine($"\nD = {b}² - 4 * {a} * {c}");
            double bb = b * b;
            double ac = 4 * a * c;
            Console.WriteLine($"D = {bb} - {ac}");
            D = (b * b) - 4 * a * c;
            Console.WriteLine($"D = {D}");
            Console.WriteLine($"\nДискриминантата (D) е : {D}");
        }
        public void Koreni()
        {
            if (D < 0)
            {
                Console.WriteLine("\nРешение : Kвадратното уравнение няма реални корени");
                Console.WriteLine("\n--------------------------------------------------");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("\nРешение : Квадратното уравнение има 1 реален корен (х1 = х2)\n");
                Console.WriteLine(" x1 = x2 = " + Math.Round(x1,2));
                Console.WriteLine("\n------------------------------------------------------------");
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("\nРешение : Квадратното уравнение има 2 реални корена (х1,х2)\n");
                Console.WriteLine(" x1 = " + Math.Round(x1, 2));
                Console.WriteLine(" x2 = " + Math.Round(x2, 2));
                Console.WriteLine("\n-------------------------------------------------------------");
            }
        }

        static void Main()
        { 
            Program program = new Program();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Copyright (C) GMKuzmanoff . All rights reserved.\n");
            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Програма за решаване на квадратно уравнение");
            Console.WriteLine("___________________________________________\n");
            Console.WriteLine("Уравнение от вида: a² + b² + c = 0 се нарича квадратно, където");
            Console.WriteLine("a,b,c са реални числа, и a ≠ 0. Всяко квадратно уравнение може да има 0, 1 или 2 реални корена.");
            Console.WriteLine("Числото D = b² - 4 * a * c се нарича дискриминанта.");
            Console.WriteLine("Ako D < 0, квадратното уравнение няма реални корени.\nAko D = 0, уравнението има 1 реален корен.\nAko D > 0, квадратното уравнение има 2 реални корена.");
            while (true)
            {
                try
                {
                    program.EnterA();
                    program.EnterB();
                    program.EnterC();
                    program.Diskriminanta();
                    program.Koreni();
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message + "\nГрешен вход!(Следващият път въведете цяло или реално число)\n");
                }
            }
        }
    }
}          
    

