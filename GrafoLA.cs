using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrafos
{
    class GrafoLA
    {
        private Dictionary<int, List<int>> LA;
        private int qtVertices;

        public GrafoLA(int qtVertices)
        {
            this.LA = new Dictionary<int, List<int>>();
            this.qtVertices = qtVertices;
            for (int i = 0; i < qtVertices; i++)
            {
                LA.Add(i + 1, new List<int>());
            }
        }

        public void verticesAdjacentes(int v1)
        {
            foreach (var chave in LA)
            {
                if (chave.Key == v1)
                {
                    Console.Write("\n{0}", chave.Key);

                    foreach (var valor in chave.Value)
                        Console.Write("\t{0}", valor);
                }
            }
        }
        
        public void ShowLA()
        {
            foreach (var chave in LA)
            {
                    Console.Write("\n{0}: ", chave.Key);

                    foreach (var valor in chave.Value)
                        Console.Write("\t{0},", valor);
            }
        }

        public bool Par (int v1)
        {
            if (LA[v1].Count % 2 == 0 && LA.ContainsKey(v1))
            {
                return true;
            }
            return false;
        }

        public bool Impar(int v1)
        {
            if (LA[v1].Count % 2 != 0 && LA.ContainsKey(v1))
            {
                return true;
            }
            return false;
        }

        public bool Isolado(int v1)
        {          
            if (LA[v1].Count == 0 && LA.ContainsKey(v1))
            {
                return true;
            }
            return false;
        }

        public bool Adjacentes(int v1, int v2)
        {           
            if (LA[v1].Contains(v2) && LA[v1].Contains(v2))
            {
                return true;
            }
            return false;
        }

        public bool InserirVertice(int v1)
        {
            bool resposta = true;

            foreach (int x in LA.Keys)
            {
                if (x == v1)
                    resposta = false;
            }
            if (resposta)
                LA.Add(v1, new List<int>());


            return resposta;
        }

        public bool RemoverVertice(int v1)
        {

            if (LA.ContainsKey(v1))
            {
                LA.Remove(v1);
                foreach (int chave in LA.Keys)
                {
                    if (LA[chave].Contains(v1))
                        LA[chave].Remove(v1);
                }

                return true;
            }

            return false;
        }
     
        public int ordem()
        {
            return this.qtVertices;
        }

        public bool inserirAresta(int v1, int v2)
        {
            if (!LA.ContainsKey(v1) || !LA.ContainsKey(v2))
                return false;

            if(!LA[v1].Contains(v2))
                LA[v1].Add(v2);

            if (!LA[v2].Contains(v1))
                LA[v2].Add(v1);

            return true;
        }

        public bool removerAresta(int v1, int v2)
        {
            if (!LA.ContainsKey(v1) || !LA.ContainsKey(v2))
                return false;

            if (!LA[v1].Contains(v2))
                LA[v1].Remove(v2);

            if (!LA[v2].Contains(v1))
                LA[v2].Remove(v1); 

            return false;
        }

        public int grau(int v1)
        {
            if (LA.ContainsKey(v1))
                return 0;
       
            return LA[v1].Count;
        }

        public bool completo()
        {
            int maximo = qtVertices * (qtVertices - 1) / 2;
            int atual = 0;
            for(int i = 0; i < qtVertices; i++)
            {
                for(int j = 0;j < LA[i+1].Count; j++)
                {
                    atual = + LA[i+1][j];
                }
            }

            if (atual == maximo)
                return true;

            return false;
        }

        public bool regular()
        {
            int controle = LA[0].Count;

            for (int i = 1; i < qtVertices; i++)
            {
                for (int j = 0; j < LA[i+1].Count; j++)
                {
                    if (controle != LA[i+1].Count)
                        return false;
                }
            }

            return true;
        }

        public void sequenciaGraus()
        {

            List<int> controle = new List<int>();

            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < LA[i+1].Count; j++)
                {
                    controle.Add(LA[i].Count);
                }
            }

            controle.Sort();

            for (int i = 0; i < qtVertices; i++)
                Console.Write(controle[i+1] + ", ");
        }

    }
}
