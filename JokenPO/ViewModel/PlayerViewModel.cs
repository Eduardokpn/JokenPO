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


namespace JokenPO.ViewModel
{
    public partial class PlayerViewModel : ObservableObject

    {

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

            switch (Escolha)

            {
                case Escolha.PEDRA:
                    if (result == 0)
                        Valor = "Você Empatou";
                    

                    else if (result == 1)
                        Valor = "Você Ganhou";

                    else
                        Valor = "Você Perdou";
                    
                    break;


                case Escolha.PAPEL:
                    if (result == 1)
                        Valor = "Voc~e Empatou";

                    else if (result == 2)
                        Valor = "Você Ganhou";


                    else
                        Valor = "Você Perdou";

                    break;

                case Escolha.TESOURA:

                    if (result == 2)
                        Valor = "Voc~e Empatou";

                    else if (result == 1)
                        Valor = "Você Ganhou";

                    else
                        Valor = "Você Perdou";

                    break;

            }

        }


    }
}
