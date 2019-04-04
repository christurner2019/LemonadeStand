using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class day
    {
        //member variables (has a….also defined as attributes of the class)
        private int ShowDayOfWeek;
        private int DurationGame;
        private int HoursOfOper;
        public weather weather;
        public string Days;

        //constructor (build this thing)(constructor initializes our variables)
        public day()
        {
            weather = new weather();
        }
        
        


       

        public void DisplayDay()
        {
           
            
            {
                List<string> Days = new List<string>();
                Days.Add("Monday");
                Days.Add("Tuesday");
                Days.Add("Wednesday");
                Days.Add("Thursday");
                Days.Add("Friday");
                Days.Add("Saturday");
                Days.Add("Sunday");

            }
        }

        public void CalcDurationGame()
        {
            throw new System.NotImplementedException();

        }

        public void SellDuringHrsOper()
        {
            throw new System.NotImplementedException();
        }
        public void RunDay()
        {

        }
    }
}