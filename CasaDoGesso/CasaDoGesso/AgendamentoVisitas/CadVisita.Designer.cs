namespace CasaDoGesso.AgendamentoVisitas
{
    partial class CadVisita
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodCliente = new System.Windows.Forms.NumericUpDown();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.TextBox();
            this.txCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txMunicipio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txMotivo = new System.Windows.Forms.TextBox();
            this.txData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btSelecionarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txCodCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(510, 300);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cliente";
            // 
            // txCodCliente
            // 
            this.txCodCliente.Location = new System.Drawing.Point(80, 11);
            this.txCodCliente.Name = "txCodCliente";
            this.txCodCliente.Size = new System.Drawing.Size(75, 20);
            this.txCodCliente.TabIndex = 27;
            this.txCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodCliente_KeyDown);
            // 
            // txNomeCliente
            // 
            this.txNomeCliente.Location = new System.Drawing.Point(239, 11);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.ReadOnly = true;
            this.txNomeCliente.Size = new System.Drawing.Size(346, 20);
            this.txNomeCliente.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Telefone";
            // 
            // txTelefone
            // 
            this.txTelefone.Location = new System.Drawing.Point(80, 37);
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.ReadOnly = true;
            this.txTelefone.Size = new System.Drawing.Size(143, 20);
            this.txTelefone.TabIndex = 31;
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(281, 38);
            this.txCelular.Name = "txCelular";
            this.txCelular.ReadOnly = true;
            this.txCelular.Size = new System.Drawing.Size(143, 20);
            this.txCelular.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Celular";
            // 
            // txLogradouro
            // 
            this.txLogradouro.Location = new System.Drawing.Point(80, 63);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.ReadOnly = true;
            this.txLogradouro.Size = new System.Drawing.Size(344, 20);
            this.txLogradouro.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Logradouro";
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(80, 89);
            this.txBairro.Name = "txBairro";
            this.txBairro.ReadOnly = true;
            this.txBairro.Size = new System.Drawing.Size(344, 20);
            this.txBairro.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Bairro";
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(484, 63);
            this.txNumero.Name = "txNumero";
            this.txNumero.ReadOnly = true;
            this.txNumero.Size = new System.Drawing.Size(75, 20);
            this.txNumero.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Número";
            // 
            // txMunicipio
            // 
            this.txMunicipio.Location = new System.Drawing.Point(80, 115);
            this.txMunicipio.Name = "txMunicipio";
            this.txMunicipio.ReadOnly = true;
            this.txMunicipio.Size = new System.Drawing.Size(344, 20);
            this.txMunicipio.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Município";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txMotivo);
            this.groupBox1.Controls.Add(this.txData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 140);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do agendamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Motivo";
            // 
            // txMotivo
            // 
            this.txMotivo.Location = new System.Drawing.Point(76, 57);
            this.txMotivo.Multiline = true;
            this.txMotivo.Name = "txMotivo";
            this.txMotivo.Size = new System.Drawing.Size(491, 52);
            this.txMotivo.TabIndex = 2;
            // 
            // txData
            // 
            this.txData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txData.Location = new System.Drawing.Point(76, 31);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(125, 20);
            this.txData.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data/Hora";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::CasaDoGesso.Properties.Resources.add;
            this.button2.Location = new System.Drawing.Point(200, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 20);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSelecionarCliente
            // 
            this.btSelecionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelecionarCliente.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.btSelecionarCliente.Location = new System.Drawing.Point(161, 11);
            this.btSelecionarCliente.Name = "btSelecionarCliente";
            this.btSelecionarCliente.Size = new System.Drawing.Size(33, 20);
            this.btSelecionarCliente.TabIndex = 43;
            this.btSelecionarCliente.UseVisualStyleBackColor = true;
            this.btSelecionarCliente.Click += new System.EventHandler(this.btSelecionarCliente_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.button1.Location = new System.Drawing.Point(161, -73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.BackColor = System.Drawing.Color.Indigo;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = global::CasaDoGesso.Properties.Resources.if_check_13491;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(421, 300);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 23);
            this.btSalvar.TabIndex = 24;
            this.btSalvar.Text = "      Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSelecionarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txMunicipio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txLogradouro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNomeCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txCodCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento de visita";
            ((System.ComponentModel.ISupportInitialize)(this.txCodCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txCodCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTelefone;
        private System.Windows.Forms.TextBox txCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txMunicipio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txMotivo;
        private System.Windows.Forms.Button btSelecionarCliente;
        private System.Windows.Forms.Button button2;
    }
}