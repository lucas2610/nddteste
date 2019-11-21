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
    public partial class FormRecebimentoParcela : Form
    {
        private Form1 form1;

       
        public int id=0;
        public float juros=0;
        public float valorEmprestiomo;
        public float valorParcelaComJuro = 0;
        public String mesRecebimento = "";
        public FormRecebimentoParcela(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            AdicionarMes();
        }
        public void AdicionarMes()
        {
            comboBoxMes.Items.Add("Janeiro");
            comboBoxMes.Items.Add("Fevereiro");
            comboBoxMes.Items.Add("Março");
            comboBoxMes.Items.Add("Abril");
            comboBoxMes.Items.Add("Maio");
            comboBoxMes.Items.Add("Junho");
            comboBoxMes.Items.Add("Julho");
            comboBoxMes.Items.Add("Agosto");
            comboBoxMes.Items.Add("Setembro");
            comboBoxMes.Items.Add("Outubro");
            comboBoxMes.Items.Add("Novembro");
            comboBoxMes.Items.Add("Dezembro");


        }
        /*Esta função acessa a tabela emprestimo no banco de dados e pega os registros
        * associados a o id que foi passado como parâmetro. E então atribui o valor aos labes mostrnado para o
        * usuário as informações.Ela também faz o cálculo da parcela do juro.
        */
        public void RecebeId(int idRecebido)
        {
            this.id = idRecebido;

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select *from emprestimo where IdEmprestimo=@IdEmprestimo";
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
                   
                   labelNome.Text = Convert.ToString(pesquisar["NomeAmigo"]);
                   this.juros = Convert.ToSingle(pesquisar["Juros"]);
                   this.valorEmprestiomo = Convert.ToSingle(pesquisar["ValorEmprestimo"]);
                   this.valorParcelaComJuro =  (this.valorEmprestiomo * (this.juros/100));
                   labelValorParcela.Text =Convert.ToString(this.valorParcelaComJuro);
                    
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
        
        private void FormRecebimentoParcela_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRecebeParcela_Click(object sender, EventArgs e)
        {
            Recebimento recebimento = new Recebimento();
            
            recebimento.CadastraRecebimento(this.id,Convert.ToString(comboBoxMes.Text));
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
