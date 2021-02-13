using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        static void Main(string[] args)
        {
            string unidades;
            string str_cantidad;
            string seguir;
            double double_cantidad;

            do
            {
                Console.WriteLine("¿Qué unidades usas?(m/s)");
                unidades = Console.ReadLine();

                Console.WriteLine("Introduce la cantidad");
                str_cantidad = Console.ReadLine();
                double_cantidad = double.Parse(str_cantidad);
                if(unidades == "m")
                {
                    Console.WriteLine(str_cantidad + " minutos son {0} segundos", Minutes2Seconds(double_cantidad));
                }
                else
                {
                    Console.WriteLine(str_cantidad + " segundos son {0} minutos", Seconds2Minutes(double_cantidad));
                }

                Console.WriteLine("¿Quieres seguir?(s/n)");
                seguir = Console.ReadLine();
            } while (seguir != "n");
        }

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

        public static double Minutes2Seconds(double m)
        {
            return m * 60;
        }
    }
}
