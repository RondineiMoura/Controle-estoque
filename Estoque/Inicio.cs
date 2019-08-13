using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Inicio : Form
    {
        //instancia o objeto funcoes
        FuncoesComuns funcoes = new FuncoesComuns();
        public Inicio()
        {
            InitializeComponent();
        }

        //adiciona o relogio no menu
        private void Inicio_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        //atualiza o relogio no menu a cada segundo
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        //abre a tela de cadastrar produtos
        private void CadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto
            {
                MdiParent = this
            };

            //fecha forms abertos
            funcoes.FechaForms();

            produto.Show();
        }

        //botao para sair da aplicação
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?","Fechar o programa!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //abre a tela para cadastrar categorias
        private void CadastrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                MdiParent = this
            };

            //fecha forms abertos
            funcoes.FechaForms();

            categoria.Show();
        }
    }
}
