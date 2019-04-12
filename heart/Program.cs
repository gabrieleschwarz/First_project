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
            string[,] fragen = {{"Magst du Kaffee?", "ja"},
                                {"Ist Gabi super?", "ja"},
                                {"Magst du Affen?", "nein"},
                                {"Bisschen Glitzer?", "ja"},
                                {"Helene Fischer?", "nein"},
                                {"Ist Aufgeben eine Option?", "nein"},
                                {"Sind Schwestern super?", "ja"},
                                {"Keks?", "ja"},
                                {"Liebst du Emma?", "ja"},
                                {"Ananas auf Pizza?", "nein"},
                                {"Magst du Whos?", "nein"},
                               };

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
                Console.Write(fragen[0, 0]);
                // Verknüpfung frage antwort
                Console.SetCursorPosition(32, 2);
                string input = Console.ReadLine().ToLower();
                if (input == fragen[0, 1] )

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
            Console.Write(fragen[1, 0]);
            // Verknüpfung frage antwort
            Console.SetCursorPosition(32, 2);
            string input1 = Console.ReadLine().ToLower();

            if (input1 == fragen[1, 1] )

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
            Console.Write(fragen[2, 0]);
            Console.SetCursorPosition(32, 2);
            string input2 = Console.ReadLine().ToLower();
            if (input2 == fragen[2, 1] )

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
            Console.Write(fragen[3, 0]);
            Console.SetCursorPosition(32, 2);
            string input3 = Console.ReadLine().ToLower();
            if (input3 == fragen[3, 1])

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
            Console.Write(fragen[4, 0]);
            Console.SetCursorPosition(32, 2);
            string input4 = Console.ReadLine().ToLower();
            if (input4 == fragen[4, 1] )

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
            Console.Write(fragen[5, 0]);
            Console.SetCursorPosition(32, 2);
            string input5 = Console.ReadLine().ToLower();
            if (input5 == fragen[5, 1] )

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
            Console.Write(fragen[6, 0]);
            Console.SetCursorPosition(32, 2);
            string input6 = Console.ReadLine().ToLower();
            if (input6 == fragen[6, 1] )

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
            Console.Write(fragen[7, 0]);
            Console.SetCursorPosition(32, 2);
            string input7 = Console.ReadLine().ToLower();
            if (input7 == fragen[7, 1])

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
            Console.Write(fragen[8, 0]);
            Console.SetCursorPosition(32, 2);
            string input8 = Console.ReadLine().ToLower();
            if (input8 == fragen[8, 1] )

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
            Console.Write(fragen[9, 0]);
            Console.SetCursorPosition(32, 2);
            string input9 = Console.ReadLine().ToLower();
            if (input9 == fragen[9, 1])

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
            Console.Write(fragen[10, 0]);
            Console.SetCursorPosition(32, 2);
            string input10 = Console.ReadLine().ToLower();
            if (input10 == fragen[10, 1])

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
