using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos 
            int a, b, suma; //declarar una variable tipo entero 
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1}={2}", a, b, suma);
            Console.WriteLine();


            //tipo de dato: numero en coma flotante
            float sueldo, egreso, total;
            Console.Write("Ingrese el sueldo de trabajador : ");
            sueldo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese los gasto de trabajador : ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;

            Console.WriteLine("El liquido del trabajador es : {0}", total);

            //tipo de dato flotante de doble presicion
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato dpuble: {0}", x1);
            Console.WriteLine();

            //tipo de dato: cadena de caracteres 
            string nombre;
            Console.WriteLine("Nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine(" Hola " + nombre + " ,bienvenido al curso de programacion");
            Console.WriteLine();

            //tipo booleano (tipo logico que toma valores de verdadero o falso)
            bool sw;
            sw = a + 50 > b;
            Console.WriteLine("El valor del booleano : {0}", sw);
            Console.WriteLine();

            //Pilares fundamentales de la programacion estructurada
            //ejecucion de sentencias secuenciales
            //uso de estructuras repetitivas
            //uso estructuras selectivas
            saludos(nombre);
            Console.WriteLine();
            saludos("Saoco");
            Console.WriteLine();
            saludos("La chill");

            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuelve valor");
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(500, 300));
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(400, 100));
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(10000, 596));
            Console.WriteLine();

            figura();

            Console.WriteLine("El cuadrado de 8 es : {0}", cuadrado(8));
            Console.WriteLine();

            int n;
            Console.WriteLine("Ingresa un numero para verificar si es muy alto o muy bajo : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            condicion(n);
            Console.WriteLine();

            tabla();

            Console.WriteLine();
            //tarea ejercicio 2
            Console.WriteLine("tabla de multiplicar");
            tablaTarea(6);
            Console.WriteLine();
            Console.WriteLine("tabla de multiplicar");
            tablaTarea(5);

            Console.ReadKey();
            //fin del main
        }

        //funciones : subprocesos - subprogramas - subrutinas
        //dividir el codigo en modulos
        //podemos reutilizar el codigo 
        //tipo: decuelven valores - no devuelven valores 

        static void saludos(string nombre) //parametro - argumentos
        {
            Console.WriteLine("Funcion que no devuelve valores...");
            Console.WriteLine("HOLA {0}", nombre);
        }

        //funcion que devuelve valores
        //la funcion devuelve un tipo de dato
        static int calcularSueldo(int ingreso, int egreso)
        {

            return (ingreso - egreso);
        }

        //funcione que imprima la siguiente figura
        //     *
        //    ***
        //   *****
        //  *******

        static void figura()
        {
            Console.WriteLine("    *   ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****   ");
            Console.WriteLine(" *******   ");
        }

        //crear la funcion que recibe un valor y devuelva el cuadrado del entero

        static int cuadrado(int numero)
        {
            return (numero * numero);

        }

        //funcion con condicion
        static void condicion(int n)
        {
            if (n > 100)
            {
                Console.WriteLine("El numero que eligio es muy alto");
            }
            else
            {
                Console.WriteLine("El numero que eligio es muy bajo");
            }
        }

        //Funcion con un bucle
        static void tabla()
        {
             int num = 8;
             int su = 0;   
            Console.WriteLine("La tabla del 8 es");
            for(int a=1;a<=13;a++) 
            {
                
                su = num * a;
                Console.WriteLine("Los numeros de la tabla del 8 es : {0}", su);
            }
        }

        //tarea 2
        static void tablaTarea(int n)
        {
            for(int i=1; i<=12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, (n * i));
            }
        }
    }
}
