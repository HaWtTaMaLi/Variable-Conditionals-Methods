using System;

namespace Variable_Conditionals_Methods
{
    //player XP
    //player LV
    //+25
    //xp spent to lvl up
    //HUD

    internal class Program
    {
        static int exp;
        static int level;

        static void Main()
        {
            //initialize
            exp = 0;
            level = 1;

            HUD();

            Experience();

            Console.ReadKey();

            HUD();
            
        }

        static void Experience()
        {
            int xp;
            xp = 25;
            exp = xp + exp;
        }

        static void Level()
        {
            //if exp == 25, level 2
            //if exp == 50, level 3
            //if exp == 
        }

        static void HUD()
        {
            Console.WriteLine("HUD Display");
            Console.WriteLine("Level: " + level);
            Console.WriteLine("XP: " + exp);
        }
    }
}
