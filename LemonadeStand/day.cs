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

        //constructor (build this thing)(constructor initializes our variables)
        public day()
        {
            weather = new weather();
        }



        public void DisplayDay()
        {
            throw new System.NotImplementedException();
            DayOfWeek[] days =
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday,

            };
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