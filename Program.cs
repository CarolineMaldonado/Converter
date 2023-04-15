using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertendo
{
    internal class Program
    {
        // A ideia é fazer o usuario entrar com o nome do produto e o sistema atribuir 
        // o codigo dele e mostrar qual é o produto e seu respectivo codigo

        static void Main(string[] args)
        {
            string produto = null;
            int codigo;

            while (true)
            {

                Console.WriteLine("Entre com o nome do produto que deseja verificar: ");
                produto = Console.ReadLine();


                switch (produto)
                {
                    case "maça":
                        codigo = 101;
                        Console.WriteLine("O código do produto é " + codigo.ToString() + " e o produto é " + produto + ".\n");
                        break;

                    case "banana":
                        codigo = 202;
                        Console.WriteLine("O código do produto é " + codigo.ToString() + " e o produto é " + produto + ".\n");
                        break;

                    case "uva":
                        codigo = 303;
                        Console.WriteLine("O código do produto é " + codigo.ToString() + " e o produto é " + produto+ ".\n");
                        break;

                    case "manga":
                        codigo = 404;
                        Console.WriteLine("O código do produto é " + codigo.ToString() + " e o produto é " + produto+".\n");
                        break;

                }


            }



        }
                        
    }
}
