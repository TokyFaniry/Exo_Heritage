using System.ComponentModel;
using System.ComponentModel.Design.Serialization;

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
            int i;

            for ( i = 1; i < kilometre; i++)
            {
                NewEnergie = this.NiveauEnergie - 5;

                if (NewEnergie < 0)
                {
                    Console.WriteLine("Oooooohhhh.....Plus d'energie , manger des aliments pour recuperer des energies");
                    break;
                }
                else
                {
                    setNiveauEnergie(NewEnergie);
                }
            }
            Console.WriteLine("Marche de " + i + "Km fait");

            Console.WriteLine("Niveau Energie: " + this.getNiveauEnergie());
        }
        public void Courir(int kilometre)
        {
            Console.WriteLine("Vitee.....");

            int NewEnergie;
            int i;

            for (i = 1; i < kilometre; i++)
            {
                NewEnergie = this.NiveauEnergie - 5;

                if (NewEnergie < 0)
                {
                    Console.WriteLine("Oooooohhhh.....Plus d'energie , manger des aliments pour recuperer des energies");
                    break;
                }
                else
                {
                    setNiveauEnergie(NewEnergie);
                }
            }
            Console.WriteLine("T'as couru " + i + "Km ");

            Console.WriteLine("Niveau Energie: " + this.getNiveauEnergie());
        }

        public void Manger(Aliment aliment, int quantite)
        {
            Console.WriteLine("En train de manger du " + aliment.NomAliment + "........");
            int NewEnergie;
         
            NewEnergie = this.NiveauEnergie + (aliment.ApportEnegetique * quantite);

            setNiveauEnergie(NewEnergie);

            Console.WriteLine("Niveau Energie: " + this.getNiveauEnergie());

        }


        public void Afficher()
        {
            Console.WriteLine("Nom: " + this.Nom);
            Console.WriteLine("Prenom: " + this.Prenom);
            Console.WriteLine("Niveau d'enrgie: " + this.getNiveauEnergie());

        }
        
    }
}
