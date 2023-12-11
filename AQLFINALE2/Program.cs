using System;
using System.Collections.Generic;

namespace AQLFINAL2
{
    public class Program
    {
        static void Main()
        {
            var listeDetudiant = new List<Etudiant>
            {
                new Etudiant("john", "271348", "smith"),
                new Etudiant("emma", "271309", "johnson"),
                new Etudiant("alex", "271145", "brown"),
                new Etudiant("sophie", "271195", "miller")
            };

            var listeDesCours = new List<Cours>
            {
                new Cours("837fj", "1129", "programmation"),
                new Cours("457lj", "1130", "web client"),
                new Cours("127ij", "1131", "android"),
                new Cours("823ht", "1132", "gestion")
            };

            var listeDesNotes = new List<Notes>
            {
                new Notes("1129", "837fj", "B+"),
                new Notes("1130", "457lj", "A"),
                new Notes("1131", "127ij", "C+"),
                new Notes("1132", "823ht", "A+")
            };

            Console.WriteLine("Veuillez saisir votre numéro d'étudiant : ");
            string numEtudiant = Console.ReadLine();

            bool correspond = false;

            for (int i = 0; i < listeDetudiant.Count; i++)
            {
                if (numEtudiant == listeDetudiant[i].NumeroDetudiant)
                {
                    correspond = true;
                    Console.WriteLine($"Cet élève fait partie du cours de {listeDesCours[i].Titre} et sa note dans ce cours est {listeDesNotes[i].Note}");
                    Console.WriteLine("Veuillez saisir la note à ajouter : ");
                    string noteEtudiant = Console.ReadLine();
                    listeDesNotes[i].Note = noteEtudiant;
                    Console.WriteLine($"Cet élève fait partie du cours de {listeDesCours[i].Titre} et sa nouvelle note dans ce cours est {listeDesNotes[i].Note}");
                }
            }

            if (!correspond)
            {
                Console.WriteLine("Cet élève ne fait partie d'aucune de vos classes");
            }

            Console.WriteLine("Appuyez sur n'importe quelle touche pour fermer la console");
            Console.ReadLine();
        }

        public class Etudiant
        {
            public string Name { get; set; }
            public string NumeroDetudiant { get; set; }
            public string Prenom { get; set; }

            public Etudiant(string name, string numeroDetudiant, string prenom)
            {
                Name = name;
                NumeroDetudiant = numeroDetudiant;
                Prenom = prenom;
            }
        }

        public class Cours
        {
            public string Code { get; set; }
            public string NumeroDeCours { get; set; }
            public string Titre { get; set; }

            public Cours(string code, string numeroDeCours, string titre)
            {
                Code = code;
                NumeroDeCours = numeroDeCours;
                Titre = titre;
            }
        }

        public class Notes
        {
            public string NumeroDeCours { get; set; }
            public string NumeroDetudiant { get; set; }
            public string Note { get; set; }

            public Notes(string numeroDeCours, string numeroDetudiant, string note)
            {
                NumeroDeCours = numeroDeCours;
                NumeroDetudiant = numeroDetudiant;
                Note = note;
            }
        }
    }
}
