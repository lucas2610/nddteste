namespace TesteNDD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVisualizarRecebimento = new System.Windows.Forms.Button();
            this.buttonReceber = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.textBoxValorEmprestado = new System.Windows.Forms.TextBox();
            this.textBoxNomeAmigo = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxListaEmprestimos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(103, 117);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(238, 20);
            this.dateTimePickerDataInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVisualizarRecebimento);
            this.groupBox1.Controls.Add(this.buttonReceber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxJuros);
            this.groupBox1.Controls.Add(this.textBoxValorEmprestado);
            this.groupBox1.Controls.Add(this.textBoxNomeAmigo);
            this.groupBox1.Controls.Add(this.textBoxNumero);
            this.groupBox1.Controls.Add(this.buttonPesquisar);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.dateTimePickerDataFim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerDataInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Empréstimos";
            // 
            // buttonVisualizarRecebimento
            // 
            this.buttonVisualizarRecebimento.Location = new System.Drawing.Point(113, 203);
            this.buttonVisualizarRecebimento.Name = "buttonVisualizarRecebimento";
            this.buttonVisualizarRecebimento.Size = new System.Drawing.Size(202, 23);
            this.buttonVisualizarRecebimento.TabIndex = 19;
            this.buttonVisualizarRecebimento.Text = "Visualizar Parcelas Recebidas";
            this.buttonVisualizarRecebimento.UseVisualStyleBackColor = true;
            this.buttonVisualizarRecebimento.Click += new System.EventHandler(this.buttonVisualizarRecebimento_Click);
            // 
            // buttonReceber
            // 
            this.buttonReceber.Location = new System.Drawing.Point(-1, 202);
            this.buttonReceber.Name = "buttonReceber";
            this.buttonReceber.Size = new System.Drawing.Size(104, 23);
            this.buttonReceber.TabIndex = 18;
            this.buttonReceber.Text = "Receber Parcela";
            this.buttonReceber.UseVisualStyleBackColor = true;
            this.buttonReceber.Click += new System.EventHandler(this.buttonReceber_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "% ao mês";
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.Location = new System.Drawing.Point(103, 91);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.Size = new System.Drawing.Size(114, 20);
            this.textBoxJuros.TabIndex = 16;
            // 
            // textBoxValorEmprestado
            // 
            this.textBoxValorEmprestado.Location = new System.Drawing.Point(103, 65);
            this.textBoxValorEmprestado.Name = "textBoxValorEmprestado";
            this.textBoxValorEmprestado.Size = new System.Drawing.Size(238, 20);
            this.textBoxValorEmprestado.TabIndex = 15;
            // 
            // textBoxNomeAmigo
            // 
            this.textBoxNomeAmigo.Location = new System.Drawing.Point(103, 39);
            this.textBoxNomeAmigo.Name = "textBoxNomeAmigo";
            this.textBoxNomeAmigo.Size = new System.Drawing.Size(238, 20);
            this.textBoxNomeAmigo.TabIndex = 14;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(103, 16);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 13;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(240, 173);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 12;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(321, 173);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(161, 173);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 10;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(80, 173);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(-1, 173);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(103, 141);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(238, 20);
            this.dateTimePickerDataFim.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data p/devolução:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data de início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taxa de Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Emprestado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Amigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxListaEmprestimos);
            this.groupBox2.Location = new System.Drawing.Point(460, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Emprestimos";
            // 
            // textBoxListaEmprestimos
            // 
            this.textBoxListaEmprestimos.Location = new System.Drawing.Point(7, 20);
            this.textBoxListaEmprestimos.Multiline = true;
            this.textBoxListaEmprestimos.Name = "textBoxListaEmprestimos";
            this.textBoxListaEmprestimos.Size = new System.Drawing.Size(257, 215);
            this.textBoxListaEmprestimos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 290);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxJuros;
        private System.Windows.Forms.TextBox textBoxValorEmprestado;
        private System.Windows.Forms.TextBox textBoxNomeAmigo;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonVisualizarRecebimento;
        private System.Windows.Forms.Button buttonReceber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxListaEmprestimos;
    }
}

