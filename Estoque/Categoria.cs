using System;
using System.Windows.Forms;


namespace Estoque
{
    public partial class Categoria : Form
    {
        Categoriasget C = new Categoriasget();
        public Categoria()
        {
            InitializeComponent();
        }

        //realiza o cadastro das categorias
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            C.SetDescricao(txtDesc.Text);

            C.GravarDescricao();

            txtDesc.Text = string.Empty;
            txtDesc.Focus();
        }
    }
}
