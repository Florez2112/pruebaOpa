using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.capaNegocios
{
    internal class NumeroPerfecto:interfaces.InterfaceNumeros
    {
        private int inicio;
        private int final;

        public NumeroPerfecto(int inicio, int final)
        {
            this.inicio = inicio;
            this.final = final;
        }

        public int getInicio() { return inicio; }
        public int getFinal() { return final; }

        /// <summary>
        /// Esta funcion guarda los numeros enteros perfectos hallados en una lista entera
        /// </summary>
        /// <returns>retorna una lista entera con los numeros enteros perfectos</returns>
        public List<int> ObtenerNumerosPerfectos()
        {
            try
            {
                var numerosPerfectos = new List<int>();

                for (int num = this.inicio; num <= this.final; num++)
                {
                    if (EsNumeroPerfecto(num))
                    {
                        numerosPerfectos.Add(num);
                    }
                }
                return numerosPerfectos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la lista de numeros perfectos" + ex.Message);
                throw;
            }

        }
        /// <summary>
        /// Esta funcion encuentra los numeros enteros perfectos 
        /// </summary>
        /// <param name="num"> Es el numero que deseamos ver si es perfecto</param>
        /// <returns>retorna True si el num es un numero perfecto y False si num no es perfecto</returns>
        private bool EsNumeroPerfecto(int num)
        {
            try
            {
                int sumaDivisores = 1; // 1 siempre es divisor de cualquier número

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                return sumaDivisores == num;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los numeros perfectos" + ex.Message);
                throw;
            }
            
        }
    }
}
