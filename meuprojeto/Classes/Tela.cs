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
            comando.CommandText = "SELECT NomeProduto,CustoProduto FROM tb_produtos";
            DbDataReader reader = DAO.DAOUtils.GetDataReader(comando);
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            return datatable;

        }

        public DataTable CarregarTelaPedido()
        {
            //carregamento das informações dos itens que estão sendo solicitatas

            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT NomeProduto,CustoProduto tb_geral_produtos INNER JOIN tb_produtos ON tb_produtos.IDProduto = tb_geral_produtos.IDGeral ";
            DbDataReader reader = DAO.DAOUtils.GetDataReader(comando);
            DataTable datatable = new DataTable();
            datatable.Load(reader);
            return datatable; 
        }


    }
}
