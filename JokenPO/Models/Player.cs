using JokenPO.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JokenPO.Models
{

    public class Player
    {
        public Player(string nome, int pontuacao, Escolha escolha)
        {
            Nome = nome = string.Empty;

            Pontuacao = pontuacao;

            Escolha = escolha;


        }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public Escolha Escolha { get; set; }    
    }
    
    
}


