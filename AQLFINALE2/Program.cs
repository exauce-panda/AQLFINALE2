using System;
using System.Security.Cryptography.X509Certificates;

namespace AQLFINAL2
{
    public class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        static void Main()
        {

            //initialisations des 3 listes d'objets (listeDetudiant, listeDesCours, listeDesNotes) qu'on pourra manipuler simplent 

            List<Etudiant> listeDetudiant = new List<Etudiant>()
        { new Etudiant ("deezy", "466535", "exau"),  new Etudiant ("jake", "445723", "cloe"), new Etudiant ("beni", "464321", "panda") , new Etudiant ("maboy", "432195", "harry")};


            List<Cours> listeDesCours = new List<Cours>()
        { new Cours ("897hj", "1125", "Projet integration"), new Cours ("867ho", "1126", "ASQ"), new Cours ("947ij", "1127", "Statistique"), new Cours ("898ft", "1128", "Base de donnee")};


            List<Notes> listeDesNotes = new List<Notes>()
        { new Notes ("1125", "897hj", "A+"), new Notes ("1126", "867ho", "C"), new Notes ("1127", "947ij", "B-"), new Notes ("1128", "898ft", "F") };


            

            string numEtudiant;
            Console.WriteLine("Veuillez saisir votre numéro d'étudiant : ");
            numEtudiant = Console.ReadLine(); //le readline me permettra d'entrer des elements dans la console

            bool correspond = false;

            //jle but est de parcourir la liste afin de verifier quel element repond a notre condition et afficher une reponse valable
            for (int i = 0; i < listeDetudiant.Count; i++)
            {

                //si le numero d'etudiant correspond cette condition s'applique
                if (numEtudiant == listeDetudiant[i].numeroDetudiant)
                {
                    correspond = true;
                    Console.WriteLine("Cet eleve fait parti du cours de: " + listeDesCours[i].titre + " est sa note dans ce cours est: " + listeDesNotes[i].note);
                    Console.WriteLine("Veuillez saisir la note à ajouter : ");
                    string noteEtudiant = Console.ReadLine();
                    listeDesNotes[i].note = noteEtudiant;
                    Console.WriteLine("Cet eleve fait parti du cours de: " + listeDesCours[i].titre + " est sa nouvelle note dans ce cours est: " + listeDesNotes[i].note);
                }
            }


            //si le numero d'etudiant ne correspond pas cette condition s'applique
            if (!correspond)
            {
                Console.WriteLine("Cet eleve ne fait parti d'aucune de vos classes");
            }

            //pour fermer la console
            Console.WriteLine("Appuyez sur n'importe quelle touche pour fermer la console");
            Console.ReadLine(); 
        }




        //creation de la classe etudiant avec ses attribut et un constructeur
        public class Etudiant
        {
            public string name { get; set; }
            public string numeroDetudiant { get; set; }
            public string prenom { get; set; }

            public Etudiant(string name, string numeroDetudiant, string prenom) //constructeur
            {
                this.name = name;
                this.numeroDetudiant = numeroDetudiant;
                this.prenom = prenom;
            }

        }

        //creation de la classe cours avec ses attribut et un constructeur
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

        //creation de la classe notes avec ses attribut et un constructeur
        public class Notes
        {
            public string numeroDeCours { get; set; }
            public string numeroDetudiant { get; set; }
            public string note { get; set; }

            public Notes(string numeroDeCours, string numeroDetudiant, string note)
            {
                this.numeroDeCours = numeroDeCours;
                this.numeroDetudiant = numeroDetudiant;
                this.note = note;

            }


        }
    }}
