using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class ControlDeFlujo
    {
        int x2 = 55; // este es el scope de todo el objeto

        public void ejemploDeIf()
        {
            var a = 0;
            if (a == 0) {
                Console.WriteLine("es cero");
            }
            else
            {
                Console.WriteLine("!0");
            }
        }
        public void ejemploDeSwitch() {
        }
        public void ejemploDeFor()
        {
            for (int a = 0; a!=2; a = 20)
            {
                Console.WriteLine("Dentro del for");
            }
        }
        public void ejemploDeWhile() {
        }
        public void ejemploDeDoWhile() {
            var a = 0;
            do
            {
                Console.WriteLine("valor de a" + a);
                a++;
            } while (a < 1);
        }

        public void ejemploForEach() {
            String[] arrMeses = new String[] { "Enero", "Febrero", "Marzo" };
            foreach (String mes in arrMeses) {
                Console.WriteLine(mes);
            }
        }

        public void ejemploDeScope() {

            int x1 = 0;

            for ( ; new DateTime().Day == 21; )
            {
                Console.WriteLine(x1);
                int x2 = 0;
                Console.WriteLine(x2);
            }
            Console.WriteLine(x2);
        }
        public void ejemploPasajeDeParametros(double[] meses) {
            foreach (var indiceMensual in meses)
            {
                Console.WriteLine(indiceMensual);
            }
        }
    }
}
