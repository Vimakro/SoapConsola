using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapConsolaAmori.ServicioAmori;

namespace SoapConsolaAmori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicioAmori.TipoCambio servicio = new ServicioAmori.TipoCambio();


            var respuesta = servicio.TipoCambioDia();

            if (respuesta != null )
            {
                Console.WriteLine(respuesta.CambioDolar.First().fecha);
                Console.WriteLine(respuesta.CambioDolar.First().referencia);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No hay respuesta");
            }


        }
    }
}
