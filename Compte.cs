using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Compte

    {
        public readonly int numCompte;
        private static int cpt = 0;
        private readonly Client titulaire;
        private MAD soldeCompte;
        private MAD plafond=new MAD(6000);





        public Compte(MAD sol, Client Cli)
        {


            this.numCompte = cpt++;
            this.soldeCompte = sol;
            this.titulaire = Cli;
            

        }
        

        public void Crediter(MAD montant)
        {

            this.soldeCompte += montant;
            Console.WriteLine("Operation reussi");


        }
        public bool debiter(MAD montant)
        {


            if (montant >= soldeCompte) {
                Console.WriteLine("Montant insufissant ");
                Console.ReadLine();
                return false;

            }
            else {
                if (montant <= plafond)
                {
                    Console.WriteLine("Vous depassez votre plafond");
                    Console.ReadLine();
                    return false;
                }

                else {
                    Console.WriteLine("Votre operation a reussi ");
                    Console.ReadLine();
                    this.soldeCompte -= montant;
                    return true;
                }
            }


        }
        public bool verser(Compte C, MAD montant)
        {
            bool F = this.debiter(montant);
            if (F == true)
            {
                C.Crediter(montant);
                Console.Out.WriteLine("Virement effectue ");
            }
            else
            {
                Console.Out.WriteLine("Veuillez verifiez l'etat de votre compte");

            }
            return F;
        }
        public void afficher()
        {
            Console.WriteLine("Votre numero de compte" + this.numCompte);
            Console.WriteLine("Vos informations ");
            titulaire.afficher();
            Console.Write("Votre Solde");
            this.soldeCompte.afficher();
            Console.Write("Le plafond de votre Compte");
            this.plafond.afficher();



        }
        
        
    }
}

    

