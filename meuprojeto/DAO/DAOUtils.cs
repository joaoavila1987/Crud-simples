using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;



namespace MeuProjeto.DAO
{
    public class DAOUtils
    {

        public static DbConnection GetConexao()
        {
            string OpenConnection = @"Server=.\SQLEXPRESS14;Database=PremierSilo;User Id=sa;Password=@avila#1334$joaoavila;";
            DbConnection conexao = new SqlConnection(OpenConnection);
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }

    }
}
