using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Problema_2_Tema_1
{
    class Program
    {
        private int[] Salarios;

        public void Cargar()
        {
            Salarios = new int[6];
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine("Salario del primer operario " + x + ":");
                Salarios[x] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Todos los salarios de Personal: ");
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine("[" + Salarios[x] + "]");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program sal = new Program();
            sal.Cargar();
            sal.Imprimir();

        }
    }
}
