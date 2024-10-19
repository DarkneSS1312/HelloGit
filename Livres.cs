using System;

public class Livre
{
    public string Titre;
    public string Auteur;
    public int NombrePages;

    public Livre(string titre, string auteur, int nbrPages)
    {
        Titre = titre;
        Auteur = auteur;
        NombrePages = nbrPages;
    }

    public void AfficherDetails()
    {
        Console.WriteLine("Titre: " + Titre);
        Console.WriteLine("Auteur: " + Auteur);
        Console.WriteLine("Nombre de Pages: " + NombrePages);
    }
}
