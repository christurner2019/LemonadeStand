using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //member variables
        public List<day> Days;
        public player Player;
        public customer Customer;
        public store Store;
        public day Day;



        //constructor

        public Game()
        {





        }





        //methods
        public void RunGame()
        {
            Console.WriteLine($"Welcome to the Lemondade Stand Game. Your goal is to make as much profit as possible. You will do this by " +
                            "making smart choices with your inventory and tweaking your recipe so it is popular with your customers. You will need to " +
                            "monitor the weather as well and base your inventory on the current weather. You will purchase inventory before every new work day " +
                            "can start. Pay attention to what works and adjust accordingly. Go make some money!!");
            BuildDays();
            //DisplayForecastWeatherWeek();
            Console.ReadLine();






        }



        public void BuildDays()
        {
            Days = new List<day>();
            for (int i = 0; i <= 7; i++)
            {
                day day = new day();
                switch (i)
                {
                    case 1:
                        day.DayOfWeek = "Monday";
                        break;
                    case 2:
                        day.DayOfWeek = "Tuesday";
                        break;
                    case 3:
                        day.DayOfWeek = "Wednesday";
                        break;
                    case 4:
                        day.DayOfWeek = "Thursday";
                        break;
                    case 5:
                        day.DayOfWeek = "Friday";
                        break;
                    case 6:
                        day.DayOfWeek = "Saturday";
                        break;
                    case 7:
                        day.DayOfWeek = "Sunday";
                        break;

                    default:
                        break;
                }
                Days.Add(day);
                Days[i].RunDay();
                Console.WriteLine("Today is: " + day.DayOfWeek);
                Console.ReadLine();

                //for (int i = 0; i < Days.Count; i++)
                //{
                //    Console.WriteLine(Days[i].DayOfWeek + " " + Days[i].weather.Temperature);
                //}
            }
        }

    }
}



//layout the different methods to make each function work
//    Display welcome message, rules and let user know game will take place over a 7 day period and user will have to buy inventory based
//    on different factors, including weather.
//    user will purchase inventory before every work period
//    game will begin running through a complete work day keeping track of and displaying sales and profit
//    customers will purchase based on variables including weather and taste of recipe
//    game will move to next day where inventory will have to be purchased again
//    game will continue like this running through 7 days. 
//    end of 7 days, total profit will be displayed

