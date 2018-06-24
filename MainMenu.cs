using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkiCzarodziejow
{
    class MainMenu
    {
        public MainMenu()
        {
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Witaj w grze \"WALKI CZARODZIEJÓW\"\n" +
                    "Wybierz odpowiedznią cyfrę:\n" +
                    "1 Start gry\n" +
                    "2 Zasady\n" +
                    "3 Wyjście");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();

                    //Create a wizards
                    WizardCreatorSetType createWizard = new WizardCreatorSetType();

                    //Draw wizards from wizards creator.
                    List<Wizard> wizards = createWizard.DrawList();

                    //Put wizard list to fight
                    new WizardCombat(wizards);

                    Console.ReadKey();
                    Console.Clear();
                }

                if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("W grze tworzysz czarodziei którzy walczą ze sobą.\n" +
                        "Przed walką losowany jest czarodziej który zaczyna atakować jako pierwszy.\n" +
                        "Według tego losowania odbywa się już cała walka.\n" +
                        "Walka odbywa się do momentu kiedy jeden z czarodziei będzie miał 0 pkt życia.\n" +
                        "Po każdej rundzie możesz jednemu z czarodziei dać miksturę zdrowia która zwraca 8 pk życia.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (choice != "3");
        }
    }
}
