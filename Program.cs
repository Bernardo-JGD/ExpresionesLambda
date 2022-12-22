using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //funcion1();
            //suma();
            //mayor();
            //listaNumerosFiltrar();
            //actionImprimir();
            //actionImprimirLista();
            actionImprimirListaDiferente();
            Console.ReadLine();
        }

        private static void funcion1()
        {
            //El doble de un número
            //<entrada, salida>
            //(parámetro)
            //=> despues de lo anterior el cuerpo de la funcion
            Func<int, int> doble = (numeroEntero) => numeroEntero * 2;
            Console.WriteLine(doble(4));//8
        }

        private static void suma()
        {
            //<entrada, entrada, salida> nombreFuncion (parametro1, parametro2)
            //=> cuerpoFuncion/operaciones/etc
            Func<int, int, int> suma = (numero1, numero2) => numero1 + numero2;
            Console.WriteLine("8 + " + " 2 = " + suma(8, 2));//10
        }

        private static void mayor()
        {
            Func<int, int, int> numeroMayor = (numero1, numero2) =>
            {
                if (numero1 > numero2) return numero1;
                else return numero2;
            };
            Console.WriteLine("Numero mayor entre 8 y 2 = " + numeroMayor(8, 2));
        }

        private static void listaNumerosFiltrar()
        {
            var numeros = new List<int> { 3, 5, 7, 4, 8, 9, 2 };
            Func<int, bool> obtenerPares = (numero) => numero % 2 == 0;
            /*Where
              En este caso "Where" actua sobre la lista "numeros"
              retornándole cada número que cumpla con la condición que la función
              "obtenerPares" tiene. 
             */
            var pares = numeros.Where(obtenerPares);
            //Puedo hacer la funcion "obtenerPares" de la siguiente manera
            //var pares = numeros.Where((numero) => numero % 2 == 0);
            Console.WriteLine("Numeros pares de la lista: 3, 5, 7, 4, 8, 9, 2");
            foreach(int par in pares)
            {
                Console.WriteLine(par);
            }
        }

        private static void actionImprimir()
        {
            var numeros = new List<int> { 3, 5, 7, 4, 8, 9, 2 };
            //Action es como un tipo void, no retorna nada
            Action<int> imprimir = (numero) => Console.WriteLine(numero);
            imprimir(5);
        }

        private static void actionImprimirLista()
        {
            var listaNumeros = new List<int> { 3, 5, 7, 4, 8, 9, 2 };
            Action<int> imprimir = (numero) => Console.WriteLine(numero);

            Action<List<int>> imprimirLista = (numeros) =>
            {
                foreach (var numero in numeros)
                {
                    imprimir(numero);
                }
            };

            imprimirLista(listaNumeros);
        }

        private static void actionImprimirListaDiferente()
        {
            var listaNumeros = new List<int> { 3, 5, 7, 4, 8, 9, 2 };
            Action<int> imprimir = (numero) => Console.WriteLine(numero);
            //Aquí no recibe tipos ni parámetros, la listaNumeros es global en este contexto
            Action imprimirLista = () =>
            {
                foreach (var numero in listaNumeros)
                {
                    imprimir(numero);
                }
            };
            //Por eso solo se llama y no recibe nada
            imprimirLista();
        }

        private static void funcionOrdenSuperior()
        {
            //<numeroEntrada, funcionEntrada, numeroRetorno>
            Func<int, Func<int, int>, int> fnOrdenSuperior = (numero, funcion) =>
            {
                if (numero > 100)
                {
                    return funcion(numero);
                }
                else
                {
                    return numero;
                }
            };
            var resultado = fnOrdenSuperior(600, numero=> numero*2);
        }

    }
}
