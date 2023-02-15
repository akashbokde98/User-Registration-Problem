﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public static class Pattern
    {
        public static string checkFirstName = "^[A-Z][a-z]{3,}$";
        public static string checkLastName = "^[A-Z][a-z]{3,}$";
        public static string checkEmailId = "^[a-z{3,}]+[@+-.0-9a-z{3,}]+$";
        public static string checkphoneNumber = "^91[ ][0-9]+$";
        public static string checkPassword_1 = "^[A-Za-z]{8,}$";
        public static string checkPassword_2 = "^((?=.*)(?=.*[A-Z])(?=.*).{8,})$";
        public static string checkPassword_3 = "^((?=.*\\d)(?=.*[A-Z])(?=.*[a-z]).{8,})$";
        public static string checkPassword_4 = "^((?=.*\\d)(?=.*\\W)(?=.*[A-Z])(?=.*[a-z]).{8,})$";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex rg1 = new Regex(Pattern.checkFirstName);
            Console.WriteLine("Enter User First Name-");
            Console.WriteLine(rg1.IsMatch(Console.ReadLine()));

            Regex rg2 = new Regex(Pattern.checkLastName);
            Console.WriteLine("Enter User Last Name-");
            Console.WriteLine(rg2.IsMatch(Console.ReadLine()));

            Regex rg3 = new Regex(Pattern.checkEmailId);
            Console.WriteLine("Enter User E-mail Id-");
            Console.WriteLine(rg3.IsMatch(Console.ReadLine()));

            Regex rg4 = new Regex(Pattern.checkphoneNumber);
            Console.WriteLine("Enter User Phone Number-");
            Console.WriteLine(rg4.IsMatch(Console.ReadLine()));

            Regex rg5 = new Regex(Pattern.checkPassword_1);
            Console.WriteLine("Enter User Password With Min 8 Character-");
            Console.WriteLine(rg5.IsMatch(Console.ReadLine()));

            Regex rg6 = new Regex(Pattern.checkPassword_2);
            Console.WriteLine("Enter User Password-2 -");
            Console.WriteLine(rg6.IsMatch(Console.ReadLine()));

            Regex rg7 = new Regex(Pattern.checkPassword_3);
            Console.WriteLine("Enter User Password-3 -");
            Console.WriteLine(rg7.IsMatch(Console.ReadLine()));

            Regex rg8 = new Regex(Pattern.checkPassword_4);
            Console.WriteLine("Enter User Password-4 -");
            Console.WriteLine(rg8.IsMatch(Console.ReadLine()));
        }
    }
}
