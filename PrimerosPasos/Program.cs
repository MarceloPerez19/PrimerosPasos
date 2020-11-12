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

            //tipo de dato: cadena de caracteres 
            string nombre;
            Console.WriteLine("Nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine(" Hola " + nombre + " ,bienvenido al curso de programacion");

            //tipo booleano (tipo logico que toma valores de verdadero o falso)
            bool sw;
            sw = a+50 > b;
            Console.WriteLine("El valor del booleano : {0}", sw);

            //Pilares fundamentales de la programacion estructurada
            //ejecucion de sentencias secuenciales
            //uso de estructuras repetitivas
            //uso estructuras selectivas
            saludos(nombre);
            saludos("Saoco");
            saludos("La chill");

            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuelve valor");
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(500, 300));
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(400, 100));
            Console.WriteLine("Liquido a recibir para Saoco {0}", calcularSueldo(10000, 596));

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

            return (ingreso-egreso);
        }


    }
}
