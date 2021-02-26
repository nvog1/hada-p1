using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Clase que contiene métodos para pasar de minutos a segundos o a horas y viceversa
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Interfaz usuario-programa para concretar unidades y cantidad
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string unidades;
            string str_cantidad;
            string seguir;
            double double_cantidad;

            do
            {
                Console.WriteLine("¿Qué unidades usas?(m/s/h)");
                unidades = Console.ReadLine();

                Console.WriteLine("Introduce la cantidad");
                str_cantidad = Console.ReadLine();
                double_cantidad = double.Parse(str_cantidad);
                if(unidades == "m")
                {
                    Console.WriteLine(str_cantidad + " minutos son {0} segundos", Minutes2Seconds(double_cantidad));
                }
                else if(unidades == "h")
                {
                    Console.WriteLine(str_cantidad + "horas son {0} minutos", Hours2Minutes(double_cantidad));
                }
                else
                {
                    Console.WriteLine(str_cantidad + " segundos son {0} minutos", Seconds2Minutes(double_cantidad));
                }

                Console.WriteLine("¿Quieres seguir?(s/n)");
                seguir = Console.ReadLine();
            } while (seguir != "n");
        }

        /// <summary>
        /// Método que transforma de segundos a minutos
        /// </summary>
        /// <param name="s">Cantidad de segundos a convertir</param>
        /// <returns>Cantidad de segundos convertida a minutos.</returns>
        public static double Seconds2Minutes(double s)
        {
            if(s == 0)
            {
                return 0;
            }
            else
            {
                return s / 60;
            }
               
        }

        /// <summary>
        /// Método que transforma de minutos a segundos
        /// </summary>
        /// <param name="m">Cantidad de minutos a convertir</param>
        /// <returns>Cantidad de minutos convertida a segundos.</returns>
        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }

        /// <summary>
        /// Método que transforma de horas a minutos
        /// </summary>
        /// <param name="h">Cantidad de horas a convertir</param>
        /// <returns>Cantidad de horas convertida a minutos</returns>
        public static double Hours2Minutes(double h)
        {
            return h * 60;
        }
    }
}
