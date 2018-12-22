using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.calculos
{
    class CalculoDeIndiceDeInflacion
    {
        private double calculoInterno() {
            return 0;
        }
        public double calcularTrimestre(double[] octNovDic)
        {
            double valorBase = 100;
            double acumulador = valorBase;

            foreach (double indiceMes in octNovDic) {
                acumulador += (acumulador * indiceMes / 100);
            }

            double valorBruto = (acumulador - valorBase) * 100 / valorBase;
            double valorRedondeado = Math.Round(valorBruto, 2);
            double valorTruncado = Math.Truncate(valorBruto * 100) / 100;
            return valorRedondeado;
        }
    }
}
