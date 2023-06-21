using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace aula09_Correcao_Produtos
{
    internal class Program
    {
        public static List<string> estoque = new List<string> { "pepsi", "fanta" };


        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo a Lojinha");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - cadastrar");
            Console.WriteLine("2 - listar ");
            int opcao = int.Parse(Console.ReadLine());


            if (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("Digite uma opção válida!");
                Main(null);
            }

            if (opcao == 1)
            {

                Console.WriteLine("Digite o nome do produto que deseja adicionar !");
                string produto = Console.ReadLine();
                produto = produto.ToLower();


                if (estoque.Contains(produto))
                {
                    Console.WriteLine("Esse item já está na lista!");
                }
                else
                {
                    Console.WriteLine($"O produto foi adicionado com sucesso !");
                    estoque.Add(produto.ToLower());

                }


            }

            string texto = "";

            if (opcao == 2)
            {
                int contador = 0;

                while (contador < estoque.Count)
                {

                    string nome = estoque[contador];

                    string nome_tratado = nome.Substring(0, 1).ToUpper() + nome.Substring(1, nome.Length -1).ToLower() + ", ";

                    texto += nome_tratado;
                    
                    contador++;


                }

                texto = texto.Substring(0, texto.Length -2);
                texto += ".";
                Console.WriteLine(texto);
                
            }



            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;


        }



    }
}

