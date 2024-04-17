using Mid_Term_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Potion_Game
{
    class Inventory
    {
        public List<string> items = new List<string>();
        public void PlayerInventory(Player currentPlayer)
        {
            Print($"You have {currentPlayer.gold} gold.");
            Print("And these items in your inventory...");
            foreach (var item in items)
            {
                Print(item);
            }
            Print("In your bag.");
            Print("Press Any Key To Continue");
            ReadKey();
            Clear();
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
