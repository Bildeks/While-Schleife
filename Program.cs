using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            string nochmal;
            do
            {
                int Auswahl;
                Console.WriteLine("1. Zahlenreihe ");
                Console.WriteLine("2. Durchschnitt Note ");
                Console.WriteLine("3. 3-Vielmehr Zahlenreihe ");
                Console.WriteLine("4. Einkauf mit Bargeld ");
                Console.Write("Auswahl: ");
                Auswahl = Convert.ToInt32(Console.ReadLine());
                switch (Auswahl)
                {
                    case 1:
                        Console.Write("Startwert: ");
                        int st = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Endwert: ");
                        int et = Convert.ToInt32(Console.ReadLine());
                        if (st <= et)
                        {
                            while (st <= et)
                            {
                                Console.WriteLine(st + " ");
                                st++;
                            }
                        }
                        else if (st >= et)
                        {
                            while (st >= et)
                            {
                                Console.WriteLine(st + " ");
                                st--;
                            }
                        }


                        break;
                    case 2:
                        int Noten, Summe = 0, Count = 0;
                        Console.Write("Note: ");
                        Noten = Convert.ToInt32(Console.ReadLine());
                        while (Noten != 0)
                        {
                            Summe += Noten;
                            Count++;
                            Console.Write("Noten: ");
                            Noten = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Durchschnitt: " + Math.Round((double)Summe/Count, 2) );
                        break;
                    case 3:
                        Console.Write("Startwert: ");
                        int Startwert = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Endwert: ");
                        int Endwert = Convert.ToInt32(Console.ReadLine());
                        if (Startwert <= Endwert)
                        {
                            while (Startwert <= Endwert)
                            {

                                Console.WriteLine(Startwert + " ");
                                Startwert = Startwert + 2;
                                Startwert++;
                            }
                        }
                        else if (Startwert >= Endwert)
                        {
                            while (Startwert >= Endwert)
                            {

                                Console.WriteLine(Startwert + " ");
                                Startwert = Startwert - 2;
                                Startwert--;
                            }
                        }
                        break;



                    case 4:
                        int Bargeld = 30;
                        double Summ = 0;
                        double Überschritt;
                        Console.Write("Einkauf: ");
                        double Einkauf = Convert.ToDouble(Console.ReadLine());
                        while (Summ <= Bargeld)
                        {
                            
                            Console.Write("Einkauf: ");
                            Einkauf = Convert.ToDouble(Console.ReadLine());
                            Summ = Summ + Einkauf;
                        }
                        if (Summ >= 30)
                        {
                            Überschritt = Summ - Bargeld;
                            Console.WriteLine("Sie haben eine Überschritt von {0},00- Euro", Überschritt);
                        }
                        //else if (Summ <= 30)
                        //{
                        //    Console.WriteLine("Summe: " + Summ);
                        //    Console.WriteLine("Sie haben noch" + "x");
                        //}
                        else
                        {
                            Console.WriteLine("deine Waren kosten genau 30,00- Euro");
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Falsche Eingabe");
                        break;
                }
                Console.Write("Press X to restart: ");
                nochmal = Console.ReadLine();
                Console.Clear();
            } while (nochmal == "x" || nochmal == "X");
        }
    }
}
