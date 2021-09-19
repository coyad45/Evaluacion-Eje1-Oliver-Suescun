using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.Realizar el algoritmo que permita el ingreso de 10 bolsas de alimento para mascotas, con los kilos(validar entre 0 y 500) , sabor validar(carne vegetales pollo) e informar por consola: 
            a.El promedio de los kilos totales. 
            b.La bolsa más liviana y su sabor
            c.La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne*/
            int[] kilos = new int[10];
            string[] sabor = new string[10];
            int contadorK = 1;
            int contadorS = 1;
            bool validador = false;
            int cantidadC = 0;
            int promedioC = 0;
            int promedio = 0;

            Console.WriteLine("             !Bienvenido al sistema de gestion de compras de World Dog¡");
            Console.WriteLine("A continuacion se le solicitaran los datos de sus Productos");
            Console.WriteLine("     *Recuerde ingresar el peso de las bolsas entre 1 a 500 Kilos");
            Console.WriteLine("     *Tambien se le informa los sabores Disponibles: Carne, Vegetales, Pollo");
            Console.WriteLine("     *En caso de alguna error en los productos se le solicitaran nuevamente");
            Console.WriteLine("Presione enter para empezar...");

            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < kilos.Length; i++)
            {

               
                do
                {
                    
                    Console.WriteLine($"Ingrese el peso para la bolsa {contadorK}: ");
                    Console.WriteLine("Entre 0 a 500Kilos");
                    Console.Write("Peso: ");
                    kilos[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Ingrese el sabor para la bolsa {contadorS}: ");
                    Console.WriteLine("Sabores Disponibles: Carne, Vegetales, Pollo");
                    Console.Write("Sabor: ");
                    sabor[i] = Console.ReadLine();
                    sabor[i] = sabor[i].Trim();
                    sabor[i] = sabor[i].ToLower();


                    if (kilos[i] > 0 && kilos[i] <= 500 && sabor[i] == "carne" || sabor[i] == "pollo" || sabor[i] == "vegetales")
                    {
                        validador = true;
                        contadorK++;
                        contadorS++;
                        Console.Clear();
                        promedio = kilos[i] + promedio;

                        if (sabor[i] == "carne")
                        {
                            
                            cantidadC++;
                            promedioC = kilos[i] + promedioC;
                        }
                    }

                    else 
                    {                                            
                        validador = false;
                        Console.Clear();
                        Console.WriteLine("!Error en dato ingresado¡");
                    }

                } while (validador == false);

            }


            for (int j = 0; j < kilos.Length - 1; j++)
            {
                for (int e = j + 1; e < kilos.Length; e++)
                {
                    if (kilos[j] > kilos[e])
                    {
                        int kilosL = kilos[j];
                        kilos[j] = kilos[e];
                        kilos[e] = kilosL;

                        string bolsaN = sabor[j];
                        sabor[j] = sabor[e];
                        sabor[e] = bolsaN;

                    }
                }
            }

            Console.WriteLine($"El total de la suma de los pesos es: {promedio}");
            promedio = promedio / 10;
            Console.WriteLine($"El promedio de los kilos totales es: {promedio}");
            if (cantidadC>0)
            {
                Console.WriteLine($"La cantidad de bolsas de carne ingresadas es: {cantidadC}");
                Console.WriteLine($"El peso total de las bolsas de carne es: {promedioC}");
                Console.WriteLine($"El promedio total de kilos de carne es: {promedioC/cantidadC}");
                
            }
            else if (cantidadC == 0)
            {
                Console.WriteLine("!No se ingreso productos con sabor a carne¡");
            }

            for (int e = 0; e < 1; e++)
            {
                Console.WriteLine($"la bolsa mas liviana es: {sabor[e]} y su peso es de: {kilos[e]}");
            }



        }
    }
}
