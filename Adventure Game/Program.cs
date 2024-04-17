using Mid_Term_Project;

namespace Potion_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Potion Maker";
            string title = @"  
   ▄▄▄▄▀ ▄  █ ▄███▄       █ ▄▄  ████▄    ▄▄▄▄▀ ▄█ ████▄    ▄       █▀▄▀█ ██   █  █▀ ▄███▄   █▄▄▄▄ 
▀▀▀ █   █   █ █▀   ▀      █   █ █   █ ▀▀▀ █    ██ █   █     █      █ █ █ █ █  █▄█   █▀   ▀  █  ▄▀ 
    █   ██▀▀█ ██▄▄        █▀▀▀  █   █     █    ██ █   █ ██   █     █ ▄ █ █▄▄█ █▀▄   ██▄▄    █▀▀▌  
   █    █   █ █▄   ▄▀     █     ▀████    █     ▐█ ▀████ █ █  █     █   █ █  █ █  █  █▄   ▄▀ █  █  
  ▀        █  ▀███▀        █            ▀       ▐       █  █ █        █     █   █   ▀███▀     █   
          ▀                 ▀                           █   ██       ▀     █   ▀             ▀    
                                                                          ▀                   ";
            Print(ConsoleColor.Magenta, title);
            Print("Press Any Key To Play");
            Console.ReadKey();
            new Engine().Start();

        }
        public static void Print(string text, int speed = 1)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();


        }
        public static void Print(ConsoleColor color, string text, int speed = 1)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
            Console.ResetColor();

        }
    }
}
