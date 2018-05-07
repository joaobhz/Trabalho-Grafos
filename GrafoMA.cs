using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrafos
{
    class GrafoMA
    {
        private int[,] MA;
        private int qtVertices;

        public GrafoMA(int qtVertices)
        {
            this.qtVertices = qtVertices;
            this.MA = new int[qtVertices + 1, qtVertices + 1];

            for (int i = 1; i <= qtVertices; i++)
            {
                for (int j = 1; j <= qtVertices; j++)
                {
                    MA[i, j] = 0;
                }
            }

        }

        public int ordem()
        {
            return this.qtVertices; //testado ok
        }

        public bool inserirAresta(int v1, int v2)
        {
            if (v1 <= qtVertices && v2 <= qtVertices && v1 > 0 && v2 > 0)
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;
                return true;
            }

            return false;
        }

        public bool removerAresta(int v1, int v2)
        {
            if (v1 <= qtVertices && v2 <= qtVertices && v1 > 0 && v2 > 0)
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;
                return true;
            }

            return false; // testado ok
        }

        public int grau(int vertice)
        {
            int grau = 0;
            for (int i = 1; i <= qtVertices; i++)
            {
                if (MA[vertice, i] == 1)
                {
                    grau++;
                }
            }

            return grau;
        }

        public bool completo()
        {
            int maximo = qtVertices * (qtVertices - 1) / 2;
            int atual = 0;
            for (int i = 1; i <= qtVertices; i++)
            {
                for (int j = 1; j <= qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                        atual++;
                }
            }

            if (atual == maximo)
                return true;

            return false;
        }

        public bool regular()
        {
            int controle = MA[1, 1];
            int atual = 0;

            for (int i = 1; i <= qtVertices; i++)
            {
                for (int j = 1; j <= qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                        atual++;

                }

                if (controle != atual && i > 1)
                    return false;

                atual = 0;
            }

            return true;
        }

        public void showMA()
        {
            for (int i = 1; i <= qtVertices; i++)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine(" ");
            for (int i = 1; i <= qtVertices; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j <= qtVertices; j++)
                {
                    Console.Write(MA[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        public void showLA()
        {
            for (int i = 1; i <= qtVertices; i++)
            {
                Console.Write(i + ": ");
                for (int j = 1; j <= qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                        Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
        }

        public void sequenciaGraus()
        {
            int graus = 0;
            List<int> controle = new List<int>();

            for (int i = 1; i <= qtVertices; i++)
            {
                for (int j = 1; j <= qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                        graus++;
                }
                controle.Add(graus);
                graus = 0;
            }

            controle.Sort();

            for (int i = 0; i < qtVertices; i++)
                Console.Write(controle[i] + ", ");
        }

        public void verticesAdjacentes(int v1)
        {
            for (int i = 1; i <= qtVertices; i++)
            {
                if (MA[v1, i] == 1)
                    Console.Write(i + ", ");   
                Console.WriteLine(" ");
            }
        }

        public bool isolado(int v1)
        {
            int graus = 0;

            for (int j = 1; j <= qtVertices; j++)
            {
                if (MA[v1, j] == 1)
                    graus++;
            }

            if (graus > 0)
                return false;

            return true;


        }

        public bool impar(int v1)
        {
            int graus = 0;

            for (int j = 1; j <= qtVertices; j++)
            {
                if (MA[v1, j] == 1)
                    graus++;
            }

            if (graus % 2 == 0)
                return false;

            return true;
        }

        public bool par(int v1)
        {
            int graus = 0;

            for (int j = 1; j <= qtVertices; j++)
            {
                if (MA[v1, j] == 1)
                    graus++;
            }

            if (graus % 2 != 0)
                return false;

            return true;
        }

        public bool adjacentes(int v1, int v2)
        {
            if (MA[v1, v2] == 0)
                return false;
            return true;
        }

    }
}
