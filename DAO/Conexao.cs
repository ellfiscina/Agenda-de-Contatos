using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendadeContatos.DAO
{
    class Conexao
    {
        public static string MontarStringConexao()
        {
            string servidor = "localhost";
            string banco = "agendabd";
            string usuario = "root";
            string senha = "root";

            string stringConexao = ("server="+servidor+";database="+banco+";user="+usuario+";password="+senha);

            return stringConexao;
        }
        
        public static MySqlConnection GetConexao()
        {
            MySqlConnection con = new MySqlConnection();
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.ConnectionString = MontarStringConexao();
                        con.Open();
                        return con;
                    }
                    else
                    {
                        con.Open();
                        return con;
                    }
                }
                catch (MySqlException)
                {
                    return GetConexao();
                }
        }
        public static DataTable ExecutaComando(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, GetConexao());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
