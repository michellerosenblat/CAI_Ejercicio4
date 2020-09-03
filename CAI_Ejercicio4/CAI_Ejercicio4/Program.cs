using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                string palabra1 = "";
                string palabra2 = "";
                Console.WriteLine("Ingrese la primera palabra a comparar");
                palabra1 = Console.ReadLine();
                char[] pal1 = palabra1.ToCharArray();
                Console.WriteLine("Ingrese la segunda palabra a comparar");
                palabra2 = Console.ReadLine();
                char[] pal2 = palabra2.ToCharArray();
                bool ok = true;
                bool eslamismaletra = false;
                int j = 0;



                for (int i = 0; i < pal1.Length; i++)
                {
                    if (eslamismaletra = false)
                    {

                        for (int j = 0; j < pal2.Length; j++)
                        {
                            if (pal1[i] == pal2[j])
                            {
                                pal2[j] = ' ';
                                eslamismaletra = true;
                            }
                        }
                    }

                }

                while (ok)
                {
                    for (int i = 0; i < pal1.Length; i++)
                    {
                        while (eslamismaletra = false && j < pal2.Length)
                        {
                            if (pal1[i] == pal2[j])
                            {
                                pal2[j] = ' ';
                                eslamismaletra = true;
                            }
                            else
                            {
                                j++;
                            }
                        }
                        if (eslamismaletra = false)
                        {
                            ok = false;
                        }
                        else
                        {
                            j = 0;
                        }

                    }


                }
                if (ok)
                {
                    Console.WriteLine("es un anagrama");
                }
                else
                {
                    Console.WriteLine("no es un anagrama");
                }
                Console.ReadLine();
            */

            while (true)
            {
                Console.WriteLine("Ingrese la primera palabra a comparar");
                string palabra1 = Console.ReadLine();
                Console.WriteLine("Ingrese la segunda palabra a comparar");
                string palabra2 = Console.ReadLine();

                if (palabra1.Length == palabra2.Length && palabraContieneA(palabra1, palabra2) && palabraContieneA(palabra2, palabra1))
                {
                    Console.WriteLine("Son anagramas");
                }
                else
                {
                    Console.WriteLine("No son anagramas");
                }
            }
        }
        static bool palabraContieneA(string palabra1, string palabra2)
        {
            return palabra2.All(letra => palabra1.Contains(letra));

        }
    }
}
