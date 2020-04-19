using System;
using GameTOP.Interface;

namespace GameTOP{
    public class Jogobom{
    private readonly iJogador  _jogadorA;
    private readonly iJogador  _jogadorB;

    public Jogobom(iJogador jogadorA, iJogador jogadorB){

        _jogadorA = jogadorA;
        _jogadorB = jogadorB;
    }
    public void IniciarJogo(){
       System.Console.WriteLine(_jogadorA.Corre());
       System.Console.WriteLine(_jogadorA.Chuta());
       System.Console.WriteLine(_jogadorA.Passe());

        System.Console.WriteLine("\n Próximo Jogador \n");

       System.Console.Write(_jogadorB.Corre());
       System.Console.Write(_jogadorB.Chuta());
       System.Console.Write(_jogadorB.Passe());
       
    }
}
    
}
