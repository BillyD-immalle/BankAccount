using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAutomaat
{
    class Keuze3 : Keus
    {
        public override string Keuze()
        {
            keuze = "3. Saldo";
            Console.WriteLine(keuze);
            return keuze;
        }
    }
}
