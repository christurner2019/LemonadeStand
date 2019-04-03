using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class inventory
    {
        //member variables (has a….also defined as attributes of the class)
        private int CupsOfSugarInv;
        private int LemonsInInv;
        private int IceCubesInv;
        private int DrinkCupsInInv;
        
        //constructor (build this thing)(constructor initializes our variables)

        public void DisplayInv()
        {
            throw new System.NotImplementedException();
            {
                Console.WriteLine("CupsOfSugarInv", "LemonsInInv", "IceCubesInv",
                    "DrinkCupsInInv");
            }
        }
    }
}