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
        Carotte carotte= new Carotte();
        Banane banane=new Banane();

        za.Manger(legume,50);
        za.Marcher(10);
        za.Manger(chocolat,2);
        za.Marcher(1000);
        za.Manger(fruit, 10);
        za.Manger(legume, 10);
        za.Courir(10);
        za.Manger(carotte, 10);
        za.Manger(banane, 5);

    }
}
