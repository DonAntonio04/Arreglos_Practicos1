using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Practicos1
{
    internal class Arreglos
    {
        //Creamos nuestro array unidimensional de un tamaño de 5

        int[] numeros = new int[5];



        public void Metedo()
        {
            //Ingresamos los valores de manera manual

            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 3;
            //numeros[3] = 4;
            //numeros[4] = 5;

            ////Mostramos los valores de nuestro array

            //    Console.WriteLine("Los valores de nuestro array");

            //Console.WriteLine("El valor de elemento 0 es " + numeros[0]);
            //Console.WriteLine("El valor de elemento 1 es " + numeros[1]);
            //Console.WriteLine("El valor de elemento 2 es " + numeros[2]);
            //Console.WriteLine("El valor de elemento 3 es " + numeros[3]);
            //Console.WriteLine("El valor de elemento 4 es " + numeros[4]);

            //Console.ReadKey();

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"ingrese el valor del elemento {i} : ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"El valor de los elementos {i} es  {numeros[i]} ");
            }

        }

        int[] misArreglos = new int[10];
        int suma = 0;
        public void Metodo2()
        {
            misArreglos[0] = 10;
            misArreglos[1] = 20;
            misArreglos[2] = 30;
            misArreglos[3] = 40;
            misArreglos[4] = 50;
            misArreglos[5] = 60;
            misArreglos[6] = 70;
            misArreglos[7] = 80;
            misArreglos[8] = 90;
            misArreglos[9] = 100;

            //Calculo la suma de los valores de mi arreglo
            int suma = 0;

            for (int i = 0; i < misArreglos.Length; i++)
            {
                suma += misArreglos[i];
            }
             // calculo la media dividiendo la suma entre el número de  elementos 
            double media = (double)(suma) / misArreglos.Length;

            Console.WriteLine($"La media de mi mi arreglo es : " + media);
        }

        
        static void LlenarArregloConMultiplos(int[] arreglo, int numero)
        {
            // Este bucle recorre el arreglo y llena cada elemento con los múltiplos del número ingresado.

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = (i + 1) * numero;
            }
        }
        static void MostrarArreglo(int[] arreglo)
        {
            // Este bucle recorre el arreglo nuevamente para mostrar cada elemento en la consola.

            Console.WriteLine("Elementos del arreglo:");
            foreach (int elemento in arreglo)
            {
                Console.WriteLine(elemento + " ");
            }
        }

        public void Metodo3()
        {
            Console.WriteLine("Ingrese el tamaño del arreglo: ");
            int tamanoArreglo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número para generar múltiplos: ");
            int numero = int.Parse(Console.ReadLine());

            // Crear el arreglo con el tamaño especificado
            int[] miArreglo = new int[tamanoArreglo];

            // Llenar el arreglo con los múltiplos del número
            LlenarArregloConMultiplos(miArreglo, numero);

            // Mostrar los elementos del arreglo
            MostrarArreglo(miArreglo);
        }

        public void Metodo4()
        {
            Console.WriteLine("Ingrese el número de nombres que deseas almacenar ");
            int numeroNombres = int.Parse(Console.ReadLine());

            string[] nombres = new string[numeroNombres];
            int[] longitud = new int[numeroNombres];

            //Llenar el arreglo con los nombres

            for (int i = 0;  i < numeroNombres; i++)
            {
           
                Console.WriteLine($"ingrese el nombre {i + 1} : ");
                nombres[i] = Console.ReadLine();
            }

            //Calcular la longitud del nombre y almacenarla en el arrglo
            for(int i = 0;i < numeroNombres;i++)
            {
                longitud[i] = nombres[i].Length;
            }

            Console.WriteLine("Ingrese el nombres y su longitud");
            for(int i = 0; i < numeroNombres;i++)
            {
                Console.WriteLine($"Nombres : {nombres[i]} y su longitud es : {longitud[i]}");
            }
        }
    }
}
