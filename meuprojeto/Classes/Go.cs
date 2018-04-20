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
    //classe separada para utilização de metodos de inserção de infomações no banco de dados 

    public class Go
    {

        public void  InserirNovoProdutoSimples(TiposDeProdutos produto)
        {
            //este metodo é usado para criação de novos cadastros de produtos simples

            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tb_produtos (NomeProduto,CustoProduto,Vendaproduto) VALUES (@NomeProdtuto,@CustoProduto,@VendaProduto)";
            comando.Parameters.Add(new MySqlParameter("@NomeProduto",produto.NomeProduto));
            comando.Parameters.Add(new MySqlParameter("@CustoProduto",produto.CustoProduto));
            comando.Parameters.Add(new MySqlParameter("@VendaProduto",produto.VendaProduto));
            comando.ExecuteNonQuery();

        }








    }
}
