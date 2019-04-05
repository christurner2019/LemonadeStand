using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class day
    {
        //member variables (has a….also defined as attributes of the class)
       
        private int DurationGame;
        private int HoursOfOper;
        public weather weather;
        public string DayOfWeek;
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

                Console.WriteLine("Today is" + Days);
                Days.ForEach(Console.WriteLine);

                for (int i = 0; i < 7; i++);

               
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