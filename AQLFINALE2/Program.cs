using System;
using System.Security.Cryptography.X509Certificates;

namespace AQLFINAL2
{
    public static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        static void Main()
        {

            string nomEtudiant;
            string prenomEtudiant;
            string numCours;
            string codeCours;
            string titreCours;
            



            string numEtudiant;
            string noteEtudiant;
            Console.WriteLine("veillez saisir votre numero d'etudiant: ");

            


            Console.WriteLine("veillez saisir la note à ajouter: ");
            noteEtudiant = Console.ReadLine();

            
            Console.WriteLine("appuyer sur n'importe quelle touche pour fermer la console"); Console.ReadLine();
            
        }
        public string ajouterNote(string newNote) {
            
            Console.WriteLine();

            return newNote;
        }


    }
    public class Etudiant
    {
        public string name { get; set; }
        public string numeroDetudiant { get; set; }
        public string prenom { get; set; }

        public Etudiant(string name, string numeroDetudiant, string prenom)
        {
            this.name = name;
            this.numeroDetudiant = numeroDetudiant;
            this.prenom = prenom;
        }

    }
    public class Cours

    {
        public string code { get; set; }
        public string numeroDeCours { get; set; }
        public string titre { get; set; }

        public Cours(string code, string numeroDeCours, string titre)
        {
            this.code = code;
            this.numeroDeCours = numeroDeCours;
            this.titre = titre;
        }

       
    }
    public class Notes
    {
        public string numeroDeCours {get; set;}
        public string numeroDetudiant {get; set;}
        public string note { get; set;}

public Notes(string numeroDeCours, string numeroDetudiant, string note)
        {
            this.numeroDeCours = numeroDeCours;
            this.numeroDetudiant = numeroDetudiant;
            this.note = note;
            
        }

        
    }
}
