using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Potion_Game
{
    internal class PotionKit
    {
        public void CreatePotion(Inventory inv)
        {
            Print("What potion would you like to make?");
            Print("\"a\" Healing Potion");
            Print("\"b\" Stop Potion Making");
            string potionSelect = ReadLine();
            if (potionSelect == "a")
            {
                if (inv.items.Contains("Recovery Herb") && inv.items.Contains("Jar of Fresh Water") && inv.items.Contains("Jar of Sap"))
                {
                 inv.items.Remove("Recovery Herb");
                 inv.items.Remove("Jar of Fresh Water");
                 inv.items.Remove("Jar of Sap");
                 inv.items.Add("Healing Potion");
                 Print("You made a healing potion!!!");
                 Print("Press Any Key To Continue");
                 ReadKey();
                 Clear();
                 CreatePotion(inv);
                }
                else
                {
                 Print("You don't have the required ingredients to make this potion.");
                 Print("Press Any Key To Continue");
                 ReadKey();
                 Clear();
                 CreatePotion(inv);
                }
            }
            else if (potionSelect == "b")
            {
                Print("You put the potion kit away.");
                ReadKey();
                Clear();
            }
            else
            {
             Print("Invalid Input, please enter one of the options given.");
             Print("Press Any Key To Continue");
             ReadKey();
             Clear();
             CreatePotion(inv);
            }
        }
        public void Print(string text, int speed = 25)
        {
            foreach (char c in text)
            {
                Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            WriteLine();
        }

    }
}
