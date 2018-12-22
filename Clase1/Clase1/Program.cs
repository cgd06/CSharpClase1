using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1.objetos;

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

            ClaseA objeto1 = new ClaseA();
            ClaseB objetoDeClaseB = new ClaseB();

            objeto1.valor = "objeto1 del tipo ClaseA";
            objetoDeClaseB.mostrarValorClaseA(objeto1);
            objeto1.mostrarValor();
            ClaseA objeto2 = new ClaseA();
            objeto2.valor = "objeto2 del tipo ClaseA";
            objetoDeClaseB.mostrarValorClaseA(objeto2);
            objeto2.mostrarValor();

            objetoDeClaseB.mostrarParamOpcional(8);

            Console.ReadKey();
        }
    }
}
