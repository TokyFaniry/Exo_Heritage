using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Heritage
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NiveauEnergie;

        public Personne(string nom, string prenom, int niveauEnergie)
        {
            Nom = nom;
            Prenom = prenom;
            NiveauEnergie = niveauEnergie;
        }
        public void setNiveauEnergie(int niveauEnergie)
        {
            this.NiveauEnergie = niveauEnergie;
        }
        public int getNiveauEnergie()
        {
            return this.NiveauEnergie;
        }

        public void Marcher(int kilometre)
        {
            Console.WriteLine("Marche.....");
            int NewEnergie;
            for (int i = 0; i <= kilometre; i++)
            {
                NewEnergie = this.NiveauEnergie - 5;
                if (NewEnergie < 0)
                {
                    Console.WriteLine("Plus d'energie");
                    break;
                }
                else
                {
                    setNiveauEnergie(NewEnergie);
                }
            }
            Console.WriteLine("Niveau Energie: " + this.getNiveauEnergie());
        }

        public void Manger(Aliment aliment,int quantite)
        {
            Console.WriteLine("En train de manger........");
            int NewEnergie;

            NewEnergie = this.NiveauEnergie + (aliment.ApportEnegetique*quantite);

            setNiveauEnergie(NewEnergie);

            Console.WriteLine("Niveau Energie: " + this.getNiveauEnergie());
            
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: "+this.Nom);
            Console.WriteLine("Prenom: " + this.Prenom);
            Console.WriteLine("Niveau d'enrgie: " + this.getNiveauEnergie());

        }
        
    }
}
