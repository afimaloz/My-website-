using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIO_2016_E4_1
{
    class Program
    {
        public static Personne _utilisateur;

        static void Main(string[] args)
        {
            //Récupère d'éventuelles données sauvegardées.
            _utilisateur = Personne.RecupereDonnees();
            
            if(_utilisateur == null)
            {
                //Si aucun utilisateur à été récupéré, on en créer un nouveau
                _utilisateur = new Personne();

                Console.WriteLine("Bienvenue");
                Console.WriteLine("Cette application est destinée à enregistrer le nom de votre livre préféré.");

                //On demande le nom de l'utilisateur
                SaisirNom();

                //On demande le livre préféré
                SaisirLivre();
                //On demande le film préféré 
                Saisirfilm(); 

            }
            else
            {
                Console.WriteLine("Bienvenue " + _utilisateur.Nom);
                Console.WriteLine("Votre livre préféré est : " + _utilisateur.LivrePrefere);
                Console.WriteLine("Votre film préféré est : " + _utilisateur.film); 
            }

            string saisie = "";

            //On affiche le menu pour laisser le choix à l'utilisateur de modifier ses informations
            do
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------ MENU ------------------------");
                Console.WriteLine("1 - Modifier le nom de l'utilisateur");
                Console.WriteLine("2 - Changer de livre préféré");
                Console.WriteLine("4 - film");
                Console.WriteLine("3 - Quitter l'application");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("");

                saisie = Console.ReadLine();

                if (saisie == "1")
                {
                    SaisirNom();
                }
                else if(saisie == "2")
                {
                    SaisirLivre();
                }
                if (saisie == "4")
                {
                    //Console.WriteLine(string tableau, object nom, object LivrePrefere) ;
                    Saisirfilm();
                }

            }

            while (saisie != "3");

            Console.WriteLine("Vous vous apprétez à quitter l'application.");

            //L'utilisateur veux quitter l'application, on lui demande s'il veut sauvegarder ses données
            do
            {
                Console.WriteLine("Souhaitez-vous sauvegarder vos données ? Y/N");
                saisie = Console.ReadLine();
            } while (saisie.ToUpper() != "Y" && saisie.ToUpper() != "N");

            if(saisie.ToUpper() == "Y")
            {
                //On sauvegarde les données de l'utilisateur
                _utilisateur.SauvegardeDonnees();
            }
        }

        static void SaisirNom()
        {
            Console.WriteLine("Entrez votre nom :");

            _utilisateur.Nom = Console.ReadLine();
        }

        static void SaisirLivre()
        {
            Console.WriteLine("Saisissez le titre de votre livre préféré :");

            _utilisateur.LivrePrefere = Console.ReadLine();
        }

        static void Saisirfilm()
        {
            Console.WriteLine("Saisissez le titre de votre film préféré :");

            _utilisateur.film = Console.ReadLine();
        }

    }
}
