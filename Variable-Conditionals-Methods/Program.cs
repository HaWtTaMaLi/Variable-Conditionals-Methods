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
        static int lvlUpNumber;
        static int expReqToLevelUp;
        static int expInc;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //initialize
            lvlUpNumber = 1;
            level = lvlUpNumber;
            exp = 0;
            expInc = 25; //never changes
            expReqToLevelUp = expInc; // changes ever level up

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
            exp = xp + exp;
            Console.WriteLine("\nYou gained " + xp +" XP");
        }

        static void LevelUpCheck()
        {
            if (exp >= expReqToLevelUp)
            {
                level = level + lvlUpNumber;
                exp = exp - expReqToLevelUp;
                
                // increase XP requirement to level up
                expReqToLevelUp = expReqToLevelUp + expInc; // hardcoded (uh-oh!) to 25
            } 
        }

        static void HUD()
        {
            Console.WriteLine("\nHUD Display");
            Console.WriteLine("Level: " + level);
            Console.WriteLine("XP: " + exp + "/" + expReqToLevelUp);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
