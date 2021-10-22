
//Author: Lisandra Rufino

using System;
using System.Collections.Generic;
using System.Linq;

namespace Blastoff
{
    class Program
    {
       
        static void Main(string[] args)
        {

            // Exercicio 1
            //Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.


            /* int i,j,k,x,y;
               int media = ((i + j + k + x + y) / 5);

               Console.WriteLine("Digite a idade de i:");
            	  i= int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a idade de j:");
           	  j= int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a idade de k:");
            	  k= int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a idade de x:");
           	  x= int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a idade de y:");
            	  y= int.Parse(Console.ReadLine());

                Console.WriteLine("A idade de I é: {0}", i);
		Console.WriteLine("A idade de J é: {0}", j);
		Console.WriteLine("A idade de K é: {0}", k);
		Console.WriteLine("A idade de X é: {0}", x);
		Console.WriteLine("A idade de Y é: {0}", y);
      		Console.WriteLine($" A média das idades é : {(media.ToString("0.0"))}"); */

            // Exercicio 2
            //Dada a distância A e o combustível gasto B, faça um algoritmo para calcular o consumo médio.


            /* float consumo, a, b;

             a = 200;
             b = 70;
             consumo = a / b;

              Console.WriteLine("Distância total percorrida: {0}", a);
              Console.WriteLine("Combustível gasto: {0}", b);

              Console.WriteLine($"O consumo médio foi de: {(consumo.ToString("0.0"))}"); */

            // Exercicio 3
           //3 - Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.

            /*
            int a, b, c;


            Console.WriteLine("Digite o primeiro número: ");
            a= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            c= int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("O menor número é: {0}", a);

            } else if (b < a && b < c)
            {
                Console.WriteLine("O menor número é: {0}", b);

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("O menor número é: {0}", c);

            } */

            // Exercicio 4
            //Faça um algoritmo que converta a temperatura de C para F
            /*

	   double c,f;
           

	    Console.WriteLine("Digite a temperatura em Celsius: ");
            c= double.Parse(Console.ReadLine());
	    f = (c* 1.8 + 32);
            
            Console.WriteLine("A temperatura em Celsius é: {0} ", c);
            Console.WriteLine("A temperatura em Fahrenheit é: {0} ", f);
        

       
            */

            // Exercicio 5
            // Faça um algoritmo para apresentar se dois números são múltiplos

            /* int num1, num2;

             Console.WriteLine("Digite o primeiro número : ");
             num1= int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número : ");
             num2= int.Parse(Console.ReadLine());

             if (num1 % num2 == 0)
             {
                 Console.WriteLine("O numero: {0}" , num1 + " é multiplo de  " +num2);

             }
             else {
                 Console.WriteLine("O numero: {0}", num1 + " não é multiplo de  " +num2);

             }
            */

            // Exercicio 6
           // Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que calcule o tempo que durou a partida.

            /*int horaInicial = int.Parse(Console.ReadLine());
            int minutoInicial = int.Parse(Console.ReadLine());
            int horaFinal = int.Parse(Console.ReadLine());
            int minutoFinal = int.Parse(Console.ReadLine());

            DateTime date1 = new DateTime(2021, 10, 08, horaInicial, minutoInicial, 0);
            DateTime date2 = new DateTime(2021, 10, 08, horaFinal, minutoFinal, 0);

            TimeSpan ts = date2 - date1;
            string fromTimeString = ts.ToString("hh':'mm");

            Console.WriteLine(fromTimeString);

            */


            // Exercicio 7
           //Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente com os números pares.

            /*
            List<int> lst = new List<int>();

            lst.Add(10);
            lst.Add(9);
            lst.Add(7);
            lst.Add(0);
            lst.Add(4);
            lst.Add(12);

            var output = lst.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(output);
            */

            // Exercicio 8
           //8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não.

            /*    int number, i;
                int resultado = 0;

                Console.WriteLine("Digite um número :");
                number = int.Parse(Console.ReadLine());

                for (i  = 2; i <= number /2; i++)
                {
                    if(number % i == 0)
                    {
                        resultado++;
                        break;
                    }
                }

                if (resultado == 0)
                {
                    Console.WriteLine("{0} É um numero primo :", number);
                }
                else
                {
                    Console.WriteLine("{0} Não é um numero primo :", number);

                } */

            // Exercicio 9
            //9 - Faça um algoritmo que receba um número e retorne a tabuada desse número.
            /*
             int i, numero;


             Console.WriteLine("Digite um número :");
             numero = int.Parse(Console.ReadLine());

             Console.WriteLine("Tabuada de {0} :", numero);
             for (i = 0; i <= 10; i++)
             {
                 Console.WriteLine(numero + " x " + i + " = " + i * numero);

             }
            */
            // Exercicio 10
           //Faça um algoritmo que receba um número e retorne o Fatorial desse número
            /*
            int fatorial, number;

            Console.WriteLine("Digite um número :");
            number = int.Parse(Console.ReadLine());

            for (fatorial = 1; number > 1; number = number - 1)
            {
                fatorial = fatorial * number;
            }
            Console.WriteLine("Resultado do fatorial calculado: {0}", fatorial);

             */

            // Exercicio 11
           //11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a  intersecção das listas

            /* int[] A = new int[] { 1, 2, 3, 4, 9 };
               int[] B = new int[] { 1, 2, 5, 8, 10 };
               int[] interseccao = new int[5];

               Console.WriteLine("Intersecção");
               for (int i = 0; i < interseccao.Length; i++)
               {
                   int iguais = (from b in A where A[i] == B[i] select A[i]).FirstOrDefault();

                   intersecao[i] = iguais;
                   Console.WriteLine(interseccao[i]);

               }
            */

            // Exercicio 12
           //12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a  concatenação das listas.

            /* int[] A = new int[] { 1, 2, 3, 4 };
            int[] B = new int[] { 1, 2, 5, 8 };
            List<int> concat = A.Concat(B).ToList();
            Console.WriteLine("Lista Concatenada : ");
            concat.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            */

            // Exercicio 13
            ///////////////////////////////////////////////////////////////////////////////
            ///13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os valores dessa matriz.
            /*
            int[,] multi = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("A Matriz tem {0} dimensions.", multi.Rank);
            Console.WriteLine("Valores que a Matriz contém: ");
            Console.WriteLine(String.Join(" ", multi.Cast<int>()));

            */

            // Exercicio 14
            // Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo. 
            //(Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice - versa.Ex: osso, Ana e etc).
            /*
              string nome, resultado;

              Console.WriteLine("Digite um nome para verificar se é palíndromo: ");
              nome = Console.ReadLine();

              char[] letra = nome.ToCharArray();
              Array.Reverse(letra);
              resultado = new string(letra);

              bool check = nome.Equals(resultado, StringComparison.OrdinalIgnoreCase);

              if (check == true)
              {
                  Console.WriteLine("O nome : " + nome + " é palíndromo!");
              }
              else
              {
                  Console.WriteLine("O nome : " + nome + " não é palíndromo!");
              }

             */


        }

    }
}