using ConsoleApp6.capaDatos;
using ConsoleApp6.capaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.capaPresentacion
{
    public class Principal
    {
        static void Main()
        {
            try
            {

                Console.WriteLine("Ingrese el inicio del rango: ");
                int inicio = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el fin del rango: ");
                int final = int.Parse(Console.ReadLine());

                NumeroPerfecto numeroPerfecto = new NumeroPerfecto(inicio, final);

                List<int> numerosPerfectos = numeroPerfecto.ObtenerNumerosPerfectos();

                Console.WriteLine($"Números perfectos en el rango [{inicio}, {final}]: ");

                foreach (var numero in numerosPerfectos)
                {
                    Console.WriteLine(numero);
                }

                Console.ReadLine();

                var accesoDatos = new AccesoDatos();
                string directorioEjecucion = Directory.GetCurrentDirectory();
                string rutaGuardar = Directory.GetParent(directorioEjecucion).Parent.FullName;
                accesoDatos.EscribirNumerosPerfectosEnArchivo(numerosPerfectos, rutaGuardar, true);

                Console.WriteLine("Números perfectos escritos en el archivo 'numeros_perfectos.txt'.");
                Console.ReadLine();
                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
            }
            
        }
    }
    
}
