using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        // member variables (has a)
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;}
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private int registrationNumber;
        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        //constructor (spawner)
        public Contestant()
        {
            FirstName = UserInterface.FirstNameRequest();
            LastName = UserInterface.LastNameRequest();
            EmailAddress = UserInterface.EmailRequest();

        }
        // member methods (can do)
        

    }
}
