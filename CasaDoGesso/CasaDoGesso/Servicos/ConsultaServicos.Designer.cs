namespace CasaDoGesso.Servicos
{
    partial class ConsultaServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txDataFim = new System.Windows.Forms.DateTimePicker();
            this.txDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSelecionarCliente = new System.Windows.Forms.Button();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.txCodCliente = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodCliente)).BeginInit();
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
            this.dataGrid.TabIndex = 11;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Valor (R$)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.BackColor = System.Drawing.Color.Indigo;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.ForeColor = System.Drawing.Color.White;
            this.btBuscar.Image = global::CasaDoGesso.Properties.Resources.if_system_search_1187971;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(692, 12);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.Text = "    Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "De";
            // 
            // txDataFim
            // 
            this.txDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataFim.Location = new System.Drawing.Point(174, 13);
            this.txDataFim.Name = "txDataFim";
            this.txDataFim.Size = new System.Drawing.Size(100, 20);
            this.txDataFim.TabIndex = 17;
            this.txDataFim.Value = new System.DateTime(2018, 7, 22, 0, 0, 0, 0);
            // 
            // txDataInicio
            // 
            this.txDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txDataInicio.Location = new System.Drawing.Point(39, 13);
            this.txDataInicio.Name = "txDataInicio";
            this.txDataInicio.Size = new System.Drawing.Size(100, 20);
            this.txDataInicio.TabIndex = 16;
            this.txDataInicio.Value = new System.DateTime(2018, 7, 22, 0, 0, 0, 0);
            // 
            // btAlterar
            // 
            this.btAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlterar.Location = new System.Drawing.Point(131, 356);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(107, 23);
            this.btAlterar.TabIndex = 15;
            this.btAlterar.Text = "Alterar Serviço";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNovo.BackColor = System.Drawing.Color.Indigo;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.ForeColor = System.Drawing.Color.Snow;
            this.btNovo.Image = global::CasaDoGesso.Properties.Resources.add;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(244, 356);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(111, 23);
            this.btNovo.TabIndex = 14;
            this.btNovo.Text = "     Novo serviço";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(697, 356);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(70, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluir.Image = global::CasaDoGesso.Properties.Resources.delete;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(12, 356);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(115, 23);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "       Excluir serviço";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSelecionarCliente
            // 
            this.btSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelecionarCliente.Image = global::CasaDoGesso.Properties.Resources.if_system_search_118797;
            this.btSelecionarCliente.Location = new System.Drawing.Point(388, 13);
            this.btSelecionarCliente.Name = "btSelecionarCliente";
            this.btSelecionarCliente.Size = new System.Drawing.Size(33, 20);
            this.btSelecionarCliente.TabIndex = 65;
            this.btSelecionarCliente.UseVisualStyleBackColor = true;
            this.btSelecionarCliente.Click += new System.EventHandler(this.btSelecionarCliente_Click);
            // 
            // txNomeCliente
            // 
            this.txNomeCliente.Location = new System.Drawing.Point(427, 13);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.ReadOnly = true;
            this.txNomeCliente.Size = new System.Drawing.Size(238, 20);
            this.txNomeCliente.TabIndex = 64;
            // 
            // txCodCliente
            // 
            this.txCodCliente.Location = new System.Drawing.Point(332, 13);
            this.txCodCliente.Name = "txCodCliente";
            this.txCodCliente.Size = new System.Drawing.Size(50, 20);
            this.txCodCliente.TabIndex = 63;
            this.txCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodCliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cliente";
            // 
            // ConsultaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.Controls.Add(this.btSelecionarCliente);
            this.Controls.Add(this.txNomeCliente);
            this.Controls.Add(this.txCodCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDataFim);
            this.Controls.Add(this.txDataInicio);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Name = "ConsultaServicos";
            this.Text = "Consulta básica de servicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCodCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txDataFim;
        private System.Windows.Forms.DateTimePicker txDataInicio;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSelecionarCliente;
        private System.Windows.Forms.TextBox txNomeCliente;
        private System.Windows.Forms.NumericUpDown txCodCliente;
        private System.Windows.Forms.Label label3;
    }
}