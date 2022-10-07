using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studia_karty__I._11
{
    internal class Program
    {



        public static void Main(string[] args)
        {


            string[] karty = { "as", "krol", "dama", "walet", "dziesiatka", "dziewiatka" };   // array string

            int[] input = new int[6];                                                           // array int

            Random rand = new Random();                                                        


            int index = rand.Next(karty.Length);                                                        // rand.Next w array karty 
            // wysietla karte  
            Console.WriteLine($"Losowo wybrana karta to:   {karty[index]}");                           //wypisuje



            if (karty[index] == "as")                                                                       // statment if. if karta losowa jest rowna karcie w if
            {
                Console.WriteLine("as = 11 pkt ");
                input[0] = 11;
            }
            else if (karty[index] == "krol")
            {
                Console.WriteLine("krol = 4 pkt");
                input[1] = 4;
            }
            else if (karty[index] == "dama")
            {
                Console.WriteLine("dama = 3 pkt");
                input[2] = 3;
            }
            else if (karty[index] == "walet")
            {
                Console.WriteLine("walet = 2 pkt");
                input[3] = 2;
            }
            else if (karty[index] == "dziesiatka")
            {
                Console.WriteLine("dziesiatka = 10 pkt");
                input[4] = 10;
            }
            else if (karty[index] == "dziewiatka")
            {
                Console.WriteLine("dziewiatka = 0 pkt");
                input[5] = 0;
            }

            // Wypisuje wartosc karty pkt.

            int sum = input.Sum();
            Console.WriteLine("wartosc wybranych kart " + sum);

            Console.ReadKey();


        }

    }
}
