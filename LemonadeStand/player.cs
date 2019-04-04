using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class player
    {
        //member variables (has a….also defined as attributes of the class)
        private int DailyProfit;
        private int RunningProfit;
        private decimal CurrentMoney;
        public inventory inventory;


        //constructor (build this thing)(constructor initializes our variables)

        public player()
        {
            inventory = new inventory();
        }

       

        public void DisplayDailyProfit()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayRunningProfit()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayCurrentMoney()
        {
            
        }
    }
}