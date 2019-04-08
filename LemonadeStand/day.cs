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
                List<string> Days = new List<string>() { "Monday: ", "Tuesday: ", "Wednesday: ", "Thursday: ", "Friday: ", "Saturday: ", "Sunday: " };

               // DateTime now = DateTime.Today;
                for (int i = 0; i < 7; i++)
                {
                    string result = weather.GetDaysWeather();
                    Console.WriteLine(Days[i] + result);
                    //call next function
                    //call next function
                }
                
                
            

            
           

               
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