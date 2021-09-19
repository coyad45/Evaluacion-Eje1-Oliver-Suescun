using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 4.Realizar el algoritmo que permita iterar el ingreso de dos datos de un vehiculo, un color(rojo verde o amarillo) y un valor entre 0 y 10000 hasta que el usuario quiera e informar al terminar el ingreso por consola:
            a.La cantidad de rojos
            b.La cantidad de rojos con precio mayor a 5000
            c.La cantidad de vehículos con precio inferior a 5000
            d.El promedio de todos los vehículos ingresados.
           e.El más caro y su color. */
            string[] color = new string[50];
            int[] precio = new int[50];
            int contadorC = 1;
            int contadorP = 1;
            int contadorR = 0;
            int contadorRM = 0;
            int contadorPI = 0;
            int promedio = 0;
            int numerador = 0;

            Console.WriteLine("             !Bienvenido al sistema de gestion de compras de Empire Cars¡");
            Console.WriteLine("A continuacion se le solicitaran los datos de sus Productos");
            Console.WriteLine("     *Recuerde ingresar el precio de los vechiculo entre 1 a 500 Kilos");
            Console.WriteLine("     *Tambien se le informa los sabores Disponibles: Carne, Vegetales, Pollo");
            Console.WriteLine("     *En caso de querer detener el programa ingrese la letra p en color y -1 en el precio ");
            Console.WriteLine("Presione enter para empezar...");
            Console.ReadKey();
            Console.Clear();


            for (int i = 0; i < precio.Length; i++)
            {

                Console.WriteLine($"Ingrese el peso para el vehiculo {contadorP}: ");
                Console.WriteLine("Precio entre 0 a 10000");
                Console.Write("Precio: ");
                precio[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese el color del vehiculo {contadorC}: ");
                Console.WriteLine("Colores disponibles: rojo, verde, amarillo");
                Console.Write("Color: ");
                color[i] = Console.ReadLine();
                color[i] = color[i].Trim();
                color[i] = color[i].ToLower();

                if (precio[i] == -1 || color[i] == "p")
                {
                    for (int j = 0; j < precio.Length - 1; j++)
                    {
                        for (int e = j + 1; e < precio.Length; e++)
                        {
                            if (precio[j] < precio[e])
                            {
                                int precioC = precio[j];
                                precio[j] = precio[e];
                                precio[e] = precioC;

                                string colorC = color[j];
                                color[j] = color[e];
                                color[e] = colorC;

                            }
                        }
                    }

                    if (contadorR > 0)
                    {
                        Console.WriteLine($"La cantidad de vehiculos rojos es: {contadorR}");
                    }
                    else if (contadorRM > 0)
                    {
                        Console.WriteLine($"La cantidad de vehiculos rojos con precio mayor a 5000 es: {contadorRM}");

                    }
                    Console.WriteLine($"La cantidad de vehiculos con precio inferior a 5000 es: {contadorPI}");
                    Console.WriteLine($"El promedio de todos los vehiculos ingresados es: {promedio / numerador}");
                    for (int e = 0; e < 1; e++)
                    {
                        Console.WriteLine($"El vehiculo mas caro es: {color[e]} y su precio es de: {precio[e]}");
                    }
                    break;


                }
                else if (color[i] == "rojo" || color[i] == "verde" || color[i] == "amarillo" && precio[i] > 0)
                {

                    contadorP++;
                    contadorC++;
                    numerador++;
                    promedio = promedio + precio[i];


                    if (color[i] == "rojo")
                    {
                        contadorR++;

                        if (color[i] == "rojo" && precio[i] > 5000)
                        {
                            contadorRM++;
                        }
                    }
                    else if (precio[i] > 0 && precio[i] < 5000)
                    {
                        contadorPI++;
                    }

                }
                Console.Clear();







            }


        }
    }
}
