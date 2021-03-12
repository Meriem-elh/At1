using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Clt1 = new Client("tazi", "ali", "ali@hotmail.com");
            MAD solde = new MAD(10000);
            Compte Cmpt11 = new Compte(solde, Clt1);
            

            Clt1.afficher();
            Client Clt2 = new Client("thami", "mehjoub", "ali@mehjoub12.com");
            Compte Cmpt12 = new Compte(solde, Clt2);
            Cmpt12.afficher();
            MAD montant = new MAD(800);
            Cmpt12.verser(Cmpt11, montant);
            Cmpt11.afficher();
            Cmpt12.afficher();


            
        }
    }
}
