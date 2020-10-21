using System;

namespace Fight_MAN
{
    class health{
        public int hp;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int mainPoint = 0;
            int levelSet = 0;
            int[] bosses = { 1, 1, 1 };
            int[] statPlayer = {10,3,1,5};
            Console.WriteLine("Hello adventure!");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Ah wellcome " + name + "!");
            while (option == 0)
            {
                Console.WriteLine("What would you like to do first?");
                Options();
                string choise = Console.ReadLine();
                if (choise == "1" || choise == "fight" || choise == "Fight")
                {
                    mainPoint = 1;
                    option = 1;
                }
                else
                {
                    Console.WriteLine("Try that agian");
                }
            }
            option = 0;
            switch (mainPoint)
            {
                case 1:
                    Console.WriteLine("So you what to fight? Lets see if you can kill the three evil beasts!");
                    //Level set 1 is for the first enemy (2 and 3 is for other bosses)
                    if (bosses[0] == 1)
                    {
                        levelSet = 1;
                    }
                    else if (bosses[1] == 1)
                    {
                        levelSet = 2;
                    }
                    else if (bosses[2] == 1)
                    {
                        levelSet = 3;
                    }
                    break;
                default:
                    Console.WriteLine("No?");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            int levelLock = levelSet;
            while (levelLock == levelSet)
            {
                if (levelLock == 1)
                {
                    Console.WriteLine("In the dark deeps of the water...");
                    Console.WriteLine("He lives...");
                    Console.WriteLine("The Merman []!");
                    Kill();
                }
            }

            Console.ReadLine();


        }
        static void Options()
        {
            Console.WriteLine("1.Fight");
        }
        static void Kill()
        {
            health h = new health();
            health eh = new health();

            while (eh.hp > 0 || h.hp > 0)
            {

            }
        }
    }
}
