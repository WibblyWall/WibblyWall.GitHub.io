using Mid_Term_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Potion_Game
{
    class Location
    {
        public void MerlinShopOne(Inventory inv, bool cabinetItem)
        {
            Print("You see a...");
            Print("\"a\" office");
            Print("\"b\" cabinet");
            Print("\"c\" shelves");
            Print("Which would you like to inspect?");
            string exploreShop = ReadLine();
            if (exploreShop == "a")
            {
                Clear();
                Print("You walk into Merlin's office and see a mess of papers all over his desk.");
                Print("You look through the papers for a second but find nothing of use.");
                Print("Would you like to...");
                Print("\"a\" Look At One Of The Other Spots In The Store");
                Print("\"b\" Do Something Else");
                string exploreOffice = ReadLine();
                if (exploreOffice == "a")
                {
                    Print("You step out of the office.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    MerlinShopOne(inv, cabinetItem);
                }
                else if (exploreOffice == "b")
                {
                    Print("You step out of the office.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                }
                else
                {
                    Print("Invalid Input, please enter one of the options given.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    MerlinShopOne(inv, cabinetItem);
                }
            }
            else if (exploreShop == "b")
            {
                Clear();
                if (cabinetItem == false)
                {
                    Print("You open the cabinet and find a pouch of 'Recovery Herb'.");
                    Print("Would you like to take the pouch?");
                    Print("\"a\" Yes");
                    Print("\"b\" No");
                    string cabItem = ReadLine();
                    if (cabItem == "a")
                    {
                        inv.items.Add("Recovery Herb");
                        cabinetItem = true;
                        Print("You grab the pouch and put it in your bag then close the cabinet.");
                        Print("Would you like to...");
                        Print("\"a\" Look At One Of The Other Spots In The Store");
                        Print("\"b\" Do Something Else");
                        string exploreOffice = ReadLine();
                        if (exploreOffice == "a")
                        {
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            MerlinShopOne(inv, cabinetItem);
                        }
                        else if (exploreOffice == "b")
                        {
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            Print("Invalid Input, please enter one of the options given.");
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            MerlinShopOne(inv, cabinetItem);
                        }
                    }
                    else if (cabItem == "b")
                    {
                        Print("You leave the pouch where it sits and close the cabinet.");
                        Print("Would you like to...");
                        Print("\"a\" Look At One Of The Other Spots In The Store");
                        Print("\"b\" Do Something Else");
                        string exploreOffice = ReadLine();
                        if (exploreOffice == "a")
                        {
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            MerlinShopOne(inv, cabinetItem);
                        }
                        else if (exploreOffice == "b")
                        {
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                        }
                        else
                        {
                            Print("Invalid Input, please enter one of the options given.");
                            Print("Press Any Key To Continue");
                            ReadKey();
                            Clear();
                            MerlinShopOne(inv, cabinetItem);
                        }
                    }
                    else
                    {
                        Print("Invalid Input, please enter one of the options given.");
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        MerlinShopOne(inv, cabinetItem);
                    }
                }
                else if (cabinetItem == true)
                {
                    Print("The cabinet is is empty.");
                    Print("Would you like to...");
                    Print("\"a\" Look At One Of The Other Spots In The Store");
                    Print("\"b\" Do Something Else");
                    string exploreOffice = ReadLine();
                    if (exploreOffice == "a")
                    {
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        MerlinShopOne(inv, cabinetItem);
                    }
                    else if (exploreOffice == "b")
                    {
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                    }
                    else
                    {
                        Print("Invalid Input, please enter one of the options given.");
                        Print("Press Any Key To Continue");
                        ReadKey();
                        Clear();
                        MerlinShopOne(inv, cabinetItem);
                    }
                }
            }
            else if (exploreShop == "c")
            {
                Clear();
                Print("You look at all the expensive potions on the shelves.");
                Print("Probably best if you just leave them where they are.");
                Print("Would you like to...");
                Print("\"a\" Look At One Of The Other Spots In The Store");
                Print("\"b\" Do Something Else");
                string exploreOffice = ReadLine();
                if (exploreOffice == "a")
                {
                    Print("You step out of the office.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    MerlinShopOne(inv, cabinetItem);
                }
                else if (exploreOffice == "b")
                {
                    Print("You step out of the office.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                }
            }
            else
            {
                Clear();
                Print("Invalid Input Please Enter One Of The Given Letters");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                MerlinShopOne(inv, cabinetItem);
            }
        }
        public void TownSquare(Player currentPlayer, bool chapterOneRead, bool bakerInfo, bool woodItem)
        {
            Print("Press Any Key To Continue");
            ReadKey();
            Clear();
            Print("As you enter the town square you see two familar faces.");
            Print("\"a\" The first is the head baker of the town bakery.");
            Print("\"b\" The second is your friend Garth.");
            string talkTownSquare = ReadLine();
            if (talkTownSquare == "a")
            {
                Print("You walk over to the baker.");
                Print($"\"How is it going {currentPlayer.name}?\"");
                Print("The baker asks you.");
                Baker(currentPlayer, woodItem, bakerInfo, chapterOneRead);
            }
            else if (talkTownSquare == "b")
            {
                Print("You walk over to Grath.");
                Print($"\"Hiya!!! How are ya {currentPlayer.name}!!!\"");
                Garth(currentPlayer);
            }
            else
            {
                Print("Invalid Input Please Use One Of The Letters Given");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                TownSquare(currentPlayer, chapterOneRead, bakerInfo, woodItem);
            }
        }
        public void Store(Player currentPlayer, Inventory inv)
        {
            Print("A lady stands at the counter of the store.");
            Print($"\"Hi {currentPlayer.name}, would you like to buy anything?\"");
            Print("\"a\" Recovery Herb - 9 Gold");
            Print("\"b\" Jar - 5 Gold");
            Print("\"c\" Magic Berry - 13 Gold");
            Print("\"d\" Leave The Shop");
            string buy = ReadLine();
            if (buy == "a")
            {
                if (currentPlayer.gold >= 9)
                {
                    currentPlayer.gold -= 9;
                    Print("\"Here is your 'Recovery Herb'.\"");
                    inv.items.Add("Recovery Herb");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
                else
                {
                    Print("\"I'm sorry you don't have enough gold to buy that.\"");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
            }
            else if (buy == "b")
            {
                if (currentPlayer.gold >= 5)
                {
                    currentPlayer.gold -= 5;
                    Print("\"Here is your 'Jar'.\"");
                    inv.items.Add("Jar");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
                else
                {
                    Print("\"I'm sorry you don't have enough gold to buy that.\"");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
            }
            else if (buy == "c")
            {
                if (currentPlayer.gold >= 13)
                {
                    currentPlayer.gold -= 13;
                    Print("\"Here is your 'Magic Berry'.\"");
                    inv.items.Add("Magic Berry");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
                else
                {
                    Print("\"I'm sorry you don't have enough gold to buy that.\"");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Store(currentPlayer, inv);
                }
            }
            else if (buy == "d")
            {
                Print("\"Have a nice day!\"");
                Print("The lady waves as you leave the store.");
                ReadKey();
                Clear();
            }
            else
            {
                Print("Invalid Input Please Use One Of The Letters Given");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                Store(currentPlayer, inv);
            }
        }
        public void Woods(Inventory inv, bool woodItem, bool bakerInfo, bool chapterOneRead)
        {
            Print("You see a bunch of trees in the forest");
            Print("Well it is a forest...");
            if (bakerInfo == true)
            {
                Print("You knowing you can find sap on the pine trees.");
            }
            Print("Would you like to inspect them?");
            Print("\"a\" Yes");
            Print("\"b\" No");
            string treeCheck = ReadLine();
            if (treeCheck == "a")
            {
                Print("You see a bunch of different types of trees.");
                Print("Which would you like to look at?");
                Print("\"a\" Oak");
                Print("\"b\" Maple");
                Print("\"c\" Pine");
                Print("\"d\" Ash");
                Print("\"e\" Elm");
                Print("\"f\" Berch");
                Print("\"g\" Or Go Back To The Town Square");
                string treeCheckTwo = ReadLine();
                if (treeCheckTwo == "a")
                {
                    Print("The tree is very tall with acorns around the base.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
                else if (treeCheckTwo == "b")
                {
                    Print("The maple tree has big red leaves.");
                    Print("Press AnyKey To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
                else if (treeCheckTwo == "c")
                {
                    if (chapterOneRead == true && woodItem == false)
                    {
                        Print("You see sap driping down the side of the tree.");
                        if (inv.items.Contains("Jar"))
                        {
                            Print("You can use your jar to collect the sap.");
                            Print("Would you like to?");
                            Print("\"a\" Yes");
                            Print("\"b\" No");
                            string sapCheck = ReadLine();
                            if (sapCheck == "a")
                            {
                                inv.items.Remove("Jar");
                                inv.items.Add("Jar of Sap");
                                Print("You fill the jar with sap.");
                                woodItem = true;
                                Print("Press AnyKey To Continue");
                                ReadKey();
                                Clear();
                                Woods(inv, woodItem, bakerInfo, chapterOneRead);
                            }
                            else if (sapCheck == "b")
                            {
                                Print("Press AnyKey To Continue");
                                ReadKey();
                                Clear();
                                Woods(inv, woodItem, bakerInfo, chapterOneRead);
                            }
                            else
                            {
                                Print("Invalid Input Please Use One Of The Given Characters");
                                Print("Press AnyKey To Continue");
                                ReadKey();
                                Clear();
                                Woods(inv, woodItem, bakerInfo, chapterOneRead);
                            }
                        }
                        else
                        {
                            Print("You need something that could contain the sap.");
                            Print("Press AnyKey To Continue");
                            ReadKey();
                            Clear();
                            Woods(inv, woodItem, bakerInfo, chapterOneRead);
                        }
                    }
                    else if (chapterOneRead == true && woodItem == true)
                    {
                        Print("There is just the residue of the sap on the tree not enough to collect.");
                        Print("Press AnyKey To Continue");
                        ReadKey();
                        Clear();
                        Woods(inv, woodItem, bakerInfo, chapterOneRead);
                    }
                    else
                    {
                        Print("You see sap driping down the side of the tree.");
                        Print("Press AnyKey To Continue");
                        ReadKey();
                        Clear();
                        Woods(inv, woodItem, bakerInfo, chapterOneRead);
                    }
                }
                else if (treeCheckTwo == "d")
                {
                    Print("You see a beetle walking into a hole in the tree.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
                else if (treeCheckTwo == "e")
                {
                    Print("This tree is very big and has big loose peices of bark.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
                else if (treeCheckTwo == "f")
                {
                    Print("There is white paper like bark that is flaking off the tree.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
                else if (treeCheckTwo == "g")
                {
                    Print("You walk back to the town square.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Given Characters");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Woods(inv, woodItem, bakerInfo, chapterOneRead);
                }
            }       
            else if (treeCheck == "b")
            {
                Print("You walk back to the town square.");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
            }
            else
            {
                Print("Invalid Input Please Use One Of The Given Characters");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                Woods(inv, woodItem, bakerInfo, chapterOneRead);
            }
        }
        public void Pond(Inventory inv, bool chapterOneRead)
        {
            Print("You see the small body of clear water.");
            if (chapterOneRead == true && inv.items.Contains("Jar"))
            {
                Print("You need to collect some of the fresh water.");
                Print("Would you like to use the jar to collect it?");
                Print("\"a\" Yes");
                Print("\"b\" No");
                string pondCheck = ReadLine();
                if (pondCheck == "a")
                {
                    Print("You scoop up some of the water into the jar.");
                    inv.items.Remove("Jar");
                    inv.items.Add("Jar of Fresh Water");
                    Print("You walk back to the town square.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                }
                else if (pondCheck == "b")
                {
                    Print("You walk back to the town square.");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                }
                else
                {
                    Print("Invalid Input Please Use A Given Character");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Pond(inv, chapterOneRead);
                }
            }
            else if (chapterOneRead == true)
            {
                Print("You need to collect some of the fresh water.");
                Print("But you don't have anything to use.");
                Print("You walk back to the town square.");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();                
            }
            else
            {
                Print("Invalid Input Please Use A Given Character");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                Pond(inv, chapterOneRead);
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
        public void Baker(Player currentPlayer, bool chapterOneRead, bool bakerInfo, bool woodItem)
        {
            Print("You could say...");
            Print("\"a\" What do you know about Merlin?");
            Print("\"b\" How have you been?");
            if (chapterOneRead == true && woodItem == false)
            {
                Print("\"c\" Do you know where I could find some tree sap?");
            }
            string bakerTalk = ReadLine();
            if (bakerTalk == "a")
            {
                Print("\"He quite the absent minded man.\"");
                Print("\"Maybe you will help him kkep his things together\"");
                Print("Would you like to...");
                Print("\"a\" Continue talking to the baker");
                Print("\"b\" Do something else");
                string talkBaker = ReadLine();
                if (talkBaker == "a")
                {
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
                else if (talkBaker == "b")
                {
                    Print("You walk back to the center of the town square.");
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Letters Given");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
            }
            else if (bakerTalk == "b")
            {
                Print("\"Just finished making the bread for this morning so I'm doing ok\"");
                Print("Would you like to...");
                Print("\"a\" Continue talking to the baker");
                Print("\"b\" Do something else");
                string talkBaker = ReadLine();
                if (talkBaker == "a")
                {
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
                else if (talkBaker == "b")
                {
                    Print("You walk back to the center of the town square.");
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Letters Given");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
            }
            else if (chapterOneRead == true && woodItem == false && bakerTalk == "c")
            {
                Print("\"Yeah, if you go into the woods and look at the trunks of the pine trees...\"");
                Print("\"you should be able to find some.\"");
                Print("Would you like to...");
                Print("\"a\" Continue talking to the baker");
                Print("\"b\" Do something else");
                bakerInfo = true;
                string talkBaker = ReadLine();
                if (talkBaker == "a")
                {
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
                else if (talkBaker == "b")
                {
                    Print("You walk back to the center of the town square.");
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Letters Given");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
                }
            }
            else
            {
                Print("Invalid Input Please Use One Of The Letters Given");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                Baker(currentPlayer, chapterOneRead, bakerInfo, woodItem);
            }
        }
        public void Garth(Player currentPlayer)
        {
            Print("Grath waves at you.");
            Print("He is kind but not the smartest.");
            Print("He won't have any helpful information.");
            Print("You could say...");
            Print("\"a\" How has your day been?");
            Print("\"b\" What are you up to?");
            string garthTalk = ReadLine();
            if (garthTalk == "a")
            {
                Print("\"My day has been good!\"");
                Print("\"I wanna swim in the fresh water of the pond!\"");
                Print("Would you like to...");
                Print("\"a\" Continue talking to the Garth");
                Print("\"b\" Do something else");
                string talkBaker = ReadLine();
                if (talkBaker == "a")
                {
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Garth(currentPlayer);
                }
                else if (talkBaker == "b")
                {
                    Print("You walk back to the center of the town square.");
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Letters Given");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Garth(currentPlayer);
                }
            }
            else if (garthTalk == "b")
            {
                Print("\"Standing here.\"");
                Print("\"I wanna swim in the fresh water of the pond though!\"");
                Print("Would you like to...");
                Print("\"a\" Continue talking to the baker");
                Print("\"b\" Do something else");
                string talkBaker = ReadLine();
                if (talkBaker == "a")
                {
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Garth(currentPlayer);
                }
                else if (talkBaker == "b")
                {
                    Print("You walk back to the center of the town square.");
                }
                else
                {
                    Print("Invalid Input Please Use One Of The Letters Given");
                    Print("Press Any Key To Continue");
                    ReadKey();
                    Clear();
                    Garth(currentPlayer);
                }
            }
            else
            {
                Print("Invalid Input Please Use One Of The Letters Given");
                Print("Press Any Key To Continue");
                ReadKey();
                Clear();
                Garth(currentPlayer);
            }
        }
    }
}
