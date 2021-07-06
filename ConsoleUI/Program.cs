using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to the Party!!");
         GetUserInfo();
         PrintGuestsName(guests);
         GetRaffleNumber(guests);

         Console.ReadLine();
        }
        private static Dictionary<int, string> guests = new Dictionary<int, string>();
        private static int min = 1000;
        private static int max = 9999;
        private static int raffleNumber;
        private static Random _rdm = new Random();

        //Method 1
        private static string GetUserInput(string message)
        {
         Console.WriteLine(message);
         string input;
         input = Console.ReadLine();
         return input;
        }
        //Method 2
        static void GetUserInfo()
        {
         string name;
         string otherGuest;
            do
            {
                name = GetUserInput("Please enter your name.");
                raffleNumber = GenerateRandomNumber(min, max);
    
                while (String.IsNullOrEmpty(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    name = GetUserInput("Please enter your name.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                    while (guests.ContainsKey(raffleNumber))
                {
                    raffleNumber = GenerateRandomNumber(min, max);
                }

                AddGuestsInRaffle(raffleNumber, name);
                otherGuest = GetUserInput("Do you want to add another name? ").ToLower();

            } while (otherGuest == "yes" || otherGuest != "");

        }
        //Method 3
        static int GenerateRandomNumber(int min, int max)
            {
                raffleNumber = _rdm.Next(min, max);
                return raffleNumber;
            }

        //Method 4
        static void AddGuestsInRaffle(int raffleNumber, string guest)
            {
                guests.Add(raffleNumber, guest);
            }

        //Method 5
        static void PrintGuestsName(Dictionary<int, string> guests)
            {
                foreach (var numAndName in guests)
                {
                    Console.WriteLine($"{numAndName.Key} : {numAndName.Value}");
                }
            }

        //Method 6
        static void GetRaffleNumber(Dictionary<int, string> guests)
            {
                List<int> keyList = new List<int>(guests.Keys);
                int winnerNumber = keyList[_rdm.Next(keyList.Count)];
                PrintWinner(winnerNumber);
            }

        //Method 7
        static void PrintWinner(int winnerNumber)
            {
                Console.WriteLine($"The Winner is: {guests[winnerNumber]} with the #{winnerNumber}!");
            }

    }

  }

