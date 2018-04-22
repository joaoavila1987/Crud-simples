using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace MeuProjeto.Classes
{

    //Esta classe reservei para colocar os metodos responsáveis pos visualização de dados no DataGrid


    public class Tela
    {
        //metodo de carregamento de produtos que estão na tela de pedido

        public DataTable CarregarMenuPedido()
        {
            // carregamento das informações da tabela de produtos.

            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT IDProduto,NomeProduto,CustoProduto FROM tabela_cadastro_produto";
            DbDataReader reader = DAO.DAOUtils.GetDataReader(comando);
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            return datatable;

        }

        public DataTable CarregarProdutosPedidos()
        {
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = @"SELECT tabela_cadastro_produto.IDProduto,tabela_cadastro_produto.NomeProduto,tabela_cadastro_produto.QuantidadeProduto,tabela_cadastro_produto.CustoProduto
                                  FROM tabela_cadastro_produto
                                  INNER JOIN tabela_pedidos
                                  ON tabela_pedidos.IDProdutoPedido = tabela_cadastro_produto.IDProduto";
            DbDataReader reader = DAO.DAOUtils.GetDataReader(comando);
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            return datatable;
        }

     


    }
}
