using System;

public class Roman : Livre
{
    public string Genre;

    public Roman(string titre, string auteur, int nbrPages, string genre)
        : base(titre, auteur, nbrPages)
    {
        Genre = genre;
    }

    public void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine("Genre: " + Genre);
    }
}
