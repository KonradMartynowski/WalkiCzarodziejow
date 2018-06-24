using System;
using System.Collections.Generic;

namespace WalkiCzarodziejow
{
    partial class WizardCreatorSetType
    {
        private List<Wizard> wizards = new List<Wizard>();
        public WizardCreatorSetType()
        {
            Console.WriteLine("Musisz stworzyć pierwszego czarodzieja.");
            Console.ReadKey();
            WizardCreator();
            Console.WriteLine("Musisz stworzyć drugiego czarodzieja.");
            Console.ReadKey();
            WizardCreator();
        }

        public List<Wizard> DrawList()
        {
            return wizards;
        }

        private void WizardCreator()
        {
            Console.Clear();
            Console.WriteLine("Jakiego czarodzieja chcesz stworzyc? Podaj odpowiednią cyfrę:" +
              "\n1 Czarodziej ognia" +
              "\n2 Czarodziej lodu" +
              "\n3 Szaman woodo");

            switch (Console.ReadLine())
            {
                case "1":
                    wizards.Add(new WizardCreatorSetBasicAtributes().SetBasicAttributes(new FireWizard()));
                    break;
                case "2":
                    wizards.Add(new WizardCreatorSetBasicAtributes().SetBasicAttributes(new FrostWizard()));
                    break;
                case "3":
                    wizards.Add(new WizardCreatorSetBasicAtributes().SetBasicAttributes(new WoodoShaman()));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Musisz wybrać od 1 dp 3!\n Spróbuj jeszcze raz.");
                    Console.ReadLine();
                    WizardCreator();
                    break;
            }
        }
    }
}
