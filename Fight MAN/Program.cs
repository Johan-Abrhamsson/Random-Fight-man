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
            int shopLock = 0;
            int expGrid = 2;
            int expbase = 10;
            int[] expLevel = { expbase * expGrid, 2 * expbase * expGrid, 3 * expbase * expGrid, 4 * expbase * expGrid, 5 * expbase * expGrid };
            int[] bonusLevel = { 5, 1, 1, 1, 1 };
            int expCurrent = 0;
            int monney = 0;
            int expNumb = 0;
            int ranItem = generator.Next(6);
            int[] iventory = new int[10];
            int iventoryLoc = 0;
            string[] itemName = new string[10];
            int[] costItem = new int[10];
            int[] shopNumber = new int[5];
            int[] bosses = { 1, 1, 1 };
            int[] statPlayer = { 10, 3, 1, 5, 1 };
            int[] statEnemy = new int[5];
            Console.WriteLine("Hello adventure!");
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Ah wellcome " + name + "!");
            while (game == 1)
            {
                if (expCurrent == expLevel[expNumb] || expCurrent > expLevel[expNumb])
                {
                    for (int i = 0; i > 5; i++)
                    {
                        statPlayer[i] = statPlayer[i] + bonusLevel[i];
                    }
                }
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
                    else if (choise == "2" || choise == "buy" || choise == "Buy")
                    {
                        mainPoint = 2;
                        option = 1;
                    }
                    else if (choise == "3" || choise == "Player" || choise == "player")
                    {
                        mainPoint = 3;
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
                    case 2:
                        Console.WriteLine("Ah lets se whats in the shop for you.");
                        levelSet = 4;
                        break;
                    case 3:
                        levelSet = 5;
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
                        Console.WriteLine("The Merman Alfred!");
                        statEnemy[0] = 8;
                        statEnemy[1] = 4;
                        statEnemy[2] = 0;
                        statEnemy[3] = 2;
                        statEnemy[4] = 1;
                        Kill(statPlayer[0], statPlayer[1], statPlayer[2], statPlayer[3], statPlayer[4], statEnemy[0], statEnemy[1], statEnemy[2], statEnemy[3], statEnemy[4], 5, 6, 8, 10);
                        levelSet = 0;
                        bosses[0] = 0;
                        shopLock = 0;
                        expCurrent = expCurrent + 10;
                        monney = monney + 10;
                        Console.Clear();
                        Console.WriteLine("You got 10 Exp from the battle.");
                        Console.WriteLine("You got 10 Coins from the battle.");
                    }
                    else if (levelLock == 2)
                    {
                        Console.WriteLine("In the dark deeps of the water...");
                        Console.WriteLine("He lives...");
                        Console.WriteLine("The Werewolf Henry!");
                        statEnemy[0] = 13;
                        statEnemy[1] = 6;
                        statEnemy[2] = 2;
                        statEnemy[3] = 5;
                        statEnemy[4] = 2;
                        Kill(statPlayer[0], statPlayer[1], statPlayer[2], statPlayer[3], statPlayer[4], statEnemy[0], statEnemy[1], statEnemy[2], statEnemy[3], statEnemy[4], 4, 5, 6, 10);
                        levelSet = 0;
                        bosses[1] = 0;
                        shopLock = 0;
                        expCurrent = expCurrent + 15;
                        monney = monney + 15;
                        Console.Clear();
                        Console.WriteLine("You got 15 Exp from the battle.");
                        Console.WriteLine("You got 15 Coins from the battle.");
                    }
                    else if (levelLock == 3)
                    {
                        Console.WriteLine("In the dark deeps of the water...");
                        Console.WriteLine("He lives...");
                        Console.WriteLine("The Spider HUU!");
                        statEnemy[0] = 25;
                        statEnemy[1] = 4;
                        statEnemy[2] = 5;
                        statEnemy[3] = 5;
                        statEnemy[4] = 2;
                        Kill(statPlayer[0], statPlayer[1], statPlayer[2], statPlayer[3], statPlayer[4], statEnemy[0], statEnemy[1], statEnemy[2], statEnemy[3], statEnemy[4], 5, 6, 8, 10);
                        levelSet = 0;
                        bosses[2] = 0;
                        shopLock = 0;
                        expCurrent = expCurrent + 25;
                        monney = monney + 25;
                        Console.Clear();
                        Console.WriteLine("You got 25 Exp from the battle.");
                        Console.WriteLine("You got 25 Coins from the battle.");
                    }
                    else if (levelLock == 4)
                    {
                        if (shopLock == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                shopNumber[i] = ranItem;
                                ranItem = generator.Next(5);
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Heres what i got (:");
                        for (int i = 0; i < 5; i++)
                        {
                            switch (shopNumber[i])
                            {
                                case 0:
                                    itemName[iventoryLoc] = "Axe";
                                    costItem[iventoryLoc] = 5;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                                case 1:
                                    itemName[iventoryLoc] = "Health Potion";
                                    costItem[iventoryLoc] = 3;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                                case 2:
                                    itemName[iventoryLoc] = "Large Health Potion";
                                    costItem[iventoryLoc] = 7;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                                case 3:
                                    itemName[iventoryLoc] = "Shield";
                                    costItem[iventoryLoc] = 7;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                                case 4:
                                    itemName[iventoryLoc] = "Speed Herb";
                                    costItem[iventoryLoc] = 3;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                                case 5:
                                    itemName[iventoryLoc] = "Power Potion";
                                    costItem[iventoryLoc] = 10;
                                    iventoryLoc = iventoryLoc + 1;
                                    break;
                            }
                        }
                        Console.WriteLine(itemName[0] + ", " + itemName[1] + ", " + itemName[2] + ", " + itemName[3] + ", " + itemName[4]);
                        Console.WriteLine("What would you like to buy? (write (Done) when done.");
                        string buy = Console.ReadLine();
                        if (buy == "1" && monney >= costItem[0])
                        {
                            iventoryLoc = 0;

                        }
                        levelSet = 0;
                        mainPoint = 0;
                        option = 0;
                    }
                    else if (levelLock == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Your name: " + name);
                        Console.WriteLine("");
                        Console.WriteLine("Health " + statPlayer[0]);
                        Console.WriteLine("Attack " + statPlayer[1]);
                        Console.WriteLine("Defence " + statPlayer[2]);
                        Console.WriteLine("Speed " + statPlayer[3]);
                        Console.WriteLine("Movement " + statPlayer[4]);
                        Console.WriteLine("");
                        Console.WriteLine("Items:");
                        Console.WriteLine("1: " + itemName[0] + " 2: " + itemName[1]);
                        Console.WriteLine("3: " + itemName[2] + " 4: " + itemName[3]);
                        Console.WriteLine("5: " + itemName[4] + " 6: " + itemName[5]);
                        Console.WriteLine("7: " + itemName[6] + " 8: " + itemName[7]);
                        Console.WriteLine("9: " + itemName[8] + " 10: " + itemName[9]);
                        Console.WriteLine("");
                        Console.WriteLine("Coins: " + monney);
                        Console.WriteLine("Exp: " + expCurrent);
                        levelSet = 0;
                        mainPoint = 0;
                        option = 0;
                    }

                }
            }

            Console.ReadLine();


        }
        static void Options()
        {
            Console.WriteLine("1.Fight");
            Console.WriteLine("2.Buy");
            Console.WriteLine("3.Player");
        }
        static void Died()
        {
            Console.WriteLine("You have Died");
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
            Console.Clear();
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
                Console.WriteLine(area[0] + " " + area[1] + " " + area[2] + " " + area[3] + " " + area[4] + " " + area[5] + " " + area[6]);
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


