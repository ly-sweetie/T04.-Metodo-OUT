using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_OUT
{
    class Program

    {
      
        static void Main(string[] args)
        {
            //Declarar Variables
            double TotalCentavo;
            double Pesos = 0;
            double Centavos = 0;

            //Bienvenida e introducir centavos
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Centavos:");
            TotalCentavo = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            //Intanciamos
            Datos d = new Datos();
          
            d.Convertir(TotalCentavo, out Pesos, out Centavos);

            //Mostrar resultados
            Console.WriteLine("Total en centavos:"+Centavos);
            Console.ReadLine();
            Console.WriteLine("Total en pesos:"+Pesos);
            Console.ReadKey();
        }
    }
}
