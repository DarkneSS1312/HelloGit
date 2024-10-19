using System;

public class Revue : Livre
{
    public int Numero;
    public int Annee;

    public Revue(string titre, string auteur, int nbrPages, int numero, int annee)
        : base(titre, auteur, nbrPages)
    {
        Numero = numero;
        Annee = annee;
    }

    public void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine("Numéro: " + Numero);
        Console.WriteLine("Année: " + Annee);
    }
}
