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
    public class Emprestimo
    {
        public int Numero {get; set; }
        public String NomeAmigo { get; set; }
        public float ValorEmprestimo { get; set; }
        public float Juros { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        /*Esta função permite cadastrar na tabela emprestimo no banco de dados.
         * Ela retorna mensagem de aviso avisando se a operação foi bem sucedida ou não.
         */
        public void Cadstrar(String nomeAmigo,float valorEmprestimo, float juros, DateTime dataInicio, DateTime dataFim)
        {
            String mensagem = "";
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert into emprestimo(NomeAmigo,ValorEmprestimo, Juros, DataInicio, DataRecebimento) " +
                "values(@NomeAmigo,@ValorEmprestimo, @Juros, @DataInicio, @DataRecebimento)";

            cmd.Parameters.Add("@NomeAmigo", SqlDbType.VarChar).Value = nomeAmigo;
            cmd.Parameters.Add("@ValorEmprestimo", SqlDbType.Float).Value = valorEmprestimo;
            cmd.Parameters.Add("@Juros", SqlDbType.Float).Value = juros;
            cmd.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = dataInicio;
            cmd.Parameters.Add("@DataRecebimento", SqlDbType.DateTime).Value = dataFim;
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
        /*Esta função permite excluir os registros da tabela emprestimo no banco de dados.
        * Ela retorna mensagem de aviso avisando se a operação foi bem sucedida ou não.
        */
        public void Excluir(int id)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from emprestimo where IdEmprestimo=@IdEmprestimo";
            cmd.Parameters.Add("@IdEmprestimo", SqlDbType.Int).Value = id;
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluido com Sucesso!");

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
        /*Esta função permite editar os registros da tabela emprestimo no banco de dados.
        * Ela retorna mensagem de aviso avisando se a operação foi bem sucedida ou não.
        */
        public void Editar(int id, String nomeAmigo,float valorEmprestimo, float juros, DateTime dataInicio, DateTime dataFim)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update emprestimo set NomeAmigo=@NomeAmigo, ValorEmprestimo=@ValorEmprestimo" +
            ",Juros=@Juros, DataInicio=@DataInicio, Datarecebimento=@DataRecebimento " +
            "where IdEmprestimo=@IdEmprestimo";
            cmd.Parameters.Add("@IdEmprestimo", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@NomeAmigo", SqlDbType.VarChar).Value = nomeAmigo;
            cmd.Parameters.Add("@ValorEmprestimo", SqlDbType.Float).Value = valorEmprestimo;
            cmd.Parameters.Add("@Juros", SqlDbType.Float).Value = juros;
            cmd.Parameters.Add("@DataInicio", SqlDbType.DateTime).Value = dataInicio;
            cmd.Parameters.Add("@DataRecebimento", SqlDbType.DateTime).Value = dataFim;

            try
            {

                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso!");



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
