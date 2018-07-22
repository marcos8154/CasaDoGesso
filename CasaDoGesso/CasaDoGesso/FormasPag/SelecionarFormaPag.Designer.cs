namespace CasaDoGesso.FormasPag
{
    partial class SelecionarFormaPag
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGrid.Location = new System.Drawing.Point(13, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(405, 323);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txPesquisa
            // 
            this.txPesquisa.Location = new System.Drawing.Point(66, 12);
            this.txPesquisa.Name = "txPesquisa";
            this.txPesquisa.Size = new System.Drawing.Size(218, 20);
            this.txPesquisa.TabIndex = 1;
            this.txPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(343, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelecionar.BackColor = System.Drawing.Color.Indigo;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.ForeColor = System.Drawing.Color.White;
            this.btSelecionar.Location = new System.Drawing.Point(262, 367);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Indigo;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(290, 10);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(100, 23);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = " Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // SelecionarFormaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 402);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPesquisa);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecionarFormaPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar forma de pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btPesquisar;
    }
}