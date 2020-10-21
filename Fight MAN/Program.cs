using System;

namespace Fight_MAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int option = 0;
            int mainPoint = 0;
            int levelSet = 0;
            int game = 1;
            int[] bosses = { 1, 1, 1 };
            int[] statPlayer = { 10, 3, 1, 5, 1 };
            int[] statEnemy = new int[5];
            Console.WriteLine("Hello adventure!");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Ah wellcome " + name + "!");
            while (game == 1)
            {
                while (option == 0)
                {
                    Console.WriteLine("What would you like to do?");
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
                        statEnemy[0] = 5;
                        statEnemy[1] = 4;
                        statEnemy[2] = 0;
                        statEnemy[3] = 2;
                        statEnemy[4] = 2;
                        Kill(statPlayer[0], statPlayer[1], statPlayer[2], statPlayer[3], statPlayer[4], statEnemy[0], statEnemy[1], statEnemy[2], statEnemy[3], statEnemy[4], 5, 6, 8, 10);
                        levelSet = 0;
                        bosses[0] = 0;
                        Console.Clear();
                    }
                    else if (levelLock == 2)
                    {
                        Console.WriteLine("In the dark deeps of the water...");
                        Console.WriteLine("He lives...");
                        Console.WriteLine("The Merman2 []!");
                        statEnemy[0] = 13;
                        statEnemy[1] = 6;
                        statEnemy[2] = 2;
                        statEnemy[3] = 5;
                        statEnemy[4] = 1;
                        Kill(statPlayer[0], statPlayer[1], statPlayer[2], statPlayer[3], statPlayer[4], statEnemy[0], statEnemy[1], statEnemy[2], statEnemy[3], statEnemy[4], 5, 6, 8, 10);
                        levelSet = 0;
                        bosses[1] = 0;
                        Console.Clear();
                    }

                }
            }

            Console.ReadLine();


        }
        static void Options()
        {
            Console.WriteLine("1.Fight");
        }
        static void Died()
        {
            Console.WriteLine("You have Died");
            Console.WriteLine("GAME OVER");
        }
        static void Kill(int pH, int pA, int pD, int pS, int pM, int eH, int eA, int eD, int eS, int eM, int eTA, int eTSA, int eTM, int eTD)
        {
            Random generator = new Random();
            int[] statPlayer = { pH, pA, pD, pS, pM };
            int[] statEnemy = { eH, eA, eD, eS, eM };
            String[] area = { "P", "_", "_", "_", "_", "_", "E" };
            int PLoc = 0;
            int ELoc = 6;
            int hB;
            int Fight = 1;

            while (Fight == 1)
            {
                Console.WriteLine("");
                int done = 0;
                Console.WriteLine("Health left: " + statPlayer[0]);
                int attackRan = generator.Next(4);
                int hitRan = generator.Next(100);
                int eDidNot = 1;
                Console.WriteLine("");
                Console.WriteLine(area[0] + "" + area[1] + "" + area[2] + "" + area[3] + "" + area[4] + "" + area[5] + "" + area[6]);
                Console.WriteLine("");
                Console.WriteLine("What shall you do?");
                Console.WriteLine("");
                Console.WriteLine("Attack");
                Console.WriteLine("Move Forward");
                Console.WriteLine("Move Back");
                string choise = Console.ReadLine();
                Console.Clear();
                if (choise == "Attack")
                {
                    Console.WriteLine("You Attack.");
                    if (PLoc == ELoc + 1 || PLoc == ELoc - 1)
                    {
                        if (hitRan > 32)
                        {
                            Console.WriteLine("You Hit!");
                            hB = statEnemy[0];
                            statEnemy[0] = statEnemy[0] - ((statPlayer[1] + (attackRan - 2)) - statEnemy[2]);
                            Console.WriteLine("The Enemy took " + (hB - statEnemy[0]) + " amount of damage!");
                        }
                        else
                        {
                            Console.WriteLine("You Miss...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You Miss...");
                    }
                }
                else if (choise == "Move Forward")
                {
                    Console.WriteLine("You have moved forward.");
                    if (PLoc + statPlayer[4] == ELoc)
                    {
                        area[PLoc] = "_";
                        PLoc = ELoc - 1;
                        area[PLoc] = "P";
                    }
                    else if (PLoc > 0 - statPlayer[4])
                    {
                        area[PLoc] = "_";
                        PLoc = PLoc + statPlayer[4];
                        area[PLoc] = "P";
                    }
                    else
                    {
                        area[PLoc] = "_";
                        area[6] = "P";
                        PLoc = 6;

                    }
                }
                else if (choise == "Move Back")
                {
                    Console.WriteLine("You have moved back.");
                    if (PLoc - statPlayer[4] == ELoc)
                    {
                        area[PLoc] = "_";
                        PLoc = ELoc + 1;
                        area[PLoc] = "P";
                    }
                    else if (PLoc > 0 + statPlayer[4])
                    {
                        area[PLoc] = "_";
                        PLoc = PLoc - statPlayer[4];
                        area[PLoc] = "P";
                    }
                    else
                    {
                        area[PLoc] = "_";
                        area[0] = "P";
                        PLoc = 0;
                    }
                }
                if (statEnemy[0] < 0)
                {
                    Console.WriteLine("The enemy died");
                    Fight = 0;
                    done = 1;
                    Console.ReadLine();
                }
                else if (statPlayer[0] < 0)
                {
                    Died();
                    Fight = 0;
                }
                attackRan = generator.Next(4);
                hitRan = generator.Next(100);
                while (eDidNot == 1)
                {
                    int eRan = generator.Next(9);
                    if (eRan + 1 < eTA || eRan + 1 == eTA)
                    {
                        if (ELoc == PLoc + 1 || ELoc == PLoc - 1)
                        {
                            if (ELoc == PLoc + 1 || ELoc == PLoc - 1)
                            {
                                Console.WriteLine("The Enemy Attacked.");
                                if (hitRan > 32)
                                {
                                    Console.WriteLine("The Enemy Hit!");
                                    hB = statPlayer[0];
                                    statPlayer[0] = statPlayer[0] - ((statEnemy[1] + (attackRan - 2)) - statPlayer[2]);
                                    Console.WriteLine("The Enemy did " + (hB - statPlayer[0]) + " amount of damage!");
                                    eDidNot = 0;
                                }
                                else
                                {
                                    Console.WriteLine("The Enemy Missed...");
                                    eDidNot = 0;
                                }
                            }
                            else
                            {
                                Console.WriteLine("The Enemy Missed...");
                                eDidNot = 0;
                            }

                        }
                    }
                    else if (eRan + 1 > eTA && eRan + 1 < eTM)
                    {
                        if (ELoc == PLoc + 1 || ELoc == PLoc - 1)
                        {
                            if (ELoc == PLoc + 1 || ELoc == PLoc - 1)
                            {
                                Console.WriteLine("The Enemy Attacked.");
                                if (hitRan > 32)
                                {
                                    Console.WriteLine("Th Enemy Hit!");
                                    hB = statPlayer[0];
                                    statPlayer[0] = statPlayer[0] - ((statEnemy[1] + (attackRan - 2)) - statPlayer[2]);
                                    Console.WriteLine("The Enemy did " + (hB - statPlayer[0]) + " amount of damage!");
                                    eDidNot = 0;
                                }
                                else
                                {
                                    Console.WriteLine("The Enemy Missed...");
                                    eDidNot = 0;
                                }
                            }
                            else
                            {
                                Console.WriteLine("The Enemy Missed...");
                                eDidNot = 0;
                            }

                        }
                        else if (eRan + 1 > eTSA && eRan + 1 < eTD)
                        {
                            Console.WriteLine("The enemy have moved forward.");
                            if (ELoc - statEnemy[4] == PLoc)
                            {
                                area[ELoc] = "_";
                                ELoc = PLoc + 1;
                                area[ELoc] = "E";
                                eDidNot = 0;
                            }
                            else if (ELoc > -1 + statEnemy[4])
                            {
                                area[ELoc] = "_";
                                ELoc = ELoc - statEnemy[4];
                                area[ELoc] = "E";
                                eDidNot = 0;
                            }
                            else
                            {
                                area[ELoc] = "_";
                                area[0] = "E";
                                ELoc = 0;
                                eDidNot = 0;
                            }
                        }
                        else if (eRan + 1 > eTM && eRan + 1 < 11)
                        {
                            Console.WriteLine("The enemy have moved back.");
                            if (ELoc + statEnemy[4] == PLoc)
                            {
                                area[ELoc] = "_";
                                ELoc = ELoc - 1;
                                area[ELoc] = "E";
                                eDidNot = 0;
                            }
                            else if (ELoc < 6 + statEnemy[4])
                            {
                                area[ELoc] = "_";
                                ELoc = ELoc + statEnemy[4];
                                area[ELoc] = "E";
                                eDidNot = 0;
                            }
                            else
                            {
                                area[ELoc] = "_";
                                area[6] = "E";
                                ELoc = 6;
                                eDidNot = 0;
                            }
                        }
                    }
                }
                if (done != 1)
                {
                    if (statEnemy[0] < 0)
                    {
                        Console.WriteLine("The enemy died");
                        Fight = 0;
                        Console.ReadLine();
                    }
                    else if (statPlayer[0] < 0)
                    {
                        Died();
                        Fight = 0;
                    }
                }

            }
        }

    }
}


