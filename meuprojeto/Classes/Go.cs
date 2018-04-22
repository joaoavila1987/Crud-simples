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
    //classe separada para utilização de metodos de inserção de infomações no banco de dados 

    public class Go
    {

        public void  InserirNovoProdutoSimples(TiposDeProdutos produto)
        {
            //este metodo é usado para criação de novos cadastros de produtos simples

            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tabela_cadastro_produto (NomeProduto,CustoProduto,Vendaproduto) VALUES (@NomeProduto,@CustoProduto,@VendaProduto)";
            comando.Parameters.Add(new SqlParameter("@NomeProduto",produto.NomeProduto));
            comando.Parameters.Add(new SqlParameter("@CustoProduto",produto.CustoProduto));
            comando.Parameters.Add(new SqlParameter("@VendaProduto",produto.VendaProduto));
            comando.ExecuteNonQuery();

        }

        public void InserirDadosPedido(TiposDeProdutos produto)
        {
           
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tabela_pedidos (DataPedido,Funcionario,IDProdutoPedido,CustoPedido) VALUES (@DataPedido,@Funcionario,@IDProdutoPedido,@CustoPedido)";
            comando.Parameters.Add(new SqlParameter("@DataPedido", produto.DadaPedido));
            comando.Parameters.Add(new SqlParameter("@Funcionario", produto.Funcionario));
            comando.Parameters.Add(new SqlParameter("@IDProdutoPedido", produto.IDProdutoPedido));
            comando.Parameters.Add(new SqlParameter("@CustoPedido", produto.CustoPedido));
            comando.ExecuteNonQuery();
        }

       
      








    }
}
