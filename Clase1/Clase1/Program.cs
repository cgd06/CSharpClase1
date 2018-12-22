using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCompuesto = new calculos.CalculoDeIndiceDeInflacion().calcularTrimestre(new double[] {
                2.1,
                2.3,
                1.4
            });
        }
    }
}
