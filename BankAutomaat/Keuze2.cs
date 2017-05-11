using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaat
{
    class Keuze2 : Keus
    {
        public override string Keuze()
        {
            keuze = "2. Haal geld af";
            Console.WriteLine(keuze);
            return keuze;
        }
    }
}
