using System;
namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int SaisieNbElt()
            {
                Console.Write("nombre total d'éléments à gérer = ");
                return int.Parse(Console.ReadLine());
            }
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) 
                { 
                    Environment.Exit(0); 
                }

                if (choix == 1)
                {
                    int nbElt = SaisieNbElt();
                    //calcul de r
                    long r = 1;
                    for (int k = 1; k <= nbElt; k++)
                        r *= k;
                    Console.WriteLine(nbElt + "! = " + r);
                }
                else
                {
                    if (choix == 2)
                    {
                        int nbElt = SaisieNbElt();
                        int nbEltSousEns = SaisieNbElt();
                        // calcul de r
                        long r = 1;
                        for (int k = (nbElt - nbEltSousEns + 1); k <= nbElt; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + nbElt + "/" + nbEltSousEns + ") = " + r);
                    }
                    else
                    {
                        int nbElt = SaisieNbElt();
                        int nbEltSousEns = SaisieNbElt();
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (nbElt - nbEltSousEns + 1); k <= nbElt; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nbEltSousEns; k++)
                            r2 *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + nbElt + "/" + nbEltSousEns + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
