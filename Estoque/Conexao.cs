using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Estoque
{
    class Conexao
    {
        //cria a conexao com o banco de dados
        public static SqlConnection Conectar()
        {
            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Estoque"].ToString());

            return Con;
        }

        //realiza o cadastro de categoria no banco de dados
        internal static void GravarCategoria(string descricao)
        {
            SqlConnection con = Conectar();
            con.Open();

            SqlCommand Cmd = new SqlCommand("INSERT INTO TB_CATEGORIA VALUES(@DESCRICAO)", con);
            Cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            Cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
