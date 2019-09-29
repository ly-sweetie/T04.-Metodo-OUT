using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_OUT
{
    class Datos
    {
        //Metodo para convertir centavos a pesos
        public void Convertir(double TotalCen, out double Pesos, out double Centavos)
        {
            Pesos = TotalCen / 100;

            Centavos = TotalCen;
        }
    }
}
