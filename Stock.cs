using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDeStock
{
    class Stock
    {
        List<Article> stock = new List<Article>() { new Article(1, "Tv", 78, 100) };
        public void Add()
        {
            Console.WriteLine("Ajouter le numéro de référence.");
            int newnumReference = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ajouter le nom de l'Article.");
            string newNom = Console.ReadLine();
            Console.WriteLine("Ajouter le prix d’achat.");
            double newPrixAchat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ajouter le prix de vente.");
            double newPrixVente = Convert.ToDouble(Console.ReadLine());
            stock.Add(new Article(newnumReference, newNom, newPrixAchat, newPrixVente));
            //List<Article> items = new List<Article>(){
            //    new Article(){ numReference= newnumReference, nom = newNom, prixAchat =newPrixAchat ,prixVente =newPrixVente }
            //};
        }

        public void Affichage()
        {
            foreach (var item in stock)
            {
                Console.WriteLine($"le numéro de référence : {item.numReference} || le nom de l'Article : {item.nom} || le prix d’achat : {item.prixAchat} || le prix de vente : {item.prixVente} ||");
            }
        }

        public void Rechercher()
        {
            Console.WriteLine("le nom d'article");
            string nomArticle = Console.ReadLine();
            foreach (var item in stock)
            {
                if (item.nom == nomArticle)
                {
                    Console.WriteLine($"le numéro de référence : {item.numReference} || le nom de l'Article : {item.nom} || le prix d’achat : {item.prixAchat} || le prix de vente : {item.prixVente} ||");
                }
                
            }
        }

        public void prixAchatSup()
        {
            Console.WriteLine("les prix d’achat ");
            double PrixAchatSaisie = Convert.ToDouble(Console.ReadLine());
            foreach (var item in stock)
            {
                if (item.prixAchat >= PrixAchatSaisie)
                {
                    Console.WriteLine($"le numéro de référence : {item.numReference} || le nom de l'Article : {item.nom} || le prix d’achat : {item.prixAchat} || le prix de vente : {item.prixVente} ||");
                }

            }
        }

        public void Suprime()
        {
            Console.WriteLine("le nom d'article que tu veux supprimer ");
            string nomArticle = Console.ReadLine();
            //foreach (var item in stock)
            //{
            //    if (item.nom == nomArticle)
            //    {
            //        int index = stock.IndexOf(item);
            //    }
                
            //}
            for(int i =0;i<= stock.Count; i++)
            {
                if(stock[i].nom == nomArticle)
                {
                    stock.RemoveAt(i);
                }
            }


        }

        public void Modifier()
        {
            Console.WriteLine("le nom d'article que tu veux modifier ");
            string nomArticle = Console.ReadLine();
            int Index = stock.FindIndex(s => s.nom == nomArticle);
            Console.WriteLine("Ajouter le numéro de référence.");
            int newnumReference = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ajouter le nom de l'Article.");
            string newNom = Console.ReadLine();
            Console.WriteLine("Ajouter le prix d’achat.");
            double newPrixAchat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ajouter le prix de vente.");
            double newPrixVente = Convert.ToDouble(Console.ReadLine());
            stock[Index] = new Article(newnumReference, newNom, newPrixAchat, newPrixVente);
            //for (int i = 0; i <= stock.Count; i++)
            //{
            //    if (stock[i].nom == nomArticle)
            //    {
            //        Console.WriteLine("Ajouter le numéro de référence.");
            //        int newnumReference = Int32.Parse(Console.ReadLine());
            //        Console.WriteLine("Ajouter le nom de l'Article.");
            //        string newNom = Console.ReadLine();
            //        Console.WriteLine("Ajouter le prix d’achat.");
            //        double newPrixAchat = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Ajouter le prix de vente.");
            //        double newPrixVente = Convert.ToDouble(Console.ReadLine());
            //        stock[i] = new Article(newnumReference, newNom, newPrixAchat, newPrixVente);
            //        Console.WriteLine(i);
            //    }
            //}
            //foreach (var item in stock)
            //{
            //    if (item.nom == nomArticle)
            //    {
            //        int index = stock.IndexOf(item);
            //        Console.WriteLine("Ajouter le numéro de référence.");
            //        int newnumReference = Int32.Parse(Console.ReadLine());
            //        Console.WriteLine("Ajouter le nom de l'Article.");
            //        string newNom = Console.ReadLine();
            //        Console.WriteLine("Ajouter le prix d’achat.");
            //        double newPrixAchat = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Ajouter le prix de vente.");
            //        double newPrixVente = Convert.ToDouble(Console.ReadLine());
            //        stock[index] = new Article(newnumReference, newNom, newPrixAchat, newPrixVente);
            //    }

            //}
            //for (int i = 0; i <= stock.Count; i++)
            //{

            //    if (stock[i].nom == nomArticle)
            //    {
            //        Console.WriteLine(stock[i]);
            //        Console.WriteLine("Ajouter le numéro de référence.");
            //        int newnumReference = Int32.Parse(Console.ReadLine());
            //        Console.WriteLine("Ajouter le nom de l'Article.");
            //        string newNom = Console.ReadLine();
            //        Console.WriteLine("Ajouter le prix d’achat.");
            //        double newPrixAchat = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Ajouter le prix de vente.");
            //        double newPrixVente = Convert.ToDouble(Console.ReadLine());
            //        //stock[i].numReference = newnumReference;
            //        //stock[i].nom = newNom;
            //        //stock[i].prixAchat = newPrixAchat;
            //        //stock[i].prixVente = newPrixVente;
            //        stock[i] = new Article(newnumReference, newNom, newPrixAchat, newPrixVente);
            //    }
            //}
        }

    }
}
