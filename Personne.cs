using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIO_2016_E4_1
{
    public class Personne
    {
        public string Nom { get; set; }

        public string LivrePrefere { get; set; }

        public string film { get; set; }

        public string MyProperty { get; set; }

        /// <summary>Récupère les données de l'utilisateur.</summary>
        public static Personne RecupereDonnees()
        {
            if (!File.Exists("donnees.xml"))
            {
                return null;
            }

            XmlSerializer convertisseur = new XmlSerializer(typeof(Personne));
            using (StreamReader lecteur = new StreamReader("donnees.xml"))
            {
                return convertisseur.Deserialize(lecteur) as Personne;
            }
        }





        /// <summary>Sauvegarde les données d'un utilisateur.</summary>
        /// <param name="utilisateur">Utilisateur à sauvegarder</param>
        public void SauvegardeDonnees()
        {
            XmlSerializer convertisseur = new XmlSerializer(typeof(Personne));
            using (StreamWriter ecriveur = new StreamWriter("donnees.xml"))
            {
                convertisseur.Serialize(ecriveur, this);
            }
        }
    }
}
