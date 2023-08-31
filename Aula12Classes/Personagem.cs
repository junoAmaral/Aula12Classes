using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        //ATRIBUTOS (VARIÁVEIS):
        public string nome;
        public string raca;
        public int poder;

        //MÉTODOS (FUNÇÕES):
        public void mostra()
        {
            Console.WriteLine($"Personagem {nome}, um {raca} com poder de {poder}.");
        }
    }
}
