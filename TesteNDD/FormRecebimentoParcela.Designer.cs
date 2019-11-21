namespace TesteNDD
{
    partial class FormRecebimentoParcela
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRecebeParcela = new System.Windows.Forms.Button();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorParcela = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonRecebeParcela);
            this.groupBox1.Controls.Add(this.comboBoxMes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelValorParcela);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recebimento Parcela";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(119, 127);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRecebeParcela
            // 
            this.buttonRecebeParcela.Location = new System.Drawing.Point(12, 128);
            this.buttonRecebeParcela.Name = "buttonRecebeParcela";
            this.buttonRecebeParcela.Size = new System.Drawing.Size(75, 23);
            this.buttonRecebeParcela.TabIndex = 6;
            this.buttonRecebeParcela.Text = "Ok";
            this.buttonRecebeParcela.UseVisualStyleBackColor = true;
            this.buttonRecebeParcela.Click += new System.EventHandler(this.buttonRecebeParcela_Click);
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(106, 91);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(222, 21);
            this.comboBoxMes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mês da Parcela";
            // 
            // labelValorParcela
            // 
            this.labelValorParcela.AutoSize = true;
            this.labelValorParcela.Location = new System.Drawing.Point(56, 60);
            this.labelValorParcela.Name = "labelValorParcela";
            this.labelValorParcela.Size = new System.Drawing.Size(55, 13);
            this.labelValorParcela.TabIndex = 3;
            this.labelValorParcela.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(56, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // FormRecebimentoParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRecebimentoParcela";
            this.Text = "FormRecebimentoParcela";
            this.Load += new System.EventHandler(this.FormRecebimentoParcela_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRecebeParcela;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorParcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
    }
}