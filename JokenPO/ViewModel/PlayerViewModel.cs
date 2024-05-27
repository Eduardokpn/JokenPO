using CommunityToolkit.Mvvm.ComponentModel;
using JokenPO.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using JokenPO.Models;

using System.Runtime.Intrinsics.X86;


namespace JokenPO.ViewModel
{
    public partial class PlayerViewModel : ObservableObject

    {
        Player Player1 = new Player("", 0 , 0);
        Player Maquina = new Player("", 0, 0);

        public PlayerViewModel()
        {
            jogarComand = new Command(jogar);
            Escolha = new Escolha();
        }



        public ICommand jogarComand { get; }


        [ObservableProperty]
        public string _nome;

        [ObservableProperty]
        public int _pontuacao;

        [ObservableProperty]
        public Escolha _escolha;

        [ObservableProperty]
        public string _valor;



        public void jogar()
        {
            
            int result = new Random().Next(3);
            
           Player1.Nome = _nome;


            switch (Escolha)

            {
                case Escolha.PEDRA:
                    if (result == 0)
                    {

                        Player1.Pontuacao++;
                        Maquina.Pontuacao++;
                        Valor = $@"{Player1.Nome},Você Empatou, sua pontuação {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }




                    else if (result == 1)
                    {
                        Player1.Pontuacao += 2;
                        Valor = $"{Player1.Nome},Você Ganhou, sua pontuacao {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }

                    else
                    {
                        Maquina.Pontuacao += 2;
                        Valor = $"{Player1.Nome}, Você Perdou, A pontuação da maquina é {Maquina.Pontuacao}";

                    }
                    
                    break;


                case Escolha.PAPEL:
                    if (result == 1)
                    {

                        Player1.Pontuacao++;
                        Maquina.Pontuacao++;
                        Valor = $"{Player1.Nome}, Você Empatou, sua pontuação {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }

                    else if (result == 2)
                    {
                        Player1.Pontuacao += 2;
                        Valor = $"{Player1.Nome}, Você Ganhou, sua pontuacao {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }


                    else
                    {
                        Maquina.Pontuacao += 2;
                        Valor = $"{Player1.Nome}, Você Perdeu, A pontuação da maquina é {Maquina.Pontuacao}";

                    }

                    break;

                case Escolha.TESOURA:

                    if (result == 2)
                    {

                        Player1.Pontuacao++;
                        Maquina.Pontuacao++;
                        Valor = $"{Player1.Nome}, Você Empatou, sua pontuação {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }

                    else if (result == 1)
                    {
                        Player1.Pontuacao += 2;
                        Valor = $"{Player1.Nome}, Você Ganhou, sua pontuacao {Player1.Pontuacao}, A pontuação da maquina é {Maquina.Pontuacao}";
                    }

                    else
                    {
                        Maquina.Pontuacao += 2;
                        Valor = $"{Player1.Nome}, Você Perdou, A pontuação da maquina é {Maquina.Pontuacao}";

                    }

                    break;

            }

        }


    }
}
