using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        // member variables (has a)
        public string Firstname;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;
        //constructor (spawner)
        public Contestant()
        {
            Firstname = UserInterface.FirstNameRequest();
            LastName = UserInterface.LastNameRequest();
            EmailAddress = UserInterface.EmailRequest();

        }
        // member methods (can do)
        

    }
}
