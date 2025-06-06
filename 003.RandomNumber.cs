using System;

namespace Raten1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Zahl, Eingabe;
            Random Zufall = new Random();
            Zahl = Zufall.Next(1, 101); // Zufallszahl zwischen 1 und 100
            Console.WriteLine("Willkommen zum Zahlraten!");
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 ausgewählt.");


            do {
                Console.WriteLine("Versuche sie zu erraten!");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe < Zahl)
            {
                Console.WriteLine("Die gesuchte Zahl ist größer als deine Eingabe.");
            }
            if (Eingabe > Zahl)
            {
                Console.WriteLine("Die gesuchte Zahl ist kleiner als deine Eingabe.");
            }
            } while(Eingabe != Zahl);   
            if (Eingabe == Zahl)
            {
                Console.WriteLine("Herzlichen Glückwunsch! Du hast die Zahl erraten.");
            }
            
            
        }
    }
}