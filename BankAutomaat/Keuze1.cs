using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaat
{
    class Keuze1 : Keus
    {
        public override string Keuze()
        {
            keuze = "1. Stort geld";
            Console.WriteLine(keuze);
            return keuze;
        }
    }
}
