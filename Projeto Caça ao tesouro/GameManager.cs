using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Caça_ao_tesouro
{
    public class GameManager
    {
        private int tentativas = 0;
        private const int MAX_TENTATIVAS = 4;
        private Random random = new Random();
        private int posicaoTesouro;

        //Encapsulamento com get; set;
        public int Tentativas
        {
            get { return tentativas; }
            set { tentativas = value; }
        }

        //Encapsulamento com get; set;
        public int MaxTentativas
        {
            get { return MAX_TENTATIVAS; }
            set { MaxTentativas = value; }
        }

        //Encapsulamento com get; set;
        public int PosicaoTesouro
        {
            get { return posicaoTesouro; }
            set { posicaoTesouro = value; }
        }

        //Função para Iniciar o jogo
        public void IniciarNovoJogo()
        {
            tentativas = 0;
            posicaoTesouro = random.Next(1, 17); // 1 a 16
        }

        //Função para gerar numeros aleatorios
        public int GerarNúmero()
        {
            return  random.Next(1, 20);
        }

        public string GerarDica(int index)
        {
            // Converter de 1-16 para 0-15 para cálculos->cchatgpt
            int idx = index - 1;
            int tesouroIdx = posicaoTesouro - 1;

            int linhaClicada = idx / 4;
            int colunaClicada = idx % 4;
            int linhaTesouro = tesouroIdx / 4;
            int colunaTesouro = tesouroIdx % 4;

            //calcula a distância entre duas posições no jogo — neste caso, entre o ponto que o jogador clicou (linhaClicada, colunaClicada) e o ponto onde está o tesouro (linhaTesouro, colunaTesouro).
            int distancia = Math.Abs(linhaClicada - linhaTesouro) + Math.Abs(colunaClicada - colunaTesouro);

            if (distancia == 0)
                return "Encontraste o tesouro!";
            else if (distancia == 1)
                return "🔥 Está MUITO perto! Ao lado!";
            else if (distancia == 2)
                return "Está perto!";
            else if (distancia <= 4)
                return "Tens uma pista quente...";
            else
                return "Está bem longe!";
        }
        
        // função para controlar o numero de tentativas
        public void NumTentativas()
        {
            tentativas++;
        }

        //funcao para o limite de tentativas
        public bool LimiteTentativas()
        {
            return tentativas >= MAX_TENTATIVAS;
        }

       
    }
}
