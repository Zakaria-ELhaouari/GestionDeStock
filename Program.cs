using System;
using System.Collections;

namespace GestionDeStock
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stock stockFun = new Stock();
            string q = "0";
            
            while (q=="0")
            {
                Console.WriteLine(@"1.Ajouter un nouvel Article.
                2.Afficher tous les Articles du magasin.
                3.Rechercher un Article.
                4.Afficher les Articles dont les prix d’achat est supérieur à une valeur saisie.
                5.Supprimer un Article.
                6.Modifier un Article."
                );
                string x = Console.ReadLine();
                if (x == "1")
                {
                    stockFun.Add();
                    stockFun.Affichage();
                }
                else if (x == "2")
                {
                    stockFun.Affichage();
                }
                else if (x == "3")
                {
                    stockFun.Rechercher();
                }
                else if (x == "4")
                {
                    stockFun.prixAchatSup();
                }
                else if (x == "5")
                {
                    stockFun.Suprime();
                    stockFun.Affichage();
                }
                else if (x == "6")
                {
                    stockFun.Modifier();
                    stockFun.Affichage();
                }
                else
                {
                    q = "1";
                }
            }
        }
            
    }
}
