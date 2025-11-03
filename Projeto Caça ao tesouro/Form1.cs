using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Caça_ao_tesouro
{
    public partial class Form1 : Form
    {
        private int tentativas = 0;
        private const int MAX_TENTATIVAS = 4;
        private Random random = new Random();
        private int posicaoTesouro;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            IniciarNovoJogo();
        }
        //Botao para sair do Form
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Função para Iniciar o jogo
        private void IniciarNovoJogo()
        {
            tentativas = 0;
            pictureBox1.Visible = false;
            posicaoTesouro = random.Next(1, 17); // 1 a 16
        }
        //Função para gerar numeros aleatorios
        public int gerarNúmero()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(1, 20);
            return num;
        }
        //Função  para Processar o numero dos cliques
        private void ProcessarClique(int index)
        {
            if (tentativas >= MAX_TENTATIVAS)
                return;

            Button btn = this.Controls.Find("btn" + index, true).FirstOrDefault() as Button;
            if (btn == null) return;

            btn.Enabled = false;
            tentativas++;

            if (index == posicaoTesouro)
            {
                pictureBox1.Visible = true;
                MessageBox.Show("🎉 Parabéns! Encontraste o tesouro!", "Tesouro Encontrado");
                DesabilitarTodosBotoes();
                return;
            }

            string dica = GerarDica(index);
            int tentativasRestantes = MAX_TENTATIVAS - tentativas;
            MessageBox.Show("Nada aqui... " + dica + "\nTentativas restantes: " + tentativasRestantes);
            btn.Text = "💀";

            if (tentativas >= MAX_TENTATIVAS)
            {
                MessageBox.Show("💀 Fim de jogo! O tesouro ficou escondido...", "Perdeste!");
                DesabilitarTodosBotoes();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ProcessarClique(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ProcessarClique(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ProcessarClique(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ProcessarClique(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ProcessarClique(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ProcessarClique(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ProcessarClique(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ProcessarClique(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ProcessarClique(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ProcessarClique(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ProcessarClique(11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ProcessarClique(12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            ProcessarClique(13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            ProcessarClique(14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            ProcessarClique(15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            ProcessarClique(16);
        }

        private string GerarDica(int index)
        {
            // Converter de 1-16 para 0-15 para cálculos->cchatgpt
            int idx = index - 1;
            int tesouroIdx = posicaoTesouro - 1;

            int linhaClicada = idx / 4;
            int colunaClicada = idx % 4;
            int linhaTesouro = tesouroIdx / 4;
            int colunaTesouro = tesouroIdx % 4;

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
        private void DesabilitarTodosBotoes()
        {
            for (int i = 1; i <= 16; i++)
            {
                Button btn = this.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                if (btn != null)
                    btn.Enabled = false;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16; i++)
            {
                Button btn = this.Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Enabled = true;
                    btn.Text = "X";
                }
            }

            IniciarNovoJogo();
            MessageBox.Show("🔄 Novo jogo iniciado! Boa sorte!", "Reset");
        }
    }
}
