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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
        }
      

       
        Emprestimo emprestimo = new Emprestimo();
        private Emprestimo[] emprestimos = new Emprestimo[100];
        private int numeroEmprestimos;
        private void Form1_Load(object sender, EventArgs e)
        {
           pegaDadosBanco();
           
        }
        /*Esta função permite salvar em um vetor os registros da tabela emprestimo no banco de dados.
         * Ela então coloca os dados em textBox para o usuário poder visualizar.
        */
        public void adicionarEmprestimo(Emprestimo emprestimo)
        {
            this.emprestimos[this.numeroEmprestimos] = emprestimo;
            this.numeroEmprestimos++;
            textBoxListaEmprestimos.Text += " "+"\r\nNumero: " + emprestimo.Numero +" Nome do Amigo: "+emprestimo.NomeAmigo;
           
        }
        /*Esta função pega todos os registros da tabela emprestimo no banco de dados.
         * E exibe eles para o usuário.
        * Ela retorna mensagem de aviso avisando se a operação foi bem sucedida ou não.
        */
        public void pegaDadosBanco()
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from emprestimo";
           

            try
            {
               
                cmd.Connection = conexao.conectar();
                //Executar comando
                SqlDataReader pesquisar = cmd.ExecuteReader();
                if (pesquisar.HasRows == false)
                {
                    throw new Exception("É vazio!");
                }
                int id=0;
                String NomeAmigo = "";
                while (pesquisar.Read())
                {
                   id = Convert.ToInt32(pesquisar["IdEmprestimo"]);
                   NomeAmigo = Convert.ToString(pesquisar["NomeAmigo"]);
                    emprestimo.Numero = id;
                    emprestimo.NomeAmigo = NomeAmigo;
                    this.adicionarEmprestimo(emprestimo);
                  
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
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxJuros.Text==string.Empty || textBoxNomeAmigo.Text==string.Empty || textBoxValorEmprestado.Text==string.Empty || dateTimePickerDataFim.Text ==string.Empty || dateTimePickerDataInicio.Text==string.Empty)
            {
                MessageBox.Show("Os campos não podem ser nulos!");
            }
            else
            {
                if (Convert.ToDateTime(dateTimePickerDataInicio.Text) >= Convert.ToDateTime(dateTimePickerDataFim.Text))
                {
                    MessageBox.Show("A data final deve ser maior que a inicial");
                }
                else
                {
                    emprestimo.Cadstrar(textBoxNomeAmigo.Text, Convert.ToSingle(textBoxValorEmprestado.Text), Convert.ToSingle(textBoxJuros.Text), Convert.ToDateTime(dateTimePickerDataInicio.Text), Convert.ToDateTime(dateTimePickerDataFim.Text));
                    textBoxListaEmprestimos.Text = "";
                    pegaDadosBanco();
                }
            }
           
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o numero do emprestimo que deseja pesquisar");
            }
            else
            {
                Conexao conexao = new Conexao();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select *from emprestimo where IdEmprestimo=@IdEmprestimo";
                cmd.Parameters.Add("@IdEmprestimo", SqlDbType.Int).Value = textBoxNumero.Text;

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
                        textBoxNumero.Text = Convert.ToString(pesquisar["IdEmprestimo"]);
                        textBoxNomeAmigo.Text = Convert.ToString(pesquisar["NomeAmigo"]);
                        textBoxJuros.Text = Convert.ToString(pesquisar["Juros"]);
                        textBoxValorEmprestado.Text = Convert.ToString(pesquisar["ValorEmprestimo"]);
                        dateTimePickerDataInicio.Value = Convert.ToDateTime(pesquisar["DataInicio"]);
                        dateTimePickerDataFim.Value = Convert.ToDateTime(pesquisar["DataRecebimento"]);
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
           
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o numero do emprestimo que deseja editar");
            }
            else
            {
               
                emprestimo.Editar(Convert.ToInt32(textBoxNumero.Text),Convert.ToString(textBoxNomeAmigo.Text),Convert.ToSingle(textBoxValorEmprestado.Text),Convert.ToSingle(textBoxJuros.Text),Convert.ToDateTime(dateTimePickerDataInicio.Text),Convert.ToDateTime(dateTimePickerDataFim.Text));
                textBoxListaEmprestimos.Text = "";
                pegaDadosBanco();
            }
           
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o numero do emprestimo que deseja excluir");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Excluir?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    MessageBox.Show("Operação Cancelada!");
                }
                else
                {
                    Recebimento recebimento = new Recebimento();
                    recebimento.ExcluirRecebimento(Convert.ToInt32(textBoxNumero.Text));
                    emprestimo.Excluir(Convert.ToInt32(textBoxNumero.Text));
                    textBoxListaEmprestimos.Text = "";
                    pegaDadosBanco();
                    
                }
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxJuros.Text = "";
            textBoxNomeAmigo.Text = "";
            textBoxNumero.Text = "";
            dateTimePickerDataFim.Text = "";
            dateTimePickerDataInicio.Text = "";
            textBoxValorEmprestado.Text = "";

        }

        private void buttonReceber_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o numero do emprestimo que deseja receber o pagamento");
            }
            else
            {
                FormRecebimentoParcela formRecebimentoParcela = new FormRecebimentoParcela(this);
                formRecebimentoParcela.RecebeId(Convert.ToInt32(textBoxNumero.Text));
                formRecebimentoParcela.ShowDialog();
            }
            
        }

        private void buttonVisualizarRecebimento_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o numero do emprestimo que deseja Visualizar os detalhes do emprestimo");
            }
            else
            {
                FormDetalhesEmprestimo formDetalhesEmprestimo = new FormDetalhesEmprestimo(this);
                formDetalhesEmprestimo.dadosEmprestimo(Convert.ToInt32(textBoxNumero.Text));
                formDetalhesEmprestimo.dadosRecebimento(Convert.ToInt32(textBoxNumero.Text));
                formDetalhesEmprestimo.ShowDialog();
            }
           
        }
    }

   
}
