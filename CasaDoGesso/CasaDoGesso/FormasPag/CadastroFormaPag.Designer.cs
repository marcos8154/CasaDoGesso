namespace CasaDoGesso.FormasPag
{
    partial class CadastroFormaPag
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
            this.txNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txCod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txCod
            // 
            this.txCod.Location = new System.Drawing.Point(60, 11);
            this.txCod.Name = "txCod";
            this.txCod.ReadOnly = true;
            this.txCod.Size = new System.Drawing.Size(67, 20);
            this.txCod.TabIndex = 7;
            this.txCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(60, 38);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(386, 20);
            this.txNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(372, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPesquisar.BackColor = System.Drawing.Color.Indigo;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(12, 156);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = " Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Indigo;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Image = global::CasaDoGesso.Properties.Resources.if_check_13491;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(203, 156);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(82, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "       Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::CasaDoGesso.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(291, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "       Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroFormaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 191);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroFormaPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de forma de pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.txCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txCod;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button button2;
    }
}