namespace CasaDoGesso.Clientes
{
    partial class CadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txCod = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.txCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfCnpj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txMunicipio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txUF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txCod
            // 
            this.txCod.Location = new System.Drawing.Point(110, 15);
            this.txCod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txCod.Name = "txCod";
            this.txCod.ReadOnly = true;
            this.txCod.Size = new System.Drawing.Size(62, 20);
            this.txCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNome.Location = new System.Drawing.Point(110, 41);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(363, 20);
            this.txNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo pessoa";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Location = new System.Drawing.Point(110, 68);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(177, 21);
            this.cbTipoPessoa.TabIndex = 2;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // txCpfCnpj
            // 
            this.txCpfCnpj.Location = new System.Drawing.Point(110, 96);
            this.txCpfCnpj.Mask = "00,000,000/0000-00";
            this.txCpfCnpj.Name = "txCpfCnpj";
            this.txCpfCnpj.Size = new System.Drawing.Size(177, 20);
            this.txCpfCnpj.TabIndex = 3;
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.AutoSize = true;
            this.lbCpfCnpj.Location = new System.Drawing.Point(13, 99);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCpfCnpj.TabIndex = 7;
            this.lbCpfCnpj.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // txTelefone
            // 
            this.txTelefone.Location = new System.Drawing.Point(110, 123);
            this.txTelefone.Mask = "(00) 0000-0000";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(177, 20);
            this.txTelefone.TabIndex = 4;
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(110, 149);
            this.txCelular.Mask = "(00) 00000-0000";
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(177, 20);
            this.txCelular.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Celular";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(110, 175);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(363, 20);
            this.txEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // txLogradouro
            // 
            this.txLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txLogradouro.Location = new System.Drawing.Point(110, 227);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(363, 20);
            this.txLogradouro.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Logradouro";
            // 
            // txBairro
            // 
            this.txBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txBairro.Location = new System.Drawing.Point(110, 253);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(363, 20);
            this.txBairro.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bairro";
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(110, 305);
            this.txNumero.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(62, 20);
            this.txNumero.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "CEP";
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(110, 201);
            this.txCEP.Mask = "00.000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(97, 20);
            this.txCEP.TabIndex = 7;
            this.txCEP.Leave += new System.EventHandler(this.txCEP_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Buscar CEP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(398, 389);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 23;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txMunicipio
            // 
            this.txMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMunicipio.Location = new System.Drawing.Point(110, 279);
            this.txMunicipio.Name = "txMunicipio";
            this.txMunicipio.Size = new System.Drawing.Size(363, 20);
            this.txMunicipio.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Município";
            // 
            // txUF
            // 
            this.txUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txUF.Location = new System.Drawing.Point(223, 305);
            this.txUF.MaxLength = 2;
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(32, 20);
            this.txUF.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "UF";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::CasaDoGesso.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(317, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "      Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Indigo;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(12, 389);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(83, 23);
            this.btPesquisar.TabIndex = 24;
            this.btPesquisar.Text = "    Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Indigo;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = global::CasaDoGesso.Properties.Resources.if_check_13491;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(228, 389);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 23);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "      Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txUF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txMunicipio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txCEP);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txLogradouro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCpfCnpj);
            this.Controls.Add(this.txCpfCnpj);
            this.Controls.Add(this.cbTipoPessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.txCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.MaskedTextBox txCpfCnpj;
        private System.Windows.Forms.Label lbCpfCnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.MaskedTextBox txCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txMunicipio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txUF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}