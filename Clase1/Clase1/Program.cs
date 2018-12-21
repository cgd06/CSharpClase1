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
            new ControlDeFlujo().ejemploDeIf();
            new ControlDeFlujo().ejemploForEach();
            new ControlDeFlujo().ejemploPasajeDeParametros(new double[] { 2.1, 1.2, 3.5 });
        }
    }
}
