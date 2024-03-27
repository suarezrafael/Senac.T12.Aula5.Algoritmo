using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEstruturaControle
{
    public partial class FormPrincipal : Form
    {
        // variavel inteiro
        // 1-tipo 2-nome 3-atribuicao 4-valor da atribuicao
        int contador = 0;
        // variavel texto
        string mensagem = "";
        // variavel decimal
        decimal saldoAtual = decimal.Zero;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cria uma variavel do formConta
            var formConta = new FormConta();
            // mostra a tela formConta
            formConta.Show();
            // incrementar o valor da variavel contador
            contador += 1;

        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exibe uma caixa de mensagem
            mensagem = "Contador de clique: " + contador;
            MessageBox.Show(mensagem,
                "Contador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // atribui o valor da varivel mensagem
            mensagem = "Deseja sair do aplicativo?";
            var resultado = MessageBox
                .Show(mensagem,
                "Sair?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            // se o usuario clico em SIM
            if(resultado == DialogResult.Yes) 
            {
                // Fecha o aplicativo
                Application.Exit();
            }
            else // senão
            {   // grava um log que ele desistiu de sair
                Console.WriteLine("O usuario desistiu de fechar");
            }
        }
    }
}
