using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class weather
    {
        //member variables (has a….also defined as attributes of the class)
        
        //private string WeatherForDay;
        //private string ForecastWeatherForDay;
        //private string ForecastWeatherForWeek;
        string condition;
        int todaysTemp;
        private int lowerTempRange = 60;
        private int UpperTempRange = 90;
        private List<string> WeatherType1;

        //constructor (build this thing)(constructor initializes our variables)ge
        public weather()
        {
            WeatherType1 = new List<string>() { "sunny", "rainy", "cloudy" };
            //WeatherType();
            //SetTemp();




        }

        //member methods
      
        public void GetWeatherType()
        {
            Random rng = new Random();
            condition = WeatherType1[rng.Next(0, 3)];
        }
        public void SetTemp()
        {
            Random rng = new Random();
            todaysTemp = rng.Next(lowerTempRange, UpperTempRange);
        }

     

        public void GetDaysWeather()
        {
            GetWeatherType();
            SetTemp();
            Console.WriteLine("The weather will be " + condition + " The temperature will be " + todaysTemp);

        }

        public void DisplayForecastWeatherWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                GetDaysWeather();
            }
        }


        //public void DisplayWeatherForDay()
        //{
        //    Random rng = new Random();
        //    Console.WriteLine(DisplayDay ":The weather is" + condition + "The temperature is" + todaysTemp);
        //}





        //need to write a list containing the three choices for weather
        //and a random generator to output the weather forecast and then the actual weather for each day. 



    }
}