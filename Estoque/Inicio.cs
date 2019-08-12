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
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void CadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.MdiParent = this;

            produto.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?","Fechar o programa!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
