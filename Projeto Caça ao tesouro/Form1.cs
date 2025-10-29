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
        public int tentativas;
        public Form1()
        {
            InitializeComponent();
            //lblTentativas.Text = "Tentativas: " + tentativas;
        }
        //public int tentativas = 0;
        //Botao para sair do Form
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Função para gerar numeros aleatorios
        public int gerarNúmero()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(1, 20);
            return num;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn1.Text = gerarNúmero().ToString();
                btn1.Click -= btn1_Click;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn2.Text = gerarNúmero().ToString();
                btn2.Click -= btn2_Click;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn3.Text = gerarNúmero().ToString();
                btn3.Click -= btn3_Click;
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn4.Text = gerarNúmero().ToString();
                btn4.Click -= btn4_Click;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn5.Text = gerarNúmero().ToString();
                btn5.Click -= btn5_Click;
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn6.Text = gerarNúmero().ToString();
                btn6.Click -= btn6_Click;
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn7.Text = gerarNúmero().ToString();
                btn7.Click -= btn7_Click;
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn8.Text = gerarNúmero().ToString();
                btn8.Click -= btn8_Click;
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn9.Text = gerarNúmero().ToString();
                btn9.Click -= btn9_Click;
            }

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn10.Text = gerarNúmero().ToString();
                btn10.Click -= btn10_Click;
            }

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn11.Text = gerarNúmero().ToString();
                btn11.Click -= btn11_Click;
            }

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn12.Text = gerarNúmero().ToString();
                btn12.Click -= btn12_Click;
            }

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;
            }
            else
            {
                btn13.Text = gerarNúmero().ToString();
                btn13.Click -= btn13_Click;
            }

        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;

            }
            else
            {
                btn14.Text = gerarNúmero().ToString();
                btn14.Click -= btn14_Click;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;

            }
            else
            {
                btn15.Text = gerarNúmero().ToString();
                btn15.Click -= btn15_Click;
            }

        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (gerarNúmero() <= 3 || gerarNúmero() >= 12)
            {
                //MessageBox.Show('Encontratse o tesouro');
                pictureBox1.Visible = true;

            }
            else
            {
                btn16.Text = gerarNúmero().ToString();
                btn16.Click -= btn16_Click;
            }
        }
    }
}
