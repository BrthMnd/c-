using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ProyectV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {

                Console.Write(@"¡¡¡MENU DE OPCIONES!!!
OPTION -> 0 == SALIR DEL MENU!!!
OPCION -> 1 == Un proveedor de computadores ofrece descuento del 10%, si cuesta
               $1.000.000 o más. Determinar cuánto pagará, con IVA incluido (19%), un
               cliente si la compra cumple con esta condición.
OPXION -> 2 == En un almacén se hace un 20% de descuento a los clientes cuya compra sea
               superior a $100.000. ¿Cuánto deberá pagar cada cliente?
OPCION -> 3 == Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto
               es superior a $2.000.000, debe hacerse una retención del 10%.
OPTION -> 4 == Un hombre desea saber cuánto dinero se genera por concepto de intereses
               sobre la cantidad que tiene en inversión en el banco. El decidirá reinvertir los
               intereses siempre y cuando no excedan a $7000, y en ese caso desea saber
               cuánto dinero tendrá finalmente en su cuenta.
OPTION -> 5 == Un proveedor de computadores ofrece descuento del 10%, si cuesta
               $1.000.000 o más. Determinar cuánto pagará, con IVA incluido (19%), un
               cliente cualquiera por la compra de una computadora.
OPTION -> 11 == Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea
                saber cuántas calorías consume su cuerpo durante el tiempo que realice una
                misma actividad. Las actividades que puede realizar son únicamente dormir o
                estar sentado. Los datos que tiene son que estando dormido consume 1.08
                calorías por minuto y estando sentado en reposo consume 1.66 calorías por
                minuto.
OPTION -> 12 == Una empresa desea hacer una compra de varias piezas de la misma clase a
                una fábrica. La empresa, dependiendo del valor de la compra, decidirá la
                forma en que le pagará al fabricante. Si el valor de la compra excede o es
                igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos
                propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el
                resto lo pagará solicitando un crédito al fabricante. Si el monto total de la
                compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar
                con recursos propios un 70% y el 30% restante, lo pagará solicitando un
                crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad
                que le pague a crédito.
OPTION -> 13 == Elaborar un algoritmo que permita calcular el valor total a pagar en una
                papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán
                $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por
                cada uno.
OPTION -> 14 == Una constructora ofrece vivienda de interés social, bajo las siguientes
                condiciones: Si los ingresos del comprador son iguales o superiores a
                $1.200.000, la cuota inicial será del 15% del valor de la vivienda y el resto, se
                distribuirá en 120 cuotas mensuales con un interés del 2% mensual. Si los
                ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del
                30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales
                con un interés del 1% mensual. La constructora desea saber cuánto debe
                pagar un comprador por concepto de cuota inicial y cuánto por cada cuota
                mensual.
OPTION -> 15 == En un almacén se hace un 17% de descuento a los clientes cuya compra sea
                superior a $200.000, para las compras inferiores, el descuento será del 5%.
                ¿Cuánto deberá pagar cada cliente?
OPTION -> 16 == Realizar un programa que nos pida un número n, y nos diga cuantos
                números hay entre 1 y n que son primos.
OPTION -> 17 == Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
OPTION -> 18 == Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56
                mostrar: cincuenta y seis. Pista: separar las unidades y las decenas.
                (unidades = num % 10; decenas = num / 10).
OPTION -> 19 == Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar
                por consola si se trata de un vocal o una consonante. " + "\n");
                Console.Write("OPTION --> ");
                option = int.Parse(System.Console.ReadLine());

                switch (option)
                {
                    case 11:
                        {
                            int peso = 70;
                            int tiempo = 60;
                            double caloriasDormido = 1.08;
                            double caloriasSentado = 1.66;

                            double caloriasQuemadasDormido = peso * caloriasDormido * tiempo;
                            Console.WriteLine("Calorías quemadas estando dormido: " + caloriasQuemadasDormido);

                            double caloriasQuemadasSentado = peso * caloriasSentado * tiempo;
                            Console.WriteLine("Calorías quemadas estando sentado: " + caloriasQuemadasSentado);

                            System.Console.ReadLine();
                            break;
                        }
                    case 12:

                        {
                            Console.Write("Cual sera el valor a ingresar: ");
                            double valorCompra = double.Parse(System.Console.ReadLine());
                            if (valorCompra >= 5000000)
                            {
                                double pagoRecursosPropios = valorCompra * 0.55;
                                double prestamoBancario = valorCompra * 0.3;
                                double pagoCreditoFabricante = valorCompra - pagoRecursosPropios - prestamoBancario;
                                double interesFabricante = pagoCreditoFabricante * 0.15;
                                double pagoTotalFabricante = pagoCreditoFabricante + interesFabricante;

                                Console.WriteLine("Pago con recursos propios: " + pagoRecursosPropios);
                                Console.WriteLine("Prestamo bancario: " + prestamoBancario);
                                Console.WriteLine("Pago a crédito al fabricante: " + pagoCreditoFabricante);
                                Console.WriteLine("Interés del fabricante: " + interesFabricante);
                                Console.WriteLine("Pago total al fabricante: " + pagoTotalFabricante);
                            }
                            else
                            {
                                double pagoRecursosPropios = valorCompra * 0.7;
                                double pagoCreditoFabricante = valorCompra - pagoRecursosPropios;
                                double interesFabricante = pagoCreditoFabricante * 0.15;
                                double pagoTotalFabricante = pagoCreditoFabricante + interesFabricante;

                                Console.WriteLine("Pago con recursos propios: " + pagoRecursosPropios);
                                Console.WriteLine("Pago a crédito al fabricante: " + pagoCreditoFabricante);
                                Console.WriteLine("Interés del fabricante: " + interesFabricante);
                                Console.WriteLine("Pago total al fabricante: " + pagoTotalFabricante);
                            }

                            Console.ReadLine();

                            break;

                        }
                    case 13:
                        {
                            int cuaderno;
                            int cuadernoCantidad;
                            int totalPrecio;

                            Console.WriteLine("Cuantos Cuadernos va a llevar?");
                            cuadernoCantidad = int.Parse(Console.ReadLine());

                            if (cuadernoCantidad >= 5)
                            {
                                cuaderno = 2000;

                                totalPrecio = cuaderno * cuadernoCantidad;

                                Console.WriteLine("se quiere llevar: " + cuadernoCantidad + " de cuadernos con un precio de " + cuaderno + "\n" +
                                    "Gracias al descuento de llevate 5 o mas y 500 de descuento \n" +
                                    "El total de cuaderno es: " + totalPrecio);
                            }
                            else
                            {
                                cuaderno = 2500;

                                totalPrecio = cuaderno * cuadernoCantidad;
                                Console.WriteLine("se quiere llevar: " + cuadernoCantidad + " de cuadernos con un precio de " + cuaderno + "\n" +
                                    "Sin el descuento de llevate 5 o mas y 500 de descuento \n" +
                                    "El total de cuaderno es: " + totalPrecio);


                            }

                            Console.WriteLine("MENU EN: ");
                            for (int i = 10; i > 0; i--)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i);

                            }


                            break;
                        }
                    case 14:

                        {
                            double ingresos = 1300000;
                            double valorVivienda = 100000000;
                            double cuotaInicial, valorCuotaMensual;

                            if (ingresos >= 1200000)
                            {
                                cuotaInicial = 0.15 * valorVivienda;
                                valorCuotaMensual = (0.02 * valorVivienda) / (1 - Math.Pow(1 + 0.02, -120));
                            }
                            else
                            {
                                cuotaInicial = 0.30 * valorVivienda;
                                valorCuotaMensual = (0.01 * valorVivienda) / (1 - Math.Pow(1 + 0.01, -84));
                            }
                            Console.WriteLine("Cuota inicial: " + cuotaInicial.ToString("C"));
                            Console.WriteLine("Valor de la cuota mensual: " + valorCuotaMensual.ToString("C"));

                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine("OPTION 15");
                            double descuentoAlto = 0.17;
                            double descuentoBajo = 0.05;
                            double porcentaje;

                            Console.Write("Compra de: ");
                            int compra = int.Parse(System.Console.ReadLine());

                            if (compra >= 200000)
                            {
                                porcentaje = compra * descuentoAlto;
                            }
                            else
                            {
                                porcentaje = compra * descuentoBajo;

                            }
                            double valorFinal = compra - porcentaje;


                            Console.WriteLine("Descuento: $" + porcentaje);
                            Console.WriteLine("Valor final a pagar: $" + valorFinal);
                            System.Console.ReadLine();

                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine("Ingrese un número n:");
                            int n = int.Parse(System.Console.ReadLine());

                            int contador = 0;
                            for (int i = 1; i <= n; i++)
                            {
                                if (EsPrimo(i))
                                {
                                    contador++;
                                }
                            }

                            Console.WriteLine("Hay " + contador + " números primos entre 1 y " + n);

                            // Función para verificar si un número es primo
                            bool EsPrimo(int numero)
                            {
                                if (numero <= 1)
                                {
                                    return false;
                                }
                                for (int i = 2; i <= Math.Sqrt(numero); i++)
                                {
                                    if (numero % i == 0)
                                    {
                                        return false;
                                    }
                                }
                                return true;
                            }

                            System.Console.ReadLine();
                            break;
                        }
                    case 17:
                        {
                            Console.Write("Ingrese la cantidad de sueldos a ingresar: ");
                            int n = int.Parse(Console.ReadLine());

                            double[] sueldos = new double[n];

                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Ingrese el sueldo {0}: ", i + 1);
                                sueldos[i] = double.Parse(Console.ReadLine());
                            }

                            double maxSueldo = sueldos[0];

                            for (int i = 1; i < n; i++)
                            {
                                if (sueldos[i] > maxSueldo)
                                {
                                    maxSueldo = sueldos[i];
                                }
                            }

                            Console.WriteLine("El sueldo máximo es: {0}", maxSueldo);
                            System.Console.ReadLine();
                            break;
                        }
                    case 18:
                        {
                            string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
                            string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
                            string[] decenas = { "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

                            Console.Write("Ingrese un número de 0 a 99: ");
                            int num = int.Parse(Console.ReadLine());

                            if (num < 0 || num > 99)
                            {
                                Console.WriteLine("Número inválido");
                            }
                            else if (num < 10)
                            {
                                Console.WriteLine(unidades[num]);
                            }
                            else if (num < 20)
                            {
                                Console.WriteLine(especiales[num - 10]);
                            }
                            else
                            {
                                int unidad = num % 10;
                                int decena = num / 10 - 2;

                                if (unidad == 0)
                                {
                                    Console.WriteLine(decenas[decena]);
                                }
                                else
                                {
                                    Console.WriteLine("{0} y {1}", decenas[decena], unidades[unidad]);
                                }
                            }
                            Console.ReadLine();
                            break;
                        }
                    case 19:
                        {
                            Console.Write("Ingrese una letra: ");
                            char letra = char.Parse(Console.ReadLine().ToLower());

                            if (letra >= 'a' && letra <= 'z')
                            {
                                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                                {
                                    Console.WriteLine("La letra ingresada es una vocal");
                                }
                                else
                                {
                                    Console.WriteLine("La letra ingresada es una consonante");
                                }
                            }
                            else
                            {
                                Console.WriteLine("La entrada no es una letra válida");
                            }
                            Console.ReadLine();
                            break;
                        }
                }

            } while (option != 0);
        }
    }
}