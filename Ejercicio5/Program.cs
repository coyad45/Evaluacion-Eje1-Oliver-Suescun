using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.Realizar el algoritmo que permita ingresar el nombre de un estudiante, la edad(validar) , el sexo(validar) y la nota del final(validar) hasta que el usuario quiera e informar al terminar el ingreso por consola:
            a.La cantidad de varones aprobados
            b.El promedio de notas de los menores de edad
            c.El promediodenotasde losadolescentes.d.El promedio de notas de los mayores e. El promedio de notas por sexo.
            */

            int[] edad = new int [50];
            int[] notaF =new int[50];
            string[] sexo = new string[50];

            bool validacionSexo = false;
            bool validacionEdad = false;
            bool validacionNf = false;

            int contador = 1;
            int contadorVA = 0;
            int promedioM = 0;
            int contadorProM = 0;
            int promedioA = 0;
            int contadorProMA = 0;
            int contadorMY = 0;
            int promedioMY = 0;
            int promedioVar = 0;
            int contadorVar = 0;
            int promedioHem = 0;
            int contadorHem = 0;


            Console.WriteLine("             !Bienvenido al sistema de gestion de notas de la UBA");
            Console.WriteLine("A continuacion se le solicitaran los datos de los estudiantes");
            Console.WriteLine("     *Recuerde ingresar la nota de los estudiantes entre 0 a 10");
            Console.WriteLine("     *Tambien se debe informa el sexo de los estudiantes: Hembra o Varon ");
            Console.WriteLine("     *En caso de querer detener el programa ingrese la letra x en sexo, -1 edad y nota final -1 ");
            Console.WriteLine("Presione enter para empezar...");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < notaF.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Estudian Numero {contador}");
                    Console.WriteLine("Ingrese su sexo:");
                    Console.WriteLine("*Hembra \n*Varon ");
                    Console.Write("Sexo:");
                    sexo[i] = Console.ReadLine();
                    sexo[i] = sexo[i].ToLower();
                    sexo[i] = sexo[i].Trim();
                    Console.Clear();

                    Console.WriteLine($"Estudian Numero {contador}");
                    Console.WriteLine("Ingrese su edad:");
                    Console.Write("Edad:");
                    edad[i] = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine($"Estudian Numero {contador}");
                    Console.WriteLine("Ingrese su nota final:");
                    Console.Write("nota final:");
                    notaF[i] = int.Parse(Console.ReadLine());
                    Console.Clear();

                    validacionSexo = ValidacionSexo(sexo[i]);
                    validacionEdad = ValidacionEdad(edad[i]);
                    validacionNf = ValidacionNf(notaF[i]);
                } while (validacionSexo == false && validacionEdad == false && validacionNf == false);

                

                
                if (validacionSexo == true && validacionEdad == true && validacionNf == true)
                {
                    contador++;
                    validacionSexo = false;
                    validacionEdad = false;
                    validacionNf = false;

                    if (sexo[i] == "varon")
                    {
                        promedioVar = promedioVar + notaF[i];
                        contadorVar++;

                        if (notaF[i] > 4)
                        {
                            contadorVA++;
                        }
                        if (edad[i]>0)
                        {
                            if (edad[i] < 13)
                            {
                                promedioM = promedioM + notaF[i];
                                contadorProM++;

                            }
                            else if (edad[i] > 12 && edad[i] < 18)
                            {
                                promedioA = promedioA + notaF[i];
                                contadorProMA++;
                            }
                            else
                            {

                                promedioMY = promedioMY + notaF[i];
                                contadorMY++;
                            }
                        }
                                                                      
                        

                    }
                    else if (sexo[i] == "hembra")
                    {
                        promedioHem = promedioHem + notaF[i];
                        contadorHem++;
                        if (edad[i] < 13)
                        {
                            promedioM = promedioM + notaF[i];
                            contadorProM++;
                        }
                        else if (edad[i] > 12 && edad[i] < 18)
                        {
                            promedioA = promedioA + notaF[i];
                            contadorProMA++;
                        }
                        else 
                        {

                            promedioMY = promedioMY + notaF[i];
                            contadorMY++;
                        }
                    }
        

                }
                else if (sexo[i] == "x" && edad[i] == -1 && notaF[i] == -1)
                {
                    
                    break;
                }


                
            }
            
            if (contadorVA>0)
            {
                Console.WriteLine($"La cantidad de varones aprobados es: {contadorVA}");
            }
            
            if (promedioMY>0)
            {
                promedioMY = promedioMY / contadorMY;
                Console.WriteLine($"El promedio para los mayores de edad es: {promedioMY}");
            }
            if (promedioA>0)
            {
                promedioA = promedioA / contadorProMA;
                Console.WriteLine($"El promedio para los menores de edad es: {promedioA}");
            }
            if (promedioM>0)
            {
                promedioM = promedioM / contadorProM;
                Console.WriteLine($"El promedio para los menores de edad es: {promedioM}");
            }

            Console.WriteLine("El promedio por sexo es:");
            if (contadorVar>0)
            {
                promedioVar = promedioVar / contadorVar;
                Console.WriteLine($"Para los varones: {promedioVar}");

               

            }

            if (contadorHem> 0)
            {
                {
                    promedioHem = promedioHem / contadorVar;
                    Console.WriteLine($"Para las hembras: {promedioHem}");



                }
            }







        }


        //Metodo para validar continente
        static bool ValidacionEdad(int edad)
        {
            bool validacionExitosaEdad = false;
            if (edad <=13 || edad > 13 )
            {
                validacionExitosaEdad = true;
            }
            return validacionExitosaEdad;
        }

        //Metodo para validar pago
        static bool ValidacionSexo(string sexo)
        {
            bool validacionExitosaSexo = false;
            if (sexo == "hembra" || sexo == "varon"  )
            {
                validacionExitosaSexo = true;
            }
            return validacionExitosaSexo;
        }
        static bool ValidacionNf(int notaF)
        {
            bool validacionExitosaNf = false;
            if (notaF >0 && notaF < 10)
            {
                validacionExitosaNf = true;
            }
            return validacionExitosaNf;
        }
    }
}
