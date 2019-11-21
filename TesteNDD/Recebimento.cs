using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteNDD
{
    public class Recebimento
    {
        public int Numero { get; set; }
        public String MesParcela { get; set; }

        /*Esta função cadastra na tabela recebimento no banco de dados, 
         * o mês que o pagamento da parcela do juro foi efetuado.
        */
        public void CadastraRecebimento(int id, String mes)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            String mensagem = "";

            cmd.CommandText = "insert into recebimento(MesRecebimento, EmprestimoId) " +
                "values(@MesRecebimento, @EmprestimoId)";

            cmd.Parameters.Add("@MesRecebimento", SqlDbType.VarChar).Value = mes;
            cmd.Parameters.Add("@EmprestimoId", SqlDbType.Int).Value = id;
           
            //Conectar com o bd---Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();



                //Mostrar msg erro ou sucesso---variável
                mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException ex)
            {
                mensagem = "Erro no cadastro";
            }
            finally
            {
                //Desconectar
                conexao.desconectar();
            }
           
            MessageBox.Show(mensagem);
        }
        /*Esta função exclui os registros na tabela recebimento no banco de dados.
         * 
        */
        public void ExcluirRecebimento(int id)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from recebimento where EmprestimoId=@EmprestimoId";
            cmd.Parameters.Add("@EmprestimoId", SqlDbType.Int).Value = id;
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
     }
}