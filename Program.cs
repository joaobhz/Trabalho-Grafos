using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "",r = "";
            int qtd = 0,v1 = 0, v2 = 0;
            bool x = false, voltar = true;

            

            Console.WriteLine("Quantidade de aresta do seu grafo ?");
            qtd = int.Parse(Console.ReadLine());

            GrafoMA ma = new GrafoMA(qtd);
            GrafoLA la = new GrafoLA(qtd);

            do
            {
                op = "";
                Console.Clear();
                Console.WriteLine("Escolhe entre MA - matriz adjacente ou LA - lista adjacente ?");
                op = Console.ReadLine();                
                switch (op)
                {
                    case "MA":
                        do
                        {
                            op = "";
                            
                            Console.Clear();
                            Console.WriteLine("Escolha uma das opcao abaixo: ");
                            Console.WriteLine("A - ORDEM");
                            Console.WriteLine("B - INSERIR VERTICE");
                            Console.WriteLine("C - REMOVER VERTICE");
                            Console.WriteLine("D - INDICAR O GRAU");
                            Console.WriteLine("E - INDICAR SE O GRAFO E COMPLETO");
                            Console.WriteLine("F - INDICAR SE O GRAFO E REGULAR");
                            Console.WriteLine("G - IMPRIMIR UMA MA");
                            Console.WriteLine("H - IMPRIMIR UMA LA");
                            Console.WriteLine("I - SEQUECIA DE GRAUS");
                            Console.WriteLine("J - IMPRIMIR ADJACENTES DE UM VERTICE");
                            Console.WriteLine("K - VERIFICAR SE O VERTICE E ISOLADO");
                            Console.WriteLine("L - VERIFICAR SE O VERFICE E IMPAR");
                            Console.WriteLine("M - VERIFICAR SE O VERTICE E PAR");
                            Console.WriteLine("N - VERIFICAR SE OS VERTICES SAO ADJACENTE");
                            Console.WriteLine();

                            op = Console.ReadLine();

                            switch (op)
                            {
                                case "A":
                                    Console.Clear();
                                    Console.WriteLine("A quantidade de verice e: {0}", v1 = ma.ordem());
                                    break;

                                case "B":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice que deseja insereir uma aresta");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o vertice que deseja insereir uma aresta");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = ma.inserirAresta(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Inserido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao inserir");
                                    }
                                    break;

                                case "C":
                                    Console.Clear();
                                    Console.WriteLine("Digite o aresta que deseja remover");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o aresta que deseja remover");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = ma.removerAresta(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Removido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao remover");
                                    }
                                    break;

                                case "D":
                                    Console.Clear();
                                    Console.WriteLine("Digita a vertice que deseja descubri o grau");
                                    v1 = int.Parse(Console.ReadLine());

                                    v2 = ma.grau(v1);

                                    Console.WriteLine("O grau e: {0}", v2);

                                    break;

                                case "E":
                                    Console.Clear();
                                    x = ma.completo();

                                    if (x)
                                    {
                                        Console.WriteLine("O grafo e completo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O grafo nao e completo");
                                    }
                                    break;

                                case "F":
                                    Console.Clear();
                                    x = ma.regular();

                                    if (x)
                                    {
                                        Console.WriteLine("O grafo e regular");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O grafo nao e regular");
                                    }
                                    break;

                                case "G":
                                    Console.Clear();
                                    ma.showMA();
                                    break;

                                case "H":
                                    Console.Clear();
                                    ma.showLA();
                                    break;

                                case "I":
                                    Console.Clear();
                                    ma.sequenciaGraus();
                                    break;

                                case "J":
                                    Console.Clear();
                                    Console.WriteLine("Digita o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    ma.verticesAdjacentes(v1);
                                    break;

                                case "K":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertive");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = ma.isolado(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("O vertice e isolado");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O vertice nao e isolado");
                                    }
                                    break;

                                case "L":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = ma.par(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("E par");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não e par");
                                    }
                                    break;

                                case "M":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = ma.impar(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("E impar");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não e impar");
                                    }
                                    break;

                                case "N":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o vertice");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = ma.adjacentes(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Sao adjacente");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nao sao adjacente");
                                    }

                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Opção invalida");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Deseja realizar uma consulta MA? S/N");
                            r = Console.ReadLine();
                            if (r == "N")
                            {
                                voltar = false;
                            }
                            else if (r == "S")
                            {
                                voltar = true;
                            }
                        } while (voltar == true);
                        
                        break;


                    case "LA":
                        do
                        {
                            op = "";

                            Console.Clear();
                            Console.WriteLine("Escolha uma das opção abaixo: ");
                            Console.WriteLine("A - INSERIR ARESTA");
                            Console.WriteLine("B - REMOVER ARESTA");
                            Console.WriteLine("C - ORDEM");
                            Console.WriteLine("D - INSERIR VERTICE");
                            Console.WriteLine("E - REMOVER VERTICE");
                            Console.WriteLine("F - INDICAR O GRAU");
                            Console.WriteLine("G - INDICAR SE O GRAFO E COMPLETO");
                            Console.WriteLine("H - INDICAR SE O GRAFO E REGULAR");
                            Console.WriteLine("I - IMPRIMIR UMA LA");
                            Console.WriteLine("J - SEQUENCIA DE GRAU");
                            Console.WriteLine("K - IMPRIMIR ADJACENTES DE UM VERTICE");
                            Console.WriteLine("L - VERIFICAR SE O VERTICE E ISOLADO");
                            Console.WriteLine("M - VERIFICAR SE O VERFICE E PAR");
                            Console.WriteLine("N - VERIFICAR SE O VERFICE E IMPAR");
                            Console.WriteLine("O - VERIFICAR SE OS VERTICES SAO ADJACENTE");
                            Console.WriteLine();

                            op = Console.ReadLine();

                            switch (op)
                            {
                                case "A":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice que deseja inserir");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = la.InserirVertice(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("Inserido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao inserir");
                                    }

                                    break;

                                case "B":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice que deseja remover");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = la.RemoverVertice(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("Removido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao remover");
                                    }
                                    break;

                                case "C":
                                    Console.Clear();
                                    Console.WriteLine("A quantidade de verice e: {0}", v1 = la.ordem());
                                    break;

                                case "D":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice que deseja insereir uma aresta");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o vertice que deseja insereir uma aresta");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = la.inserirAresta(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Inserido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao inserir");
                                    }
                                    break;

                                case "E":
                                    Console.Clear();
                                    Console.WriteLine("Digite o aresta que deseja remover");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o aresta que deseja remover");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = la.removerAresta(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Removido com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Falha ao remover");
                                    }
                                    break;

                                case "F":
                                    Console.Clear();
                                    Console.WriteLine("Digita a vertice que deseja descubri o grau");
                                    v1 = int.Parse(Console.ReadLine());

                                    v2 = la.grau(v1);

                                    Console.WriteLine("O grau e: {0}", v2);

                                    break;

                                case "G":
                                    Console.Clear();
                                    x = la.completo();

                                    if (x)
                                    {
                                        Console.WriteLine("O grafo e completo");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O grafo nao e completo");
                                    }

                                    break;

                                case "H":
                                    Console.Clear();
                                    x = la.regular();

                                    if (x)
                                    {
                                        Console.WriteLine("O grafo e regular");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O grafo nao e regular");
                                    }

                                    break;

                                case "I":
                                    Console.Clear();
                                    la.ShowLA();
                                    break;

                                case "J":
                                    Console.Clear();
                                    la.sequenciaGraus();
                                    break;

                                case "K":
                                    Console.Clear();
                                    Console.WriteLine("Digita o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    la.verticesAdjacentes(v1);
                                    break;

                                case "L":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertive");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = la.Isolado(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("O vertice e isolado");
                                    }
                                    else
                                    {
                                        Console.WriteLine("O vertice nao e isolado");
                                    }
                                    break;

                                case "M":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = la.Par(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("E par");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não e par");
                                    }
                                    break;

                                case "N":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());

                                    x = la.Impar(v1);

                                    if (x)
                                    {
                                        Console.WriteLine("E impar");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não e impar");
                                    }
                                    break;

                                case "O":
                                    Console.Clear();
                                    Console.WriteLine("Digite o vertice");
                                    v1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o vertice");
                                    v2 = int.Parse(Console.ReadLine());

                                    x = la.Adjacentes(v1, v2);

                                    if (x)
                                    {
                                        Console.WriteLine("Sao adjacente");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nao sao adjacente");
                                    }

                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Opção invalida");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Deseja realizar uma consulta na LA? S/N");
                            r = Console.ReadLine();
                            if (r == "N")
                            {
                                voltar = false;
                            }
                            else if (r == "S")
                            {
                                voltar = true;
                            }
                        } while (voltar == true);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Deseja realizar outra consulta ? S/N");
                r = Console.ReadLine();
                if (r == "N")
                {
                    voltar = false;
                }
                else if (r == "S")
                {
                    voltar = true;
                }
            } while (voltar == true);         
        }
    }
}
