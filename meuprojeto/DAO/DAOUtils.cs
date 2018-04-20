using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;



namespace MeuProjeto.DAO
{
    public class DAOUtils
    {

        public static DbConnection GetConexao()
        {
            string OpenConnection = @"server=localhost;user id=root;password=@avila#1334$;persistsecurityinfo=True;port=3306;database=superbase;SslMode=none;";
            DbConnection conexao = new MySqlConnection(OpenConnection);
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
