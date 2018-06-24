using System;
using System.Collections.Generic;

namespace WalkiCzarodziejow
{
    class WizardCombat
    {
        public WizardCombat(List<Wizard> wizards)
        {
            int random;
            int first;
            int second;
            random = new Random().Next(0, 1);

            if (random == 0)
            {
                first = 0;
                second = 1;
            }
            else
            {
                first = 1;
                second = 0;
            }

            do
            {
                Console.WriteLine("=============PRZED==TURĄ================\n");
                Console.WriteLine("{0} ma {1} punktów życia.",wizards[first].GetName(),wizards[first].GetHp());
                Console.WriteLine("{0} ma {1} punktów życia.",wizards[second].GetName(),wizards[second].GetHp());
                Console.WriteLine("\n================WALKA===================\n");

                wizards[second].GetDammage(wizards[first].CastSpell());
                
                Console.Write("\n");

                if (wizards[second].IsALive())
                {
                    Console.WriteLine("\n============WALKA=SKOŃCZONA============\n");
                    Console.WriteLine("{0} nie żyje",wizards[second].GetName());
                    firstWin(wizards[first].GetName());
                    break;
                }

                wizards[first].GetDammage(wizards[second].CastSpell());

                if (wizards[first].IsALive())
                {
                    Console.WriteLine("\n============WALKA=SKOŃCZONA============\n");
                    Console.WriteLine("{0} nie żyje", wizards[first].GetName());
                    secandWin(wizards[second].GetName());
                    break;
                }

                Console.WriteLine("\n\n==============PO=TURZE===================\n");
                Console.WriteLine("{0} ma {1} punktów życia.", wizards[first].GetName(), wizards[first].GetHp());
                Console.WriteLine("{0} ma {1} punktów życia.", wizards[second].GetName(), wizards[second].GetHp());

                Console.ReadKey();

                healthPotion(wizards,first,second);

            } while (true);
        }

        private void healthPotion(List<Wizard> wizards,int first, int second)
        {
            string choice;
            string wizardChoice;

            do
            {
                Console.WriteLine(
                    "Czy chcesz wspomóc któregoś czarodzieja miksturą zdrowia?\n" +
                    "1. tak\n" +
                    "2. nie"
                    );

                choice = Console.ReadLine();
                Console.Clear();

                if (choice == "1")
                {
                    choice:
                    Console.WriteLine("Którego czarodzieja chcesz wspomóc? Podaj cyfrę:\n" +
                        "1. {0}\n" +
                        "2. {1}\n", wizards[first].GetName(), wizards[second].GetName());

                    switch (wizardChoice = Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            wizards[first].DrinkHealthPotion();
                            choice = "2";
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.Clear();
                            wizards[second].DrinkHealthPotion();
                            choice = "2";
                            Console.ReadKey();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Nie rozumiem. Sprubójmy jeszcze raz!");
                            Console.ReadKey();
                            goto choice;
                    }
                } 
            } while (choice != "2");

            Console.Clear();
        }

        private void secandWin(string name)
        {
            Console.WriteLine("{0} wygrywa starcie!",name);
        }

        private void firstWin(string name)
        {
            Console.WriteLine("{0} Wygrywa starcie!",name);
        }

    }
}
