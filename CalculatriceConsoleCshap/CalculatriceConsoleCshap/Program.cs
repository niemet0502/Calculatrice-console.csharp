using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceLgl
{
    class Program
    {
        static void Main(string[] args)
        {
            string cal;
            do
            {
                int choix = 0, nb1 = 0, nb2 = 0;
                Console.WriteLine("\t\t\tcalculatrice");
                Console.WriteLine("\t\t-------------MENU-------------");
                Console.WriteLine("\t\t1-------------------- addition");
                Console.WriteLine("\t\t2---------------- soustraction");
                Console.WriteLine("\t\t3---------------multiplication");
                Console.WriteLine("\t\t4---------------------division");
                Console.WriteLine("\t\t5----------------------quitter");
                Console.WriteLine(" ");
                Console.WriteLine("entrer le premier nombre");
                nb1 = int.Parse(Console.ReadLine());
                Console.WriteLine("entrer le deuxieme nombre");
                nb2 = int.Parse(Console.ReadLine());
                do
                {

                    Console.WriteLine("choisissez votre operation");
                    choix = int.Parse(Console.ReadLine());

                } while (!(choix >= 1 && choix <= 5));


                switch (choix)
                {
                    case 1:
                        Console.WriteLine(nb1 + "+" + nb2 + "=" + (nb1 + nb2));
                        break;
                    case 2:
                        Console.WriteLine(nb1 + "-" + nb2 + "=" + (nb1 - nb2));
                        break;
                    case 3:
                        Console.WriteLine(nb1 + "*" + nb2 + "=" + (nb1 * nb2));
                        break;
                    case 4:
                        if (nb2 == 0)
                        {
                            Console.WriteLine("operation impossible");
                        }
                        else
                        {
                            Console.WriteLine(nb1 + "/" + nb2 + "=" + (nb1 / nb2));
                        }

                        break;
                    case 5:
                        Console.WriteLine("Aurevoir...");
                        break;



                }
                Console.WriteLine("voulez vous faire un autre calcul?[o/n]");
                cal = Console.ReadLine();
                Console.Clear();
            } while (cal == "o" || cal == "O");
            if (cal == "n" || cal == "N")
            {
                Console.WriteLine("\t\t\t\t-----fin du calcul-----");
            }

            Console.ReadLine();
        }
    }
}