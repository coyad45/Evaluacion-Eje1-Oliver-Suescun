using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Pedir dos números por consola y mostrar el resultado: 
            a.Si son iguales muestro el cuadrado del número. 
            b.Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto.
           c.si el resto es mayor a 3(tres) informar por consola.*/

            int num1;
            int num2;
            int resta;
            int resto;
            int cuadrado;

            Console.WriteLine("Ingrese dos numeros:");
            Console.Write("Numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Numero 2:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                cuadrado = num1 * num2;
                Console.WriteLine("'Debido a que los numeros son iguales se muestra el cuadrado'");
                Console.WriteLine($"Resultado del cuadrado es: {cuadrado}");
            }
            else if (num1 / num2 == 0)
            {
                resta = num1 - num2;
                Console.WriteLine("'Debido el primer numero es divisible por el segundo se muestra la resta'");
                Console.WriteLine($"Resultado de la resta es: {resta}");

            }
            else 
            {
                resto = num1/num2;
                Console.WriteLine("'Debido a que el primer numero no es divisible por el segundo se muestra el resto'");
                Console.WriteLine($"El resto es: {resto}");
                if (resto>3)
                {
                    Console.WriteLine($"El resultado del resto es mayor a 3 por {resto-3} numeros");
                }

            }
            

        }
    }
}
