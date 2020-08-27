using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome="Zeca")
        {
            _Nome = nome;
        }
        public string Corre()
        {
            return $"{_Nome} está correndo \n";
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando \n";
        }

        public string Passa()
        {
            return $"{_Nome} está passando \n";
        }
    }
}