using System;
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
            string userFirstName = Console.ReadLine();
            return userFirstName;
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



    }
}
