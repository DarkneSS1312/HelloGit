using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Créer une liste de livres
        List<Livre> livres = new List<Livre>();

        // Créer des instances de Revue
        Revue revue1 = new Revue("Science Magazine", "John Doe", 50, 123, 2023);
        Revue revue2 = new Revue("Nature", "Jane Smith", 40, 456, 2023);
        Revue revue3 = new Revue("National Geographic", "Alice Johnson", 30, 789, 2023);

        // Ajouter les revues à la liste
        livres.Add(revue1);
        livres.Add(revue2);
        livres.Add(revue3);

        // Créer des instances de Roman
        Roman roman1 = new Roman("Le Petit Prince", "Antoine de Saint-Exupéry", 96, "Fiction");
        Roman roman2 = new Roman("1984", "George Orwell", 328, "Dystopie");
        Roman roman3 = new Roman("Pride and Prejudice", "Jane Austen", 432, "Romance");

        // Ajouter les romans à la liste
        livres.Add(roman1);
        livres.Add(roman2);
        livres.Add(roman3);

        // Afficher les détails de chaque livre
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
            Console.WriteLine(); // Ligne vide pour séparer les livres
        }
    }
}
