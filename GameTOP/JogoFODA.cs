using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly string _nomeJogador;
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

        public JogoFODA(string nome)
        {
            _nomeJogador = nome;
        }

        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.Write(_jogador1.Chuta());
            Console.Write(_jogador1.Corre());
            Console.Write(_jogador1.Passa());
            Console.Write("\n PRÓXIMO JOGADOR \n");
            Console.Write(_jogador2.Chuta());
            Console.Write(_jogador2.Corre());
            Console.Write(_jogador2.Passa());

        }
    }
}