﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string FirstNameRequest()
        {
            Console.WriteLine("Please provide your First Name");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string LastNameRequest()
        {
            Console.WriteLine("Please provide your Last Name");
            string userLastName = Console.ReadLine();
            return userLastName;
        }
        public static string EmailRequest()
        {
            Console.WriteLine("Please provide your Email address");
            string userEmail = Console.ReadLine();
            return userEmail;
        }
        public static int RegistrationNumber()
        {
            Console.WriteLine("Please enter the previously provided Registration Number ");
            int registrationNumber = Int32.Parse(Console.ReadLine());
            return registrationNumber;
        }

        public static void DisplayContestantInformation(Contestant contestant)
        {
            Console.WriteLine("Contestant Information");
            Console.WriteLine("**********************");
            Console.WriteLine($"Contestant Information: {UserInterface.FirstNameRequest()}");
            Console.WriteLine($"First Name: {contestant.LastName}");
            Console.WriteLine($"First Name: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
        }

        public static string NameTheSweepstakes()
        {
            Console.WriteLine("Please enter the name you have chosen for the Sweepstakes, I recommend Kitties but you can pick what you want." );
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string ChooseSweepstakesManager() 
        {
            Console.WriteLine("Who is going to be the Sweepstakes Manager,\n I recommend Garfield but he doesn't work here. \n Otherwise pick 1 or 2");
            string userInput = Console.ReadLine();
            return userInput;
            
        }
        


    }
}
