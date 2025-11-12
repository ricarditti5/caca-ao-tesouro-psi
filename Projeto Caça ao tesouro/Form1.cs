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
        private GameManager jogo;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            jogo = new GameManager();
            lblTentativas.Text = "Tens " + jogo.MaxTentativas.ToString() + " Restantes";
            jogo.IniciarNovoJogo();
        }
        //Botao para sair do Form
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Função  para Processar o numero dos cliques
        private void ProcessarClique(int index)
        {
            if (jogo.LimiteTentativas())    return;

            Button btn = Controls.Find("btn" + index, true).FirstOrDefault() as Button;
            if (btn == null) return;

            btn.Enabled = false;
            jogo.NumTentativas();

            string dica = jogo.GerarDica(index);
            int tentativasRestantes;

            if (index != jogo.PosicaoTesouro)
            {
                tentativasRestantes = jogo.MaxTentativas - jogo.Tentativas;
                MessageBox.Show(" Nada aqui...  " + dica);
                lblTentativas.Text = "Tens " + tentativasRestantes.ToString() + " Restantes ";
                btn.Text = "💀";
            }

                else if (index == jogo.PosicaoTesouro)
                {
                    tentativasRestantes = jogo.MaxTentativas - jogo.Tentativas;
                    pictureBox1.Visible = true;
                    MessageBox.Show(" 🎉 Parabéns! Encontraste o tesouro! " + " Tesouro Encontrado com " + tentativasRestantes + " Tentativas de Sobra ");
                    DesativarTodosOsBotoes();
                    return;
                }

                else if (jogo.Tentativas >= jogo.MaxTentativas)
                {
                    MessageBox.Show(" 💀 Fim de jogo! O tesouro ficou escondido... Perdeste! ");
                    DesativarTodosOsBotoes();
                }
        }
       
        //Função para Desativar os Botoes
        private void DesativarTodosOsBotoes()
        {
            for (int i = 1; i <= 16; i++)
            {
                Button btn = Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                if (btn != null)
                    btn.Enabled = false;
            }
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16; i++)
            {
                Button btn = Controls.Find("btn" + i, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Enabled = true;
                    btn.Text = "X";
                }
            }
            pictureBox1.Visible = false;
            jogo.IniciarNovoJogo();
            MessageBox.Show("🔄 Novo jogo iniciado! Boa sorte!");
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
    }
}
