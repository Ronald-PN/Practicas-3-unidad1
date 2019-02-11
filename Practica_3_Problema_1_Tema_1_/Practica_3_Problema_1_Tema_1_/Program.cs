using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3_Problema_1_Tema_1_
{
    class Program
    {
        private int[,] mat;

        public void Cargar()
        {
            int TS1, TS2, n = 1, m = 1;
            mat = new int[4, 2];
            Console.WriteLine("");
            Console.WriteLine("Por favor inserte los sueldos del primer turno");
            Console.WriteLine("");
            for (int x = 0; x < 4; x++)
            {
            for (int c = 0; c < 1; c++)
                {
            Console.WriteLine("Por favor inserte el sueldo del empleado " + n + " : ");
            Console.WriteLine("");
          mat[x, c] = Convert.ToInt32(Console.ReadLine());
                   n += 1;
                }
            }
            TS1 = mat[0, 0] + mat[1, 0] + mat[2, 0] + mat[3, 0];
            Console.WriteLine("Por favor inserte los sueldos del segundo turno : ");
            Console.WriteLine("");
            for (int f = 0; f < 4; f++)
            {
                for (int v = 1; v < 2; v++)
                {
                    Console.WriteLine("Introduzca el sueldo del trabajador " + m + " : ");
                    Console.WriteLine("");
                    mat[f, v] = Convert.ToInt32(Console.ReadLine());
                    m += 1;
                }
            }
            TS2 = mat[0, 1] + mat[1, 1] + mat[2, 1] + mat[3, 1];
            Console.WriteLine("");
            Console.WriteLine("los gastos en la primera nomina es de: RD$" + TS1);
            Console.WriteLine("");
            Console.WriteLine("los gastos en la segund nomina es de: RD$" + TS2);
                              Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program mat = new Program();
            mat.Cargar();
        }
    }
}
