using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.objetos
{
    class ClaseA
    {
        private ClaseB objb = new ClaseB();

        public string valor;
        public void mostrarValor() {
            objb.mostrarValorClaseA(this);
        }
    }
}
