using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heart
{
    class Program

    {
        static void Main(string[] args)
        {
            #region Variable
            Console.Title = "Heart";
            // Variablen für Fragen
            string[] fragen = new string[11];
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

            
                FragezeileAntwortzeile();
                FrageAusgeben();
                Console.Write(fragen[0]);
                // Verknüpfung frage antwort
                Console.SetCursorPosition(32, 2);
                string input = Console.ReadLine().ToLower();
                if (input == J1 )
      
                    {
                        Console.SetCursorPosition(14, 10);
                        RoterPunkt();
                    }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }


            //2

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[1]);
            // Verknüpfung frage antwort
            Console.SetCursorPosition(32, 2);
            string input1 = Console.ReadLine().ToLower();

            if (input1 == J1 )

                {
                    Console.SetCursorPosition(15, 12);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }

            //3

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[2]);
            Console.SetCursorPosition(32, 2);
            string input2 = Console.ReadLine().ToLower();
            if (input2 == N1 )

                {
                    Console.SetCursorPosition(16, 8);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }

            //4

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[3]);
            Console.SetCursorPosition(32, 2);
            string input3 = Console.ReadLine().ToLower();
            if (input3 == J1)

                {
                    Console.SetCursorPosition(17, 14);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }

            //5

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[4]);
            Console.SetCursorPosition(32, 2);
            string input4 = Console.ReadLine().ToLower();
            if (input4 == N1 )

                {
                    Console.SetCursorPosition(18, 10);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }


            //6

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[5]);
            Console.SetCursorPosition(32, 2);
            string input5 = Console.ReadLine().ToLower();
            if (input5 == N1 )

                {
                    Console.SetCursorPosition(19, 16);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }


            //7

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[6]);
            Console.SetCursorPosition(32, 2);
            string input6 = Console.ReadLine().ToLower();
            if (input6 == J1 )

                {
                    Console.SetCursorPosition(20, 10);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }


            //8

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[7]);
            Console.SetCursorPosition(32, 2);
            string input7 = Console.ReadLine().ToLower();
            if (input7 == J1)

                {
                    Console.SetCursorPosition(21, 14);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }

            //9

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[8]);
            Console.SetCursorPosition(32, 2);
            string input8 = Console.ReadLine().ToLower();
            if (input8 == J1 )

                {
                    Console.SetCursorPosition(22, 8);
                    RoterPunkt();
                }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }

            //10

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[9]);
            Console.SetCursorPosition(32, 2);
            string input9 = Console.ReadLine().ToLower();
            if (input9 == N1)

            {
                Console.SetCursorPosition(23, 12);
                RoterPunkt();
            }
            else
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Leider Nein");
            }


            //11

            FragezeileAntwortzeile();
            FrageAusgeben();
            Console.Write(fragen[10]);
            Console.SetCursorPosition(32, 2);
            string input10 = Console.ReadLine().ToLower();
            if (input10 == N1)

                {
                    Console.SetCursorPosition(24, 10);
                    RoterPunkt();
                }

                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("Leider Nein");
                }
            
                //End
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        
        
          

      }

    }




