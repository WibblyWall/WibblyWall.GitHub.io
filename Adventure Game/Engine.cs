using Potion_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mid_Term_Project
{
    class Engine
    {
        public Player currentPlayer = new Player();
        public Inventory inv = new Inventory();
        Location merlinShop = new Location();
        Location shop = new Location();
        Location woods = new Location();
        Location townSquare = new Location();
        Location pond = new Location();
        PotionKit kit = new PotionKit();
        public bool chapterOneRead = false;
        public bool cabinetItem = false;
        public bool woodItem = false;     
        public bool bakerInfo = false;
        public void Start()
        {
            Clear();
            Print("\"You have just been accepted as the master potion makers aprentice.\"");
            Print("\"Today is your first day and you will learn what the job entails.\"");
            Print("\"You stand outside the door of the potion shop.\"");
            Print("Press Any Key To Open The Door");
            ReadKey();
            Clear();
            Print("\"Welcome my new aprentice!!!  My name is Merlin.\"");
            Print("\"What is your name?\"");
            currentPlayer.name = ReadLine();
            Print($"\"Glad to meet you {currentPlayer.name}!!!\"");
            Print("\"I know it's your first day, but I already have an important task for you.\"");
            Print("\"There is a rare ingredient I need that only grows deep with the northern caves.\"");
            Print($"\"{currentPlayer.name}, are you up to the task?\"");
            ReadLine();
            Print("\"Wonderful Ok! Ok! Ok! Here's a book with all the information you will need.\"");
            Print("\"Here is a jar to help you collect stuff too.\"");
            Print("\"Best of luck to you.  I will see you when you return.\"");
            inv.items.Add("Potion Making Kit");
            inv.items.Add("Potion Book");
            inv.items.Add("Jar");
            Print("Press Any Key To Continue");
            ReadKey();
            Clear();
            Print("You hold the dusty book and jar in your hands as you stand in in the door way to the potion shop alone.");
            Print("Merlin flew out of there so fast leaving you with nothing but a book and jar.");
            FirstEvent();

        }
        public void FirstEvent()
        {
            Print("You could...");
            Print("\"a\" Read The First Chapter Of The Book");
            Print("\"b\" Look Around The Shop");
            Print("\"c\" Leave The Shop");
            Print("\"d\" Check Inventory");
            Print("\"e\" Do Nothing");
            string firstChoice = ReadLine();
            if (firstChoice == "a")
            {
                Clear();
                if (chapterOneRead == false)
                {
                    Print("You open the book to the first chapter.");
                    Print("Press Any Key To Open Book");
                    ReadKey();
                    Clear();
                    Book book = new Book();
                    book.Chapterone();
                    chapterOneRead = true;
                    FirstEvent();
                }
                else if (chapterOneRead == true)
                {
                    Print("You have already read chapter one.");
                    Print("You should complete what was instructed in the first chapter before you move on.");
                    Print("Would you like to reread chapter one?");
                    Print("\"a\" Yes");
                    Print("\"b\" No");
                    string rereadChapterOne = ReadLine();
                    if (rereadChapterOne == "a")
                    {
                        Print("You open the book to the first chapter.");
                        Print("Press Any Key To Open Book");
                        ReadKey();
                        Clear();
                        Book book = new Book();
                        book.Chapterone();
                        FirstEvent();
                    }
                    else if (rereadChapterOne == "b")
                    {
                        Print("You put the book away.");
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        FirstEvent();
                    }
                    else
                    {
                        Print("Invalid Input, please enter one of the options given.");
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        FirstEvent();
                    }
                }
                else
                {
                    Print("Invalid Input, please enter one of the options given.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    FirstEvent();
                }
            }
            else if (firstChoice == "b")
            {
                Clear();
                Print("You look around the shop and see a few things you could explore.");
                merlinShop.MerlinShopOne(inv, cabinetItem);
                FirstEvent();
            }
            else if (firstChoice == "c")
            {
                Clear();
                Print("You step out of the shop.");
                Print("You walk out into the town square.");
                SecondEvent();
            }
            else if (firstChoice == "d")
            {
                Clear();
                Print("You look into your bag and see...");
                inv.PlayerInventory(currentPlayer);
                FirstEvent();
            }
            else if (firstChoice == "e")
            {
                Clear();
                Print("You do nothing...");
                Print("Ok, no more sitting around you got to get to work.");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                FirstEvent();
            }
            else
            {
                Clear();
                Print("Invalid Input, please enter one of the options given.");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                FirstEvent();
            }
        }
        public void SecondEvent()
        {
            if (inv.items.Contains("Recovery Herb") && inv.items.Contains("Jar of Fresh Water") && inv.items.Contains("Jar of Sap"))
            {
                Print("You collected all the needed ingredients!!!");
                ThirdEvent();
            }
            else
            {
                Print("You look around and see a few places you could go.");
                Print("\"a\" Town Square");
                Print("\"b\" Town Shop");
                Print("\"c\" Woods");
                Print("\"d\" Pond");
                Print("\"e\" Merlin's Shop");
                Print("Or you could...");
                Print("\"f\" Check Your Inventory");
                Print("\"g\" Read The Book");
                Print("Which location would you like to go to?");
                string travel = ReadLine();
                if (travel == "a")
                {
                    Clear();
                    Print("You look around the town square.");
                    townSquare.TownSquare(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                    SecondEvent();
                }
                else if (travel == "b")
                {
                    Clear();
                    Print("You walk to the town shop and enter it.");
                    shop.Store(currentPlayer, inv);
                    SecondEvent();
                }
                else if (travel == "c")
                {
                    Clear();
                    Print("You walk into the woods.");
                    woods.Woods(inv, woodItem, bakerInfo, chapterOneRead);
                    SecondEvent();
                }
                else if (travel == "d")
                {
                    Clear();
                    Print("You walk to the pond.");
                    pond.Pond(inv, chapterOneRead);
                    SecondEvent();
                }
                else if (travel == "e")
                {
                    Clear();
                    Print("You walk back into merlin's shop.");
                    FirstEvent();
                }
                else if (travel == "f")
                {
                    Clear();
                    Print("You look into your bag and see...");
                    inv.PlayerInventory(currentPlayer);
                    SecondEvent();
                }
                else if (travel == "g")
                {
                    if (chapterOneRead == false)
                    {
                        Print("You open the book to the first chapter.");
                        Print("Press Any Key To Open Book");
                        ReadKey();
                        Clear();
                        Book book = new Book();
                        book.Chapterone();
                        chapterOneRead = true;
                        SecondEvent();
                    }
                    else if (chapterOneRead == true)
                    {
                        Print("You have already read chapter one.");
                        Print("You should complete what was instructed in the first chapter before you move on.");
                        Print("Would you like to reread chapter one?");
                        Print("\"a\" Yes");
                        Print("\"b\" No");
                        string rereadChapterOne = ReadLine();
                        if (rereadChapterOne == "a")
                        {
                            Print("You open the book to the first chapter.");
                            Print("Press Any Key To Open Book");
                            ReadKey();
                            Clear();
                            Book book = new Book();
                            book.Chapterone();
                            SecondEvent();
                        }
                        else if (rereadChapterOne == "b")
                        {
                            Print("You put the book away.");
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            SecondEvent();
                        }
                        else
                        {
                            Print("Invalid Input, please enter one of the options given.");
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            SecondEvent();
                        }
                    }
                    else
                    {
                        Print("Invalid Input, please enter one of the options given.");
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        FirstEvent();
                    }
                }
                else
                {
                    Print("Invalid Input, please enter one of the options given.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    SecondEvent();
                }
            }
        }
        public void ThirdEvent()
        {
            if (inv.items.Contains("Recovery Herb") && inv.items.Contains("Jar of Fresh Water") && inv.items.Contains("Jar of Sap"))
            {
                Print("Now it's time to make your first potion!");
                Print("Use your potion making kit to make the potion.");
                Print("Press Any Key To Use The Kit");
                ReadKey();
                Clear();
                kit.CreatePotion(inv);
                ThirdEvent();
            }
            else
            {
                Print("You did it!!!");
                Print("You are now a potion maker!!!");
                Print("Congratulations on beating the game!!!");
                Print("Press Any Key To End Program");
                ReadKey();
                End();
            }
        }
        public void End()
        {
           
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
