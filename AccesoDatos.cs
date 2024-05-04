using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6.capaDatos
{
    public class AccesoDatos:interfaces.InterfaceDatos
    {
        /// <summary>
        /// Esta funcion escribe la lista de numeros perfectos en un archivo txt agregando a este el resultado de cada ejecucion
        /// </summary>
        /// <param name="numerosPerfectos">Es la lista donde se tienen todos los numeros perfectos hayados</param>
        /// <param name="rutaArchivo">Es la ruta donde se va guardar el archivo txt</param>
        /// <param name="agregarAlFinal">Es la variable que me permite agregar los datos al archivo txt sin sobreescribir</param>
        public void EscribirNumerosPerfectosEnArchivo(List<int> numerosPerfectos, string rutaArchivo, bool agregarAlFinal)
        {
            try
            {
                string rutaCompleta = Path.Combine(rutaArchivo, "numeros_perfectos.txt");

                using (StreamWriter sw = new StreamWriter(rutaCompleta, agregarAlFinal))
                {
                    sw.WriteLine("\n");
                    foreach (var numero in numerosPerfectos)
                    {
                        sw.WriteLine(numero);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir datos en el archivo" + ex.Message);
            }
            
        }
    }

}
