namespace CasaDoGesso.Orcamentos
{
    partial class ConsultaOrcamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txDataFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
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
            this.Column2,
            this.Column3});
            this.dataGrid.Location = new System.Drawing.Point(12, 39);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(755, 311);
            this.dataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Data";
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Cliente";
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Valor (R$)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluir.Location = new System.Drawing.Point(12, 356);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(115, 23);
            this.btExcluir.TabIndex = 1;
            this.btExcluir.Text = "Excluir orçamento";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(697, 356);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(70, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.BackColor = System.Drawing.Color.Indigo;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.ForeColor = System.Drawing.Color.Snow;
            this.btNovo.Location = new System.Drawing.Point(656, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(111, 23);
            this.btNovo.TabIndex = 3;
            this.btNovo.Text = "Novo orçamento";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlterar.Location = new System.Drawing.Point(543, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(107, 23);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "Alterar Orçamento";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txDataInicio
            // 
            this.txDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataInicio.Location = new System.Drawing.Point(39, 13);
            this.txDataInicio.Name = "txDataInicio";
            this.txDataInicio.Size = new System.Drawing.Size(100, 20);
            this.txDataInicio.TabIndex = 5;
            this.txDataInicio.Value = new System.DateTime(2018, 7, 22, 0, 0, 0, 0);
            // 
            // txDataFim
            // 
            this.txDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataFim.Location = new System.Drawing.Point(174, 13);
            this.txDataFim.Name = "txDataFim";
            this.txDataFim.Size = new System.Drawing.Size(100, 20);
            this.txDataFim.TabIndex = 6;
            this.txDataFim.Value = new System.DateTime(2018, 7, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Até";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Indigo;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Location = new System.Drawing.Point(280, 11);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // ConsultaOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDataFim);
            this.Controls.Add(this.txDataInicio);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.Name = "ConsultaOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta rápida de orçamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DateTimePicker txDataInicio;
        private System.Windows.Forms.DateTimePicker txDataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}