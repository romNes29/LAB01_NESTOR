using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejecutarPrograma();
        }

        public static int opcion_Ejecutar()
        {
            Console.WriteLine("***** JUEGO DE LISTAS *****\n" +
                              "1. Suma Especial.\n" +
                              "2. Ordenar Arreglos.\n" +
                              "3. Crear Triángulo de Pascal.\n" +
                              "4. Serie de Fibbonacci.\n" +
                              "5. Salir.\n");
            Console.WriteLine("Ingrese la opcion que desea ejecutar:");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public static void ejecutarPrograma()
        {
            int opcion = 0;
            while (opcion < 5)
            {
                opcion = opcion_Ejecutar();
                switch (opcion)
                {
                    case 1:
                        suma_especial();
                        break;

                    case 2:
                        Ordenar_Arreglo();
                        Console.ReadKey();
                        break;

                    case 3:
                        Triangulo_Pascal();
                        Console.ReadKey();
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        Console.WriteLine("Hasta Pronto.");
                        Console.WriteLine("Muchas gracias por utilizar nuestro sistema." +
                                           "\nPresione Cualquier tecla para salir.");
                        Console.ReadKey();
                        break;
                }
            }

        }

        public static void suma_especial()
        {
            double sumatoria = 0;
            Random value = new Random();
            string cadena_numeros = "[";
            int[] lista_numeros = new int[5];
            for(int i = 0; i < lista_numeros.Length; i++)
            {
                lista_numeros[i] = value.Next(0,10);
            }

            for (int j = 0; j < lista_numeros.Length; j++)
            {
                sumatoria += Math.Pow(lista_numeros[j], j);
            }

            for (int valores = 0; valores < lista_numeros.Length; valores++)
            {
                if (valores == lista_numeros.Length - 1) cadena_numeros += lista_numeros[valores];
                else cadena_numeros += lista_numeros[valores] + ",";
            }
            cadena_numeros += "]";
            Console.WriteLine("Arreglo: "+cadena_numeros+"\nResultado de la suma: "+sumatoria);
            Console.ReadKey();
        }

        public static void Ordenar_Arreglo()
        {
            int[] arreglo_numeros = new int[5];
            Random value = new Random();
            int respaldo_valor_izq;
            int auxiliar;
            int auxiliar_dos;
            string cadena_valores = "[";
            for (int indice = 0; indice < arreglo_numeros.Length; indice++)
            {
                if(indice == arreglo_numeros.Length - 1)
                {
                    arreglo_numeros[indice] = value.Next(0, 10);
                    cadena_valores += arreglo_numeros[indice] + "]";
                }
                else
                {
                    arreglo_numeros[indice] = value.Next(0, 10);
                    cadena_valores += arreglo_numeros[indice]+",";
                }
            }

            Console.WriteLine("Arreglo sin ordenar: "+cadena_valores);

            for (int i = 0; i < arreglo_numeros.Length - 1; i++) //Elemento izquierda
            {
                for (int j = i + 1; j < arreglo_numeros.Length; j++) //Elemento derecha
                {

                    if (arreglo_numeros[i] > arreglo_numeros[j])
                    {
                        respaldo_valor_izq = arreglo_numeros[i];
                        auxiliar = arreglo_numeros[j];
                        auxiliar_dos = respaldo_valor_izq;
                        arreglo_numeros[i] = auxiliar;
                        arreglo_numeros[j] = auxiliar_dos;
                    }
                }
            } //Cierra for ordenar

            string cadena_valores_nueva = "[";
            for (int k = 0; k < arreglo_numeros.Length; k++)
            {
                if (k == arreglo_numeros.Length - 1)
                {
                    cadena_valores_nueva += arreglo_numeros[k] + "]";
                }
                else
                {
                    cadena_valores_nueva += arreglo_numeros[k] + ",";
                }
            }
            Console.WriteLine("Arreglo ordenado: " + cadena_valores_nueva);
        }
        public static void Triangulo_Pascal()
        {
            int[,] matriz_pascal = new int[9, 16];
            matriz_pascal.GetLength(0); 
            int val = 1;
            Console.WriteLine("Triangulo de pascal.");
            for (int i = 0; i < matriz_pascal.GetLength(0); i++)
            {
                for (int k = 1; k <= matriz_pascal.GetLength(0) - i; k++)
                {
                    Console.Write(" ");
                    matriz_pascal[i, k] = 0;
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
    }//Cierra Internal Class

}//Cierra nameSpace
