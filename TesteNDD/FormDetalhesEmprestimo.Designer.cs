namespace TesteNDD
{
    partial class FormDetalhesEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMesRecebimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDataFim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDataInicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelJuros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelValorEmprestado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNomeAmigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMesRecebimento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelDataFim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelDataInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelJuros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.labelValorEmprestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNomeAmigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Emprestimo";
            // 
            // textBoxMesRecebimento
            // 
            this.textBoxMesRecebimento.Location = new System.Drawing.Point(113, 193);
            this.textBoxMesRecebimento.Multiline = true;
            this.textBoxMesRecebimento.Name = "textBoxMesRecebimento";
            this.textBoxMesRecebimento.Size = new System.Drawing.Size(257, 198);
            this.textBoxMesRecebimento.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parcelas do Juro:";
            // 
            // labelDataFim
            // 
            this.labelDataFim.AutoSize = true;
            this.labelDataFim.Location = new System.Drawing.Point(130, 142);
            this.labelDataFim.Name = "labelDataFim";
            this.labelDataFim.Size = new System.Drawing.Size(55, 13);
            this.labelDataFim.TabIndex = 14;
            this.labelDataFim.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data p/ devolução:";
            // 
            // labelDataInicio
            // 
            this.labelDataInicio.AutoSize = true;
            this.labelDataInicio.Location = new System.Drawing.Point(130, 116);
            this.labelDataInicio.Name = "labelDataInicio";
            this.labelDataInicio.Size = new System.Drawing.Size(55, 13);
            this.labelDataInicio.TabIndex = 12;
            this.labelDataInicio.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "em %";
            // 
            // labelJuros
            // 
            this.labelJuros.AutoSize = true;
            this.labelJuros.Location = new System.Drawing.Point(130, 85);
            this.labelJuros.Name = "labelJuros";
            this.labelJuros.Size = new System.Drawing.Size(55, 13);
            this.labelJuros.TabIndex = 9;
            this.labelJuros.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taxa de Juros:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(110, 397);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelValorEmprestado
            // 
            this.labelValorEmprestado.AutoSize = true;
            this.labelValorEmprestado.Location = new System.Drawing.Point(130, 60);
            this.labelValorEmprestado.Name = "labelValorEmprestado";
            this.labelValorEmprestado.Size = new System.Drawing.Size(55, 13);
            this.labelValorEmprestado.TabIndex = 3;
            this.labelValorEmprestado.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Emprestado:";
            // 
            // labelNomeAmigo
            // 
            this.labelNomeAmigo.AutoSize = true;
            this.labelNomeAmigo.Location = new System.Drawing.Point(130, 33);
            this.labelNomeAmigo.Name = "labelNomeAmigo";
            this.labelNomeAmigo.Size = new System.Drawing.Size(55, 13);
            this.labelNomeAmigo.TabIndex = 1;
            this.labelNomeAmigo.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Amigo: ";
            // 
            // FormDetalhesEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDetalhesEmprestimo";
            this.Text = "FormDetalhesEmprestimo";
            this.Load += new System.EventHandler(this.FormDetalhesEmprestimo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValorEmprestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNomeAmigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxMesRecebimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDataFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDataInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelJuros;
        private System.Windows.Forms.Label label2;
    }
}