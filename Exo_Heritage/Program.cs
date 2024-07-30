using Exo_Heritage;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Personne za = new Personne("Toky", "Faniry", 200);

        za.Afficher();
        Legume legume = new Legume();
        Fruit fruit = new Fruit();
        Chocolat chocolat = new Chocolat();
        Console.WriteLine(chocolat.ApportEnegetique);
        za.Manger(legume,50);
        za.Marcher(10);
        za.Manger(chocolat,2);
        za.Marcher(1000);
    }
}
