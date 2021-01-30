using System;
using System.Drawing;
using System.Threading;

namespace Test_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            string[] questions = new string[10];
            questions[0] = "Which is the first programming language?";/*Fortran*/
            questions[1] = "Who was first programmer?";/*Ada Lovelace*/
            questions[2] = "When first Azerbaijan Democratic Republic was established?";/*1918*/
            questions[3] = "Who is 2Pac?";/*Rapper*/
            questions[4] = "Which is the videocard?";/**/
            questions[5] = "Which is the programming language?";/**/
            questions[6] = "Which is the biggest district of Azerbaijan?";/*Kelbecer*/
            questions[7] = "When was the first windows operating system launched?";/*1985*/
            questions[8] = "When was the first iPhone invented?";/*2007*/
            questions[9] = "When was the Grand Theft Auto San Andreas released?";/*2004*/

            string[] Fortran = new string[4] { "a)FORTRAN", "b)C#", "c)C++", "d)C" };
            string[] Lovelace = new string[4] { "A)Bill Gates", "B)Abraam Lincoln", "C)Ada Lovelace", "D)Aygun Kazimova" };
            string[] _1918 = new string[4] { "A)1918", "B)1990", "C)1991", "D)1989" };
            string[] Rapper = new string[4] { "A)BeatMaker", "B)Rapper", "C)Pianist", "D)Kebabchi" };
            string[] RTX = new string[4] { "A)Asus ROG", "B)iPhone 7", "C)RTX 3090", "D)Lenovo Ideatab" };
            string[] programmingLang = new string[4] { "a)C++", "b)Abubu", "c)JEEP", "d)Windows" };
            string[] Kalbacar = new string[4] { "A)Kalbacar", "B)Baki", "C)Lankaran", "D)Ganja" };
            string[] windowsLaunched = new string[4] { "A)1958", "B)1985", "C)1980", "D)2077" };
            string[] iphone2007 = new string[4] { "A)2005", "B)2004", "C)2006", "D)2007" };
            string[] GtaSa = new string[4] { "A)2003", "B)2005", "C)2004", "D)2002" };
            void PrintAnswers(int number)
            {
                if (number == 0)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{Fortran[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Fortran[0]);
                        points += 10;
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Fortran[1]);
                        if(points == 0)
                        {
                            points = 0;
                        }
                        if(points > 0)
                        {
                         points = points - 10;
                        }
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Fortran[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Fortran[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
                if (number == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{Lovelace[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Lovelace[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Lovelace[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Lovelace[2]);
                        points += 10;

                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Lovelace[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
                if (number == 2)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{_1918[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(_1918[0]);
                        points += 10;
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(_1918[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(_1918[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(_1918[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                }
                if (number == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{Rapper[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Rapper[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Rapper[1]);
                        points += 10;
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Rapper[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Rapper[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                }
                if (number == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{RTX[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(RTX[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(RTX[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(RTX[2]);
                        points += 10;
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(RTX[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }

                    }
                }
                if (number == 5)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{programmingLang[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(programmingLang[0]);
                        points += 10;
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(programmingLang[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(programmingLang[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(programmingLang[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
                if (number == 6)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{Kalbacar[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Kalbacar[0]);
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Kalbacar[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Kalbacar[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Kalbacar[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
                if (number == 7)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{windowsLaunched[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(windowsLaunched[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(windowsLaunched[1]);
                        points += 10;
                        
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(windowsLaunched[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(windowsLaunched[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
                if (number == 8)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{iphone2007[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(iphone2007[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(iphone2007[1]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(iphone2007[2]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(iphone2007[3]);
                        points += 10;
                    }
                }
                if (number == 9)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{GtaSa[i]}\t");
                    }
                    Console.WriteLine("\n");
                    Console.Write($"Your answer:");
                    string choicedAnswer = Console.ReadLine();
                    if (choicedAnswer == "A" || choicedAnswer == "a")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(GtaSa[0]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                    if (choicedAnswer == "B" || choicedAnswer == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(GtaSa[1]);
                    }
                    if (choicedAnswer == "C" || choicedAnswer == "c")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(GtaSa[2]);
                        points += 10;
                    }
                    if (choicedAnswer == "D" || choicedAnswer == "d")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(GtaSa[3]);
                        if (points == 0)
                        {
                            points = 0;
                        }
                        if (points > 0)
                        {
                            points = points - 10;
                        }
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
             Console.ResetColor();
            Console.WriteLine(questions[i]);
            PrintAnswers(i);
            Thread.Sleep(3000);
            }
            Console.WriteLine($"Your Points:{points}");
            Console.ReadLine();
        }
    }
}
