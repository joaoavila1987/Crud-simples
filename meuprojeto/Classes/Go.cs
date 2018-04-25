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
        public void InserirNovoProdutoSimples(TiposDeProdutos produto)
        {
            //este metodo é usado para criação de novos cadastros de produtos simples, tela de cadastro simples 
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tb_produto (NomeProduto,CustoProduto,Vendaproduto,Tipo) VALUES (@NomeProduto,@CustoProduto,@VendaProduto,@Tipo)";
            comando.Parameters.Add(new SqlParameter("@NomeProduto", produto.NomeProduto));
            comando.Parameters.Add(new SqlParameter("@CustoProduto", produto.CustoProduto));
            comando.Parameters.Add(new SqlParameter("@VendaProduto", produto.VendaProduto));
            comando.Parameters.Add(new SqlParameter("@Tipo", produto.Tipo));
            comando.ExecuteNonQuery();
        }
        public void InserirDadosPedido(TiposDeProdutos produto)
        {
            //Este metodo é responsável por preencher a stage4 de saida dos produtos
            //ID,Produto,Und,Custo,SubTotal
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tb_saida_stage4 (IDProdutoS,Produto,Und,Custo,SubTotal,Venda) VALUES (@IDProdutoS,@Produto,@Und,@Custo,@SubTotal,@Venda)";
            comando.Parameters.Add(new SqlParameter("@IDProdutoS", produto.IDProdutoS));
            comando.Parameters.Add(new SqlParameter("@Produto", produto.Produto));
            comando.Parameters.Add(new SqlParameter("@Und", produto.Und));
            comando.Parameters.Add(new SqlParameter("@Custo", produto.Custo));
            comando.Parameters.Add(new SqlParameter("@SubTotal", produto.SubTotal));
            comando.Parameters.Add(new SqlParameter("@Venda", produto.Venda));
            comando.ExecuteNonQuery();
        }
        public void InserirHistoricoSaida(TiposDeProdutos produto)
        {
            //Este metodo é utilizado para guardar as informações finais da saida(histórico)
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tb_saida_history3 (DataPedido,Funcionario,Cod,Produto,Quantidade,Custo,Venda) VALUES (@DataPedido,@Funcionario,@Cod,@ProdutoSaida,@Quantidade,@CustoS,@VendaS)";
            comando.Parameters.Add(new SqlParameter("@DataPedido", produto.DataPedido));
            comando.Parameters.Add(new SqlParameter("@Funcionario", produto.Funcionario));
            comando.Parameters.Add(new SqlParameter("@Cod", produto.Cod));
            comando.Parameters.Add(new SqlParameter("@ProdutoSaida", produto.ProdutoSaida));
            comando.Parameters.Add(new SqlParameter("@Quantidade", produto.Quantidade));
            comando.Parameters.Add(new SqlParameter("@CustoS", produto.CustoS));
            comando.Parameters.Add(new SqlParameter("@VendaS", produto.VendaS));
            comando.ExecuteNonQuery();
        }
        public void InserirFormacaoProdutoComposto(TiposDeProdutos produto)
        {
            //Este metodo é responsável por passar informações entre a tabela de produtos simples para a tabela de formação de produtos compostpos
            DbConnection conexao = DAO.DAOUtils.GetConexao();
            DbCommand comando = DAO.DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO tb_composto_stage3 (Cod,Nome,Und,Custo,Venda) VALUES (@Cod,@Nome,@Und,@Custo,@Venda)";
            comando.Parameters.Add(new SqlParameter("@Cod", produto.Cod));
            comando.Parameters.Add(new SqlParameter("@Und", produto.Und));
            comando.Parameters.Add(new SqlParameter("@Custo", produto.ccusto));
            comando.Parameters.Add(new SqlParameter("@Venda", produto.cvenda));
            comando.ExecuteNonQuery();
        }
        //abaixo vai entrar o metodo Inserir Produto Composto na History
    }
}

