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
        static int level;
        static int lvlUpNumber;
        static int exp;
        static int expInc;
        static int expReqToLevelUp;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //initialize
            lvlUpNumber = 1;
            level = lvlUpNumber;
            exp = 0; //what the player sees
            expInc = 25; //never changes
            expReqToLevelUp = expInc; // changes every level up

            HUD();
            AddExp(15);
            LevelUpCheck();

            HUD();
            AddExp(15);
            LevelUpCheck();

            HUD();
            AddExp(25);
            LevelUpCheck();

            HUD();
            AddExp(25);
            LevelUpCheck();

            HUD();
            AddExp(25);
            LevelUpCheck();

            HUD();
            AddExp(50);
            LevelUpCheck();

            HUD();
        }

        static void AddExp(int xp)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            exp = xp + exp;
            Console.WriteLine("\nYou gained " + xp +" XP");

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void LevelUpCheck()
        {
            if (exp >= expReqToLevelUp)
            {
                level = level + lvlUpNumber;
                exp = exp - expReqToLevelUp;
                
                // increase XP requirement to level up
                expReqToLevelUp = expReqToLevelUp + expInc; 
            } 
        }

        static void HUD()
        {
            Console.WriteLine("\nHUD Display");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Level: " + level);
            Console.WriteLine("XP: " + exp + "/" + expReqToLevelUp);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
