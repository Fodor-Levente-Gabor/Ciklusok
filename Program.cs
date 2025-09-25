using System;

namespace Ciklsok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Feladat1
            Console.Write("Írj be egy számot: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Írj be egy másik számot: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"{num1 - num2} a különbség.");
            }
            else
            {
                Console.WriteLine($"{num2 - num1} a különbség.");
            }
            //Feladat2
            List<int> numbers = new List<int>();
            Console.Write("Adj meg egy számot: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            while (num3 != 0)
            {
                Console.Write("Adj meg egy számot: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num3);
            }
            
            //Feladat3
            List<int> numbersParos = new List<int>();
            List<int> numbersParatlan = new List<int>();
            for (int a = 0;a <= 10;a++)
            {
                Console.Write("Adj meg egy számot: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                if (num4 % 2 == 0)
                {
                    numbersParos.Add(num4);
                }
                else
                {
                    numbersParatlan.Add(num4);
                }
                
            }

            Console.WriteLine($"{numbersParatlan.Count}");
            for (int a = 0;a < numbersParatlan.Count;a++)
            {
                Console.WriteLine($"{numbersParatlan[a]}");
            }

            Console.WriteLine($"{numbersParos.Count}");
            for (int a = 0; a < numbersParos.Count; a++)
            {
                Console.WriteLine($"{numbersParos[a]}");
            }
            
            //Feladat4
            Console.Write("Írj be egy szót: ");
            string word = Console.ReadLine();
            int wordLengthCounter = 0;
            if (word.Length > 5)
            {
                wordLengthCounter++;
            }
            while (word != "vége")
            {
                Console.Write("Írj be egy szót: ");
                word = Console.ReadLine();
                if (word.Length > 5)
                {
                    wordLengthCounter++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"{wordLengthCounter}");
            
            //Feladat5
            int jegy1 = 0;
            int jegy2 = 0;
            int jegy3 = 0;
            int jegy4 = 0;
            int jegy5 = 0;
            int all = 0;
            int allCounter = 0;
            Console.Write("Adj meg egy érdemjegyet: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            while(num5 != -1)
            {
                switch(num5)
                { 
                    case 1:
                        jegy1++;
                        all = all + 1;
                        allCounter++;
                        break;
                    case 2:
                        jegy2++;
                        all = all + 2;
                        allCounter++;
                        break;
                    case 3:
                        jegy3++;
                        all = all + 3;
                        allCounter++;
                        break;
                    case 4:
                        jegy4++;
                        all = all + 4;
                        allCounter++;
                        break;
                    case 5:
                        jegy5++;
                        all = all + 5;
                        allCounter++;
                        break;
                }
                Console.Write("Adj meg egy érdemjegyet: ");
                num5 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Avarage: {all / allCounter}");
            Console.WriteLine($"1: {jegy1}");
            Console.WriteLine($"2: {jegy2}");
            Console.WriteLine($"3: {jegy3}");
            Console.WriteLine($"4: {jegy4}");
            Console.WriteLine($"5: {jegy5}");
            
            //Feladat6
            Console.Write("Melyik szám: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a <= 10; a++)
            {
                if (num6*a% 3 == 0)
                {
                    Console.WriteLine($"{num6 * a}");
                }
            }
            */
            //Feladat7
            for (int a = 0; a <= 10; a++)
            {
                Console.Write("Adj meg egy számot: ");
                int num7 = Convert.ToInt32(Console.ReadLine());
                if (num7>0)
                {
                    Console.Write($"pozitív ");
                }
                else if (num7 == 0)
                {
                    Console.Write($"nulla ");
                }
                else
                {
                    Console.Write($"negatív ");

                }
                if (num7 % 2 == 0)
                {
                    Console.Write($"páros ");
                }
                else
                {
                    Console.Write($"páratlan ");
                }
                if (num7 % 3 == 0)
                {
                    Console.WriteLine($"osztható 3-mal ");
                }
                else
                {
                    Console.WriteLine($"nem osztható 3-mal ");
                }
            }
        }
    }
}