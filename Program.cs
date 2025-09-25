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
            
            //Feladat8
            bool run = true;
            while (run)
            {
                Console.Write("Adj meg egy jelszót: ");
                string password = Console.ReadLine();
                Console.Write("Add meg a jelszót mégegszer: ");
                string password2 = Console.ReadLine();
                if (password == password2)
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Ugyanazt a jelszót add meg: ");
                }
            }
            Console.Write("Adj meg egy szöveget: ");
            string szoveg = "";
            szoveg = Console.ReadLine();
            for (int a = szoveg.Length-1; a != 0;a--)
            {
                Console.Write($"{szoveg[a]}");
            }
            
            //Feladat9
            Console.Write("Adj meg egy számot: ");
            int primCounter = 0;
            int num8 = Convert.ToInt32(Console.ReadLine());
            for (int a = 2; a < num8; a++)
            {
                bool prim = true;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    primCounter++;
                    //Console.WriteLine($"{a}");
                }
            }
            Console.WriteLine($"{primCounter}");
            */
            //Feladat10
            Random randomGenerator = new Random();
            int pcWins = 0;
            int playerWins = 0;
            int dontetlen = 0;
            for (int a = 0; a < 5; a++)
            {
                int randomNumber = randomGenerator.Next(1, 3);
                Console.Write("1 kő, 2 papír, 3 olló, írj be egy számot: ");
                int num9 = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == num9)
                {
                    dontetlen++;
                }
                else if (num9 == 1 && randomNumber == 3 || num9 == 2 && randomNumber == 1 || num9 == 3 && randomNumber == 2)
                {
                    playerWins++;
                }
                else
                {
                    pcWins++;
                }
                Console.WriteLine($"{pcWins}, {playerWins}, {dontetlen}");
            }
        }
    }
}