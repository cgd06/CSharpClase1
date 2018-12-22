using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.objetos
{
    class ClaseB
    {
        public void mostrarValorClaseA(ClaseA objA)
        {
            Console.WriteLine(objA.valor);
        }
        public void mostrarParamOpcional(int a = 3)
        {
            Console.WriteLine(a);
        }
    }
}
