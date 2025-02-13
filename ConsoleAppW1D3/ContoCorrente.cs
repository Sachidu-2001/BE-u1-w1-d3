using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D3
{
    public class ContoCorrente
    {
        public string NumeroConto { get; set; } = "";
        public string ProprietarioConto { get; set; } = "";
        public decimal SaldoConto { get; set; } = 0;


        public ContoCorrente(string numeroConto, string proprietarioConto, decimal saldoConto)
        {
            NumeroConto = numeroConto;
            ProprietarioConto = proprietarioConto;

            if (saldoConto > 0) {
                Console.WriteLine("Il Saldo è disponibile");
            } else {
                Console.WriteLine("ATTENZIONE, IL TUO SALDO SI TROVA IN ROSSO");
            }


        }
    }
}