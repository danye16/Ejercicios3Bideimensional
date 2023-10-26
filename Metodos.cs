using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3Bideimensional
{
    internal class Metodos
    {
        //Declara y crea una matriz bidimensional de enteros de tamaño 3x3. Llena la matriz con valores enteros del 1 al 9 e imprime la matriz en la consola.

        public void Ejercicio1()
        {
            int[,] matrizBi = new int[3, 3] { { 4, 5, 6 }, { 7, 9, 7 }, { 3, 7, 2 } };

            for (int fila=0; fila<matrizBi.GetLength(0);fila++)
            {
                for(int columna=0; columna<matrizBi.GetLength(1); columna++) 
                {
                    Console.Write(matrizBi[fila, columna] );
                }
                Console.WriteLine();

            }
        }

        //Declara y crea una matriz bidimensional de cadenas de tamaño 2x2.
        //Llena la matriz con nombres de colores ("Rojo", "Verde", "Azul", "Amarillo") e imprime la matriz en la consola.

        public void Ejercicio2()
        {
            string[,] matrizBi = new string[2, 2] { { "Rojo", "Verde"}, { "Azul", "Amarillo" } };

            for (int fila = 0; fila < matrizBi.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizBi.GetLength(1); columna++)
                {
                    Console.Write(matrizBi[fila, columna]+" ");
                }
                Console.WriteLine();

            }
        }

        //Declara y crea una matriz bidimensional de números reales (doubles) de tamaño 4x3.
        //Llena la matriz con valores decimales y luego calcula y muestra la suma de todos los elementos de la matriz.

        public void Ejercicio3()
        {
            double[,] matrizBi = new double[4, 3] { { 4.2, 5.1, 6.7 }, { 7.2, 9.1, 7.1 }, { 3.1, 7.1, 2.1 }, { 3.2, 7.2, 2.2 } };
            double total=0;
            for (int fila = 0; fila < matrizBi.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizBi.GetLength(1); columna++)
                {
                    total += matrizBi[fila, columna];
                }
                Console.WriteLine();

            }
            Console.WriteLine("Su total es "+total);
        }
        //Declara y crea una matriz bidimensional de caracteres de tamaño 2x4.
        //Llena la matriz con caracteres alfabéticos y luego imprime la matriz en forma de tabla.

        public void Ejercicio4()
        {
            char[,] matrizBi = new char[2, 4] { { 'A', 'C','M', 'U'}, { 'N', 'P', 'S', 'I'} };

            for (int fila = 0; fila < matrizBi.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizBi.GetLength(1); columna++)
                {
                    Console.Write(matrizBi[fila, columna] + " ");
                }
                Console.WriteLine();

            }
        }


    }

}
