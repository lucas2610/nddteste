using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteNDD
{
    public partial class FormDetalhesEmprestimo : Form
    {
        private Form1 form1;
        public int id;
        public String mes;
        public FormDetalhesEmprestimo()
        {
            InitializeComponent();
        }

        public FormDetalhesEmprestimo(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }
        /*Esta função acessa a tabela recebimento no banco de dados e pega os registros
        * associados a o id que foi passado como parâmetro. E então atribui o valor aos labes mostrnado para o
        * usuário as informações.
        */
        public void dadosRecebimento(int idRecebido)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            this.id = idRecebido;
            cmd.CommandText = "select *from recebimento where EmprestimoId=@EmprestimoId";
            cmd.Parameters.Add("@EmprestimoId", SqlDbType.Int).Value = this.id;

            try
            {

                cmd.Connection = conexao.conectar();
                //Executar comando
                SqlDataReader pesquisar = cmd.ExecuteReader();
                if (pesquisar.HasRows == false)
                {
                    throw new Exception("É vazio!");
                }
                while (pesquisar.Read())
                {

                    this.mes = Convert.ToString(pesquisar["MesRecebimento"]);
                    textBoxMesRecebimento.Text += "\r\n"+mes;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
        /*Esta função acessa a tabela emprestimo no banco de dados e pega os registros
         * associados a o id que foi passado como parâmetro. E então atribui o valor aos labes mostrnado para o
         * usuário as informações.
         */
        public void dadosEmprestimo(int idRecebido)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            this.id = idRecebido;
            cmd.CommandText = "select *from emprestimo  where IdEmprestimo=@IdEmprestimo";
            cmd.Parameters.Add("@IdEmprestimo", SqlDbType.Int).Value = this.id;

            try
            {

                cmd.Connection = conexao.conectar();
                //Executar comando
                SqlDataReader pesquisar = cmd.ExecuteReader();
                if (pesquisar.HasRows == false)
                {
                    throw new Exception("É vazio!");
                }
                while (pesquisar.Read())
                {
                  
                    labelNomeAmigo.Text = Convert.ToString(pesquisar["NomeAmigo"]);
                    labelJuros.Text = Convert.ToString(pesquisar["Juros"]);
                    labelValorEmprestado.Text = Convert.ToString(pesquisar["ValorEmprestimo"]);
                    labelDataInicio.Text = Convert.ToString(pesquisar["DataInicio"]);
                    labelDataFim.Text = Convert.ToString(pesquisar["DataRecebimento"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       

        private void FormDetalhesEmprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}
