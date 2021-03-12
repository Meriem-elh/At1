using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private string Aresse;

        public Client (string nom , string prenom,string adresse)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Aresse = adresse;


        }
        public void afficher()
        {
            Console.WriteLine("Votre nom  " + this.Nom + "Votre prenom  " +this.Prenom + "Votre adresse  " + this.Aresse);
         
        }




    }

}
