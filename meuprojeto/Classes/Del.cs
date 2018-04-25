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
            //Metodo usado para excluir produtos do cadastro de produtos simples.
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tb_produto WHERE IDProduto = @IDProduto";
            comando.Parameters.Add(new SqlParameter("@IDProduto", id));
            comando.ExecuteNonQuery();
        }
        public void ExcluirProdutoDoPedido(int id)
        {
            //Este metodo eu uso para apagar um produto indesejado que esteja no meu pedido.
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tb_saida_stage4 WHERE ID = @ID ";
            comando.Parameters.Add(new SqlParameter("@ID",id));
            comando.ExecuteNonQuery();
        }
        public void LimparTabelaPedido()
        {
            //Estou usando este metodo para limpar a tabela temporária de saida de produtos após eles serem enviados apra a tabela de histórico.
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tb_saida_stage4";
            comando.ExecuteNonQuery();
        }
       public void ExcluirFormacaoDeComposto(int id)
        {
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tb_composto_stage2 WHERE Cod = @Cod";
            comando.Parameters.Add(new SqlParameter("@Cod", id));
            comando.ExecuteNonQuery();
        }

    }
}
