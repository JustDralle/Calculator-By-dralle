using System;

namespace drallecalc
{
    class Program
    {
        static void Main()
        {
            // Opérandes (float) & opérateur (string)
            float operande1, operande2;
            char operateur;

            while (true) // Boucle infinie !
            {
                try
                {
                    // Effacer l'écran d'affichage
                    Console.Clear();

                    Console.WriteLine("Donnez-moi un calcul : ");
                    operande1 = float.Parse(Console.ReadLine());

                    // Contrôle de saisie pour réparer le fait de mettre 2 au lieu de +
                    bool ok = false;
                    do
                    {
                        /* 
                        Récupère le signe de l'opération (+,-,*,/)
                            * Console.ReadLine() permet de saisir une chaîne au clavier
                            * Une châine peut être vue comme un TABLEAU DE CARACTERES;  
                              il suffit d'un prendre le 1er élement.
                            EX :
                                !---!---!---!---!---! ...
                                ! + ! t ! o ! t ! o ! ...
                                !---!---!---!---!---! ...
                           Rang :  0   1   2   3   4
                        */
                        operateur = Console.ReadLine()[0];
                        if (operateur == '+' || operateur == '-' || operateur == '*' || operateur == '/')
                            ok = true;
                    } while (!ok);

                    operande2 = float.Parse(Console.ReadLine());

                    /* // Calcul selon l'opérateur saisi
                     if (operateur == '+')
                         Console.WriteLine("{0} + {1} = {2}", operande1, operande2, operande1 + operande2);
                     else
                     {
                         if (operateur == '-')
                             Console.WriteLine("{0} - {1} = {2}", operande1, operande2, operande1 - operande2);
                         else
                         {
                             if (operateur == '*')
                                 Console.WriteLine("{0} * {1} = {2}", operande1, operande2, operande1 * operande2);
                             else // Ce ne peut être que '/' (cf. contrôle de saisie)
                             {
                                 // Empêcher la division par zéro  !
                                 if (operande2 != 0)
                                     Console.WriteLine("{0} / {1} = {2}", operande1, operande2, operande1 / operande2);
                                 else
                                     Console.WriteLine("Une division par 0 n'est pas possible");
                             }
                         }
                     }*/
                    switch (operateur)
                    {
                        case '+':
                            Console.WriteLine("{0} + {1} = {2}", operande1, operande2, operande1 + operande2);
                            break;

                        case '-':
                            Console.WriteLine("{0} - {1} = {2}", operande1, operande2, operande1 - operande2);
                            break;

                        case '*':
                            Console.WriteLine("{0} * {1} = {2}", operande1, operande2, operande1 * operande2);
                            break;

                        case '/':
                            if (operande2 != 0)
                                Console.WriteLine("{0} / {1} = {2}", operande1, operande2, operande1 / operande2);
                            else
                                Console.WriteLine("Une division par 0 n'est pas possible");
                            break;

                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Erreur : " + error.Message);
                }
                try
                {
                    Console.Write("Continuer ? (O/N) : ");
                    char continuer = Console.ReadLine().ToUpper()[0];
                    if (continuer != 'O')
                        break; // On "casse" la boucle infinie
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur : " + e.Message);
                }
            } 

            Console.Write("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
