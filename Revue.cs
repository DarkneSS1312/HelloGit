using static Program;

namespace AppConsoleLivres
{
    public class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

        public Revue(string titre, string auteur, int nbrPages, int numero, int annee)
            : base(titre, auteur, nbrPages)
        {
            Numero = numero;
            Annee = annee;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numéro: {Numero}, Année: {Annee}");
        }
    }
}

