using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
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
            int registrationNumb = contestant.RegistrationNumber + 1;
            contestants.Add(registrationNumb, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
        public string WinnerPicker()
        {
            Random RNG = new Random();

            int myRandom = RNG.Next(0, contestants.Count);
            Contestant winnerContestant;
            winnerContestant = contestants[myRandom];
            string winner = $"Winner is {winnerContestant.Firstname} {winnerContestant.LastName} {winnerContestant.RegistrationNumber}"; 
            return winner;

        }
        public string WinnerPicker()
        {
            Random RNG = new Random();

            int myRandom = RNG.Next(0, contestants.Count);
            Contestant winnerContestant;
            winnerContestant = contestants[myRandom];
            string winner = $"Winner is {winnerContestant.Firstname} {winnerContestant.LastName} {winnerContestant.RegistrationNumber}";
            return winner;








        }
}
