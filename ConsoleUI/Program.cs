﻿using System;
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
            //Methods 1-4
            string name;
            string otherGuest;
            do
            {
                name = GetUserInput("Please enter your name.");
                raffleNumber = GenerateRandomNumber(min, max);
                AddGuestsInRaffle(raffleNumber, name);
                otherGuest = GetUserInput("Do you want to add another name? ").ToLower();

            } while (otherGuest == "yes");

            //Method 5
            foreach (var numAndName in guests)
            {
                Console.WriteLine($"{numAndName.Key} : {numAndName.Value}");
            }


            //Method 6
            List<int> keyList = new List<int>(guests.Keys);
            int winnerNumber = keyList[_rdm.Next(keyList.Count)];
            //Method 7
            PrintWinner(winnerNumber);
            


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
        //static KeyValuePair<int, string> GetUserInfo(string guest)
        //{
        //    string name; 
        //    string otherGuest;
        //    do
        //    {
        //        name = GetUserInput("Please enter your name.");
        //        raffleNumber = GenerateRandomNumber(min, max);
        //        AddGuestsInRaffle(raffleNumber, name);

        //        otherGuest = GetUserInput("Do you want to add another name? ").ToLower();


        //    } while (otherGuest == "yes");

        //}
        //Method 3
        private static int GenerateRandomNumber(int min, int max)
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
        //private static void PrintGuestsName(Dictionary<int, string>)
        //{
        ////    foreach(var numAndName in guests)
        ////    {
        ////        Console.WriteLine($"{numAndName.Key} : {numAndName.Value}");
        ////    }
        //}
        //Method 6
        //private static int GetRaffleNumber(Dictionary<int, string>)
        //{
        //    int keyNum = num.Key;
        //    return keyNum;
        //}

        //Method 7
        static void PrintWinner(int winnerNumber)
        {
            Console.WriteLine($"The Winner is: {guests[winnerNumber]} with the #{winnerNumber}!");
        }

    }





       //static void MultiLineAnimation() // Credit: https://www.michalbialecki.com/2018/05/25/how-to-make-you-console-app-look-cool/
       // {
       //     var counter = 0;
       //     for (int i = 0; i < 30; i++)
       //     {
       //         Console.Clear();

       //         switch (counter % 4)
       //         {
       //             case 0:
       //                 {
       //                     Console.WriteLine("         ╔════╤╤╤╤════╗");
       //                     Console.WriteLine("         ║    │││ \\   ║");
       //                     Console.WriteLine("         ║    │││  O  ║");
       //                     Console.WriteLine("         ║    OOO     ║");
       //                     break;
       //                 };
       //             case 1:
       //                 {
       //                     Console.WriteLine("         ╔════╤╤╤╤════╗");
       //                     Console.WriteLine("         ║    ││││    ║");
       //                     Console.WriteLine("         ║    ││││    ║");
       //                     Console.WriteLine("         ║    OOOO    ║");
       //                     break;
       //                 };
       //             case 2:
       //                 {
       //                     Console.WriteLine("         ╔════╤╤╤╤════╗");
       //                     Console.WriteLine("         ║   / │││    ║");
       //                     Console.WriteLine("         ║  O  │││    ║");
       //                     Console.WriteLine("         ║     OOO    ║");
       //                     break;
       //                 };
       //             case 3:
       //                 {
       //                     Console.WriteLine("         ╔════╤╤╤╤════╗");
       //                     Console.WriteLine("         ║    ││││    ║");
       //                     Console.WriteLine("         ║    ││││    ║");
       //                     Console.WriteLine("         ║    OOOO    ║");
       //                     break;
       //                 };
       //         }

       //         counter++;
       //         Thread.Sleep(200);
       //     }
        //}
  }

