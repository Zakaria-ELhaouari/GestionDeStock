using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GestionDeStock
{
    class Article
    {
        public int numReference;
        public string nom;
        public double prixAchat;
        public double prixVente;
        
        public Article(int numReference, string nom,double prixAchat,double prixVente)
        {
            this.numReference = numReference;
            this.nom = nom;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;
            if(prixAchat> prixVente)
            {
                throw new System.ArgumentException("seriously");
            }

        }

        //int reff,string nom,double achat,double vente
        
        public string attributsArticle()
        {
            return $"le numéro de référence : {this.numReference} || le nom de l'Article : {this.nom} || le prix d’achat : {this.prixAchat} || le prix de vente : {this.prixVente} ||";
        }

    }
}
