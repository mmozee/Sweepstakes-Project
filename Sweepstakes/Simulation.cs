using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation 
    {
       
        public void RunSweepstakes()
        {
        // // first we have promp to user which one : Stack or Queue
        // CreateMarketingFirm();
        //// create sweepstakes
        // MarketingFirm marketingFirm = new MarketingFirm(CreateChooseSweepstakesManager());
        // marketingFirm.CreateSweepstakes();
        //    // create contestants
        //    Sweepstakes.RegisterContestant();
        //// select the winner

        }

        public void CreateMarketingFirm()
        {
            
            MarketingFirm marketing = new MarketingFirm(CreateChooseSweepstakesManager());
        }

        public ISweepstakesManager CreateChooseSweepstakesManager()
        {
            string userInput = UserInterface.ChooseSweepstakesManager();
            switch (userInput)
            {
                case "1":
                    return new SweepstakesQueueManager();
                case "2":
                    return new SweepstakesStackManager();

                default:
                    return null;

            }
        }
    }
}
