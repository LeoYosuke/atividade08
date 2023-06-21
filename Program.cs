using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade08
{
    class Program
    {
        static List<string> nomes = new List<string>();
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Cadastro de usuários!");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Buscar");
                Console.WriteLine("3 - Deletar");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Listar");
                int opcao = Int32.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome que deseja cadastrar:");
                    nomes.Add(Console.ReadLine());
                    Console.WriteLine("Cadastro feito com sucesso");
                    Main(null);
                }
                if (opcao == 2)
                {
                    if (nomes.Count > 0)
                    {
                        Console.WriteLine("Digite a posição que deseja buscar:");
                        int busca = Int32.Parse(Console.ReadLine());

                        if (busca >= 0 && busca < nomes.Count)
                        {
                            Console.WriteLine(nomes[busca]);
                            Main(null);
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista está vazia");
                    }
                }



                if (opcao == 3)
                {
                    Console.WriteLine("Qual posição deseja deletar?");
                    int del;
                    del = int.Parse(Console.ReadLine());
                    nomes.RemoveAt(del );
                    Console.WriteLine("Opção deletada com sucesso!!");
                    Main(null);
                }
                if(opcao == 4)
                {
                    int cont = 0;
                    string nome;
                    Console.WriteLine("qual nome deseja alterar?");
                    nome = Console.ReadLine();
                    while(cont < nomes.Count) 
                    {
                        if(nome == nomes[cont]) 
                        {
                            Console.WriteLine("insira o novo nome:");
                            nome = Console.ReadLine();
                            nomes[cont] = nome;
                            cont++;
                            Main(null);
                        }
                        
                    }
                }
                if(opcao == 5)
                {
                    int cont = 0;
                    while (cont < nomes.Count) 
                    {
                        Console.WriteLine($"nomes: {nomes[cont]}");
                        cont++;
                        
                    }
                    Main(null);
                }

                Console.ReadKey();
            }

        }
    }
}
