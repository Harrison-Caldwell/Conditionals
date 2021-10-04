using System;

namespace Conditionals
{
    class Program
    {
        static int Score = 0;
        static int lives = 3;
        static bool oneUpGained = false;

        static void Main(string[] args)
        {
            if (oneUpGained == false)
            {
                if (Score > 1000000)
                {
                    lives = lives + 1;
                    oneUpGained = true;
                }
            }

        }
    }
}
