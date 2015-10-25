using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1-14 to get the assigned card");
            int Card = int.Parse(Console.ReadLine());

            switch (Card)
            {
                case 1:
                    Console.WriteLine("2");
                    
                    if (Card==1) ; {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 2:
                    Console.WriteLine("3");
                    if (Card == 2) ;
                    {
                        Console.WriteLine("Your card is VALID"); }
                        break;

                case 3:
                    Console.WriteLine("4");
                    if (Card == 3) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 4:
                    Console.WriteLine("5");
                    if (Card == 4) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 5:
                    Console.WriteLine("6");
                    if (Card == 5) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 6:
                    Console.WriteLine("7");
                    if (Card == 6) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 7:
                    Console.WriteLine("8");
                    if (Card == 7) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 8:
                    Console.WriteLine("9");
                    if (Card == 8) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 9:
                    Console.WriteLine("10");
                    if (Card == 9) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 10:
                    Console.WriteLine("J");
                    if (Card == 10) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 11:
                    Console.WriteLine("Q");
                    if (Card == 11) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 12:
                    Console.WriteLine("K");
                    if (Card == 12) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                case 13:
                    Console.WriteLine("A");
                    if (Card == 13) ;
                    {
                        Console.WriteLine("Your card is VALID");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid CARD");
                    break;

            }
            }
        }
    }
