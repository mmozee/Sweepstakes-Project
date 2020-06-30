using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name 
        { get {return name;}
            set { name = value;}
        }
        

        public Sweepstakes(string name)
        {
            this.Name = name;
            contestants = new Dictionary<int, Contestant>();
        }      
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count + 1;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestantInformation(contestant);
        }
        public string WinnerPicker()
        {
            Random RNG = new Random();

            int myRandom = RNG.Next(1, contestants.Count+1);
            Contestant winnerContestant;
            winnerContestant = contestants[myRandom];
            string winner = $"Winner is {winnerContestant.FirstName} {winnerContestant.LastName} {winnerContestant.RegistrationNumber}"; 
            return winner;

        }
       







    }
}
