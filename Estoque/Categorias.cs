using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    class Categoriasget
    {
        //propriedade descricao
        public string Descricao { get; private set; }

        //seta conteudo na propriedade descricao
        public void SetDescricao(string desc)
        {
            this.Descricao = desc;
        }

        //metodo para gravar a nova categoria no banco de dados
        public void GravarDescricao()
        {
            try
            {
                Conexao.GravarCategoria(Descricao);
                MessageBox.Show("Categoria cadastrada com suscesso!","Cadastro de categorias",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados, tente novamente mais tarde!" + E.Message,"Erro de conexão com o banco de dados!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
