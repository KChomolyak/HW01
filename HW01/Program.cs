using System;

namespace DZ01
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.Write("Виберiть номер завдання (1-5):");
                int nomZ = Convert.ToInt32(Console.ReadKey().Key) - 0x30;
                Console.WriteLine();
                switch (nomZ)
                {
                    case 1:
                        {
                            Console.Write("Вводьте символи:");
                            string readKey;
                            int counter = 0;
                            do
                            {
                                readKey = Console.ReadKey().Key.ToString();
                                if (readKey == "Spacebar") counter++;
                            } while (readKey != "OemPeriod");
                            Console.WriteLine("\nКiлькiсть введених пробiлiв: " + counter.ToString());
                            break;
                        }
                    case 2:
                        {
                            string resultString1 = "", resultString2 = "", readKey;
                            int firstHalf = 0, secondHalf = 0;
                            Console.Write("Введiть номер квитка: ");
                            for (int i = 0; i < 6; i++)
                            {
                                readKey = Console.ReadKey().Key.ToString();
                                if (i < 3)
                                {
                                    if (i != 2)
                                        resultString1 += readKey[1] + " + ";
                                    else
                                        resultString1 += readKey[1];
                                    firstHalf += Convert.ToInt32(readKey[1]);
                                }
                                else
                                {
                                    if (i != 5)
                                        resultString2 += readKey[1] + " + ";
                                    else
                                        resultString2 += readKey[1];
                                    secondHalf += Convert.ToInt32(readKey[1]);
                                }
                            }
                            if (firstHalf == secondHalf)
                            {
                                Console.WriteLine("\n" + resultString1 + " == " + resultString2 + " => Квиток щасливий");
                            }
                            else
                            {
                                Console.WriteLine("\n" + resultString1 + " != " + resultString2 + " => Квиток не є щасливим");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вводьте символи:");
                            ConsoleKeyInfo symbol;
                            while (true)
                            {
                                symbol = Console.ReadKey();
                                if (symbol.KeyChar >= 'a' && symbol.KeyChar <= 'z')
                                {
                                    Console.WriteLine("  " + Convert.ToChar(symbol.KeyChar - 32));
                                }
                                else if (symbol.KeyChar >= 'A' && symbol.KeyChar <= 'Z')
                                {
                                    Console.WriteLine("  " + Convert.ToChar(symbol.KeyChar + 32));
                                }
                                else
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Введiть A: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введiть B: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (a < b)
                            {
                                for (int i = a; i < b + 1; i++)
                                {
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write(i + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Введiть число: ");
                            int rezNum = 0;
                            int num = Convert.ToInt32(Console.ReadLine());
                            while (num > 0)
                            {
                                rezNum = rezNum * 10 + num - num / 10 * 10;
                                num /= 10;
                            }
                            Console.WriteLine(rezNum);
                            break;
                        }
                }
                Console.Write("Повторити (Y/N)? ");

            } while (Console.ReadKey().Key.ToString() == "Y");
        }
    }
}
