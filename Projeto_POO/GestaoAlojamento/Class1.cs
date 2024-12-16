using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamento
{
    public class Transport
    {
        public Transport(string tarifas)
        {
            Tarifas = tarifas;
        }
        private string Tarifas {  get; set; }
        // public void CalculateFare();
    }
    public class Bus : Transport
    {
        public Bus(string tarifas)  : base(tarifas) {
        {
            Tarifas = tarifas;
        }
        public void CalculateFare()
        {
            Console.WriteLine("");
        }
    }
    public class Train : Transport
    {
        public override void CalculateFare()
        {
            Console.WriteLine("");
        }
    }
}
