using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //has a
        public int LemonAmount = 6;
        public int SugarAmount = 4;
        public int IceCubes = 3;



        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("Currently the recipe consists of " + LemonAmount + " lemons, " 
                + SugarAmount + " cups of sugar, and " + IceCubes + " ice cubes.");
        }

        public void ChangeRecipe()
        {
            Console.WriteLine("Do you want to change the recipe? YES or NO.");
            string RecipeAnswer = Console.ReadLine();
            string choice = RecipeAnswer.ToUpper();


            if (RecipeAnswer == "yes")
            {
                Console.WriteLine("How many lemons do you want to use?");
                LemonAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many cups of sugar do you want to use?");
                SugarAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much ice do you want to use?");
                IceCubes = Convert.ToInt32(Console.ReadLine());
            }

        }
    }

}
