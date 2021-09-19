using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Una empresa de viajes le solicita ingresar que continente le gustaría visitar y la cantidad de días, la oferta dice que por día se cobra $100 , que se puede pagar de todas las maneras: 
            a.Crear un método que valide continentes: recibe un continente y retorna true si se trata de un continente válido(América, Asia, Europa, Africa, Oceanía).Crear un método que valide forma de pago: recibe la forma de pago y retorna true si se trata de una forma de pago válido(Débito, Crédito, Efectivo, Mercado Pago, Cheque, Leliq)
            b.Si es América tiene un 15 % de descuento y si además paga por débito se le agrega un 10 % más de descuento
            c.Si es África u Oceanía tiene un 30 % de descuento y si además paga por mercadoPago o efectivo se le agrega un 15 % más de descuento
            d.Si es Europa tiene un 20 % de descuento y si además paga por débito se le agrega un 15 % , por mercadoPago un 10 % y cualquier otro medio 5 % e.cualquier otro continente tiene un recargo del 20 %
              f.en cualquier continente, si paga con cheque, se recarga un 15 % de impuesto al cheque*/
            string continente;
            string pago;
            bool validacionContinente = false;
            bool validacionPago = false;
            float dia = 100;
            float estadia;
            float descuento;
            float total;

            Console.WriteLine("Por favor solo ingresar datos validos proporcionados");

            do
            {
                Console.WriteLine("Ingrese un continente de la lista:");
                Console.WriteLine("*America \n*Asia\n*Europa\n*Africa\n*Oceania");
                Console.Write("Continente:");
                continente = Console.ReadLine();               
                continente = continente.ToLower();
                continente = continente.Trim();
                Console.Clear();
              
                Console.WriteLine("A continuacion ingrese metodo de pago:");
                Console.WriteLine("*Debito \n*Credito\n*Efectivo\n*Mercado Pago\n*Cheque\n*Leliq");
                Console.Write("Metodo de pago:");
                pago = Console.ReadLine();
                pago = pago.ToLower();
                pago = pago.Trim();
                Console.Clear();

                validacionContinente = ValidacionContinente(continente);
                validacionPago = ValidacionPago(pago);

            } while (validacionContinente == false && validacionPago == false);    
                      
            Console.WriteLine("¿De cuantos dias sera su hospedaje?");
            Console.WriteLine("Costo por dia base: 100$");
            Console.Write("Dias de hospedaje:");
            estadia = int.Parse(Console.ReadLine());           
            dia = dia * estadia;
            Console.Clear();

            switch (continente)
            {

                case "america":
                    switch (pago)
                    {
                        case "debito":

                            descuento = 0.25f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            break;

                        case "credicto":
                        case "efectivo":
                        case "mercadopago":                       
                        case "leliq":

                            descuento = 0.15f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");

                            break;

                        case "cheque":
                            descuento = 0.15f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            descuento = 1.15f;
                            total = total * descuento;
                            Console.WriteLine("Debido a que el importe se abona con cheque se realiza un recargo del 15% por temas de impuestos");
                            Console.WriteLine($"Total con impuestos: {total}");


                            break;
                    }
                    break;

                case "africa":
                case "oceania":
                    switch (pago)
                    {                                                                      
                        case "efectivo":
                        case "mercadopago":
                            descuento = 0.45f;
                            descuento = dia * descuento;
                            total = dia - descuento;

                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            break;

                        case "debito":
                        case "credicto":                       
                        case "leliq":
                            descuento = 0.30f;
                            descuento = dia * descuento;
                            total = dia - descuento;

                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");

                            break;

                        case "cheque":
                            descuento = 0.30f;
                            descuento = dia * descuento;
                            total = dia - descuento;

                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");

                            descuento = 1.15f;
                            total = total * descuento;
                            Console.WriteLine("Debido a que el importe se abona con cheque se realiza un recargo del 15% por temas de impuestos");
                            Console.WriteLine($"Total con impuestos: {total}");

                            break;
                    }
                    break;
                                
                case "europa":
                    switch (pago)
                    {                      
                        case "mercadopago":
                            descuento = 0.30f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            break;

                        case "debito":
                            descuento = 0.35f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            break;

                        case "efectivo":
                        case "credicto":                      
                        case "leliq":
                            descuento = 0.25f;
                            descuento = dia * descuento;
                            total = dia - descuento;
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            break;

                        case "cheque":
                            descuento = 0.25f;
                            descuento = dia * descuento;
                            total = dia - descuento;                                                   
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El descuento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");
                            descuento = 1.15f;
                            total = total * descuento;
                            Console.WriteLine("Debido a que el importe se abona con cheque se realiza un recargo del 15% por temas de impuestos");
                            Console.WriteLine($"Total con impuestos: {total}");

                            break;
                    }
                    break;

                case "asia":
                    switch (pago)
                    {
                        case "debito":
                        case "credicto":
                        case "efectivo":
                        case "mercadopago":
                        case "leliq":
                            descuento = 0.20f;
                            descuento = dia * descuento;
                            total = dia + descuento;
                            Console.WriteLine("Este continente posee un aumento del 20%");
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El aumento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");

                            break;

                        case "cheque":
                            descuento = 0.20f;
                            descuento = dia * descuento;
                            total = dia + descuento;

                            Console.WriteLine("Este continente posee un aumento del 20%");
                            Console.WriteLine($"Total de dias de hospedaje:{estadia}");
                            Console.WriteLine($"Costo total por dias de hospedaje: {dia}");
                            Console.WriteLine($"El aumento es: {descuento}");
                            Console.WriteLine($"Total a pagar: {total}");

                            descuento = 1.15f;
                            total = total * descuento;
                            Console.WriteLine("Debido a que el importe se abona con cheque se realiza un recargo del 15% por temas de impuestos");
                            Console.WriteLine($"Total con impuestos: {total}");

                            break;
                    }
                    break;
                
            }

        }

        ////////////////////////////////////Metodos////////////////////////////////7

        //Metodo para validar continente
        static bool ValidacionContinente(string continente )
        {
            bool validacionExitosaContinente = false;
            if (continente == "america" || continente == "asia" || continente == "europa" || continente == "africa" || continente == "oceania" )
            {
                validacionExitosaContinente = true;
            }
            return validacionExitosaContinente;
        }

        //Metodo para validar pago
        static bool ValidacionPago(string pago)
        {
            bool validacionExitosaPago = false;
            if (pago == "debito" || pago == "credicto" || pago == "efectivo" || pago == "mercadopago" || pago == "cheque" || pago == "leliq")
            {
                validacionExitosaPago = true;
            }
            return validacionExitosaPago;
        }

    }
}
