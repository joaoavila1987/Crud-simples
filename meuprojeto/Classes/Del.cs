using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace MeuProjeto.Classes
{
    //classe dedicada aos metodos de exclusão de informações 

    public class Del
    {
        public void ExluirProdutoSimples(int id)
        {
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tabela_cadastro_produto WHERE IDProduto = @IDProduto";
            comando.Parameters.Add(new SqlParameter("@IDProduto", id));
            comando.ExecuteNonQuery();

        }

    }
}
