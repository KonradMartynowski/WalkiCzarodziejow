using System;

namespace WalkiCzarodziejow
{
    partial class WizardCreatorSetType
    {
        class WizardCreatorSetBasicAtributes
        {

            public Wizard SetBasicAttributes(Wizard wizard)
            {
                string name;
                int str;
                int hp;
                int pointLeft = 20;

                Console.Clear();

                Console.WriteLine("Jak ma na imie czarodziej?");
                name = Console.ReadLine();
                Console.Clear();

                do
                {
                    Console.WriteLine("Uważaj masz tylko 20 pkt nauki.\n" +
                        "Za punkty nauki kupujesz punkty siły i życia. \n" +
                        "Bazowo czarodziej ma 10 punktów życia i 5 siły.\n" +
                        "Ile pkt siły chcesz kupić?");

                    str = SetStr();
                    Console.Clear();

                } while (str > pointLeft);
                pointLeft -= str;

                do
                {
                    Console.WriteLine("Ile pkt życia chcesz kupić? Zostało {0} pkt nauki", pointLeft);

                    hp = SetHp();
                    Console.Clear();

                } while (hp > pointLeft);

                wizard.SetStats(name, str, hp);

                return wizard;
            }

            private int SetStr()
            {
                try
                {
                    return Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("TO NIE JEST LICZBA! SPROBUJ JESZCZE RAZ!");
                    Console.ReadKey();
                    Console.Clear();
                    return SetStr();
                }
            }

            private int SetHp()
            {
                try
                {
                    return Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("TO NIE JEST LICZBA! SPROBUJ JESZCZE RAZ!");
                    Console.ReadKey();
                    Console.Clear();
                    return SetHp();
                }
            }
        }
    }
}
