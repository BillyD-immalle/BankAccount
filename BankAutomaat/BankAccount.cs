using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaat
{
    public class BankAccount
    {
        public int rekening = 0;
        public static int geld = 0;

        public void Stort()
        {
            Console.WriteLine("Hoeveel wilt u storten?");

            geld = int.Parse(Console.ReadLine());
            Console.WriteLine(geld + " wordt gestort");
            rekening = rekening + geld;
            Console.WriteLine("Wat wilt u doen?");
        }
        public void Afhaal()
        {
            Console.WriteLine("Hoeveel wilt u afhalen?");

            geld = int.Parse(Console.ReadLine());
            if (rekening >= geld)
            {
                Console.WriteLine(geld + " wordt gegeven");
                rekening = rekening - geld;
            }
            else
            {
                Console.WriteLine("Rekening ontoereikend");
            }
            Console.WriteLine("Wat wilt u doen?");
        }
        public void Saldo()
        {
            Console.WriteLine("Dit is uw saldo");
            Console.WriteLine(rekening);
        }
    }
}
