using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNDD
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\TesteNDD\TesteNDD.mdf;Integrated Security=True;Connect Timeout=30";
        }
        //Método para Conectar no Banco de Dados
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método para Desconectar do Banco de Dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
