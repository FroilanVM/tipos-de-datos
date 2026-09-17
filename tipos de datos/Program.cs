using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_datos
{
    internal class Program
    {
      

        static void Main(string[] args, string num2)
        {
            Console.WriteLine("hola mundo");
            Console.WriteLine("suma: " + (4 + 5));
            Console.WriteLine("division: " + (10 / 5));
            Console.WriteLine("resta: " + (20-12));
            Console.WriteLine("multiplicación: " + (3*8));

            //Tipos de datos
            int num1 = 0;
            float flotante = 3.14f;
            double doble = 3.14159265359;
            decimal decimal1 = 3.14159265359m;
            string cadena = "hola mundo";
            string nombre = "Froilan";
            string apellido = "Vargas";
            int edad, contador, parametro;
            Boolean boleano = true;
            const int iva = 13;
            char caracter = 'A';

            var variable = true;
            //Variable = 20

            dynamic dinamico = 20;
            dinamico = "hola mundo";
            dinamico = 3.14f;
            dinamico = true;
            dinamico = 'A';


            Console.WriteLine(num1);
           

            Console.WriteLine(num1);
            Console.WriteLine(dinamico);
            Console.WriteLine("la suma de " + num1 + " + " + num2 + " es " + (num1 + num2)); //concatenando


        }
    }
}
