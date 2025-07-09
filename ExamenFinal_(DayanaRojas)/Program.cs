using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal__DayanaRojas_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProgramaGeneral");
            Console.WriteLine("Ingresa la cantidad de Articulos: ");
            Console.WriteLine("Ingresa Total semanal de Arituclos: ");
            Console.WriteLine("Venta mínima registrada de un articulo en la semana (Min): ");
            Console.WriteLine("Venta máxima registrada de un articulo en la semana (Max): ");
            Console.WriteLine("Sumatoria diaria de ventas durante la semana: ");
            Console.WriteLine("total de ventas realizadas por día, sumando todos los artículos: ");
            Console.WriteLine("Promedio de ventas de cada articulo en la semana: ");
            int cantidadArticulos = int.Parse(Console.ReadLine());
            int totalSemanalArticulos = int.Parse(Console.ReadLine());
            int ventaMinima = int.Parse(Console.ReadLine());
            int ventaMaxima = int.Parse(Console.ReadLine());
            int sumatoriaDiariaVentas = int.Parse(Console.ReadLine());
            int totalVentasPorDia = int.Parse(Console.ReadLine());
            double promedioVentas = double.Parse(Console.ReadLine());
            

        }
    }
}
