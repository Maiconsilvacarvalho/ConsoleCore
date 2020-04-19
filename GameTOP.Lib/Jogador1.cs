using System;
using GameTOP.Interface;

namespace GameTOP.Lib{
   public class Jogador1 : iJogador {
        public readonly string _Nome;


        public Jogador1 (string nome){
            _Nome = nome;
        }

        public string Chuta(){
            return $"{_Nome} está chutando";
        }

        public string Corre(){
            return $"{_Nome} está Correndo";
        }

        public string Passe(){
            return $"{_Nome} está passando";
        }
    }
}
/* 

    namespace GameTOP
{
    public class Jogador1 : iJogador
    {
        public string Chuta()
        {
            return "Ronaldo estas chutando";
        }

        public string Corre()
        {
            return "Ronaldo estas correndo";
        }

        public string Passe()
        {
            return "Ronaldo estas passando";
        }
    }
}
 */