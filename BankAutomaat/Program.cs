using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaat
{
    class Program
    {
        public static int geld = 0;
        static void PrintMenu()
        {
            Console.WriteLine("1. Stort geld"); Console.WriteLine("2. Geld afhalen"); Console.WriteLine("3. Saldo");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            BankAccount rekening = new BankAccount();            
            bool finished = false;            
            while (!finished)
            {
                PrintMenu();
                int keuze = int.Parse(Console.ReadLine());
                switch (keuze)
                {
                    case 0: Console.WriteLine("Doei"); finished = true; break;
                    case 1: rekening.Stort(); break;
                    case 2: rekening.Afhaal(); break;
                    case 3: rekening.Saldo(); break;
                }
            }
        }
    }
}


