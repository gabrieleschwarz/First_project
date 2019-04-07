using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heart
{
    class Program
        // Oliver war hier
    {
        static void Main(string[] args)
        {
            #region Variable
            Console.Title = "Heart";
            // Variablen für Fragen
            string[] fragen = new string [11];
            fragen[0] = "Magst du Kaffee?";
            fragen[1] = "Ist Gabi super?";
            fragen[2] = "Magst du Affen?";
            fragen[3] = "Bisschen Glitzer?";
            fragen[4] = "Helene Fischer?";
            fragen[5] = "Ist Aufgeben eine Option?";
            fragen[6] = "Sind Schwestern super?";
            fragen[7] = "Keks?";
            fragen[8] = "Liebst du Emma?";
            fragen[9] = "Ananas auf Pizza?";
            fragen[10] = "Magst du Whos?";
            string J1 = "ja";
            string N1 = "nein";
            // Rote Punkte

            Coordinate Punkt;
            Punkt.X = 14;
            Punkt.Y = 10;
            Coordinate Punkt1;
            Punkt1.X = 15;
            Punkt1.Y = 12;
            Coordinate Punkt2;
            Punkt2.X = 16;
            Punkt2.Y = 8;
            Coordinate Punkt3;
            Punkt3.X = 17;
            Punkt3.Y = 14;
            Coordinate Punkt4;
            Punkt4.X = 18;
            Punkt4.Y = 10;
            Coordinate Punkt5;
            Punkt5.X = 19;
            Punkt5.Y = 16;
            Coordinate Punkt6;
            Punkt6.X = 20;
            Punkt6.Y = 10;
            Coordinate Punkt7;
            Punkt7.X = 21;
            Punkt7.Y = 14;
            Coordinate Punkt8;
            Punkt8.X = 22;
            Punkt8.Y = 8;
            Coordinate Punkt9;
            Punkt9.X = 23;
            Punkt9.Y = 12;
            Coordinate Punkt10;
            Punkt10.X = 24;
            Punkt10.Y = 10;

            



            //Spielfeld
            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(28, 1);
            Console.Write("Ja /Nein");
            #endregion

            //Schleife

            for (int i = 0; i < fragen.Length; i++)
            {
                FragezeileAntwortzeile();

                FrageAusgeben();

                 
                Console.Write(fragen[i]);
                

                // Verknüpfung frage antwort

                Console.SetCursorPosition(32, 2);

                string input = Console.ReadLine().ToLower();
                if (input == J1 && i== 0 ||
                    input == J1 && i == 1 ||
                    input == N1 && i == 2 ||
                    input == J1 && i == 3 ||
                    input == N1 && i == 4 ||
                    input == N1 && i == 5 ||
                    input == J1 && i == 6 ||
                    input == J1 && i == 7 ||
                    input == J1 && i == 8 ||
                    input == N1 && i == 9 ||
                    input == N1 && i == 10 )
                {

                    Console.SetCursorPosition(14, 10);
                    RoterPunkt();
                }
                

                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Leider Nein");
                }

            }
           


            
            
            
            
            
            

            Console.SetCursorPosition(7, 7);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("Miau!");
            Console.Write(" ENDE ");
            Console.ReadKey();
            Console.CursorVisible = false;
              
            }


        static void FragezeileAntwortzeile()
        {  //Fragen zeile
           
            Console.SetCursorPosition(5, 5);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("______________________________");
            Console.SetCursorPosition(5, 5);

            //Antwort zeile

            Console.SetCursorPosition(32, 2);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("____");
            Console.SetCursorPosition(32, 2);
        }

        static void FrageAusgeben()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 5);
        }

        static void RoterPunkt()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("_");
        }
        static void FindeneuePunktPosition()
        {
        }
    }

   struct Coordinate
    {public int X;
        public int Y;
    }
   

}


