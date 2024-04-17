using Mid_Term_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potion_Game
{
    class Book
    {
        public void Chapterone()
        {
            Print("\"Welcome to the potion makers guide book.\"");
            Print("\"This book will teach you all you need to know to start making your own potions.\"");
            Print("\"In this first chapter you will learn how to make the most basic potion.\"");
            Print("\"A potion of healing.\"");
            Print("\"For this potion you will need to following ingredients.\"");
            Print("\"1.) Fresh Water\"");
            Print("\"2.) Recovery Herb\"");
            Print("\"3.) Tree Sap\"");
            Print("\"Mix these up for 10 minutes then drain it.\"");
            Print("\"You will have a perfectly good potion of healing.\"");
            Print("\"Happy potion making!!!\"");
            Print("You put the book away.");
            Print("Press Any Key To Continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Print(string text, int speed = 25)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}
