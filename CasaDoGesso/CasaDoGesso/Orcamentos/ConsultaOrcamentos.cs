using BLL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDoGesso.Orcamentos
{
    public partial class ConsultaOrcamentos : Form
    {
        public ConsultaOrcamentos()
        {
            InitializeComponent();


            txDataInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
            txDataFim.Value = DateTime.Now;

            dataGrid.AplicarPadroesDataGrid();
            Buscar();
        }

        private void Buscar()
        {
            OrcamentoBLL bll = new OrcamentoBLL();
            List<Vw_Orcamento> list = bll.GetOrcamentosView(txDataInicio.Value.Date,
                txDataFim.Value.Date);

            dataGrid.DataSource = list;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            CadOrcamento cad = new CadOrcamento();
            cad.ShowDialog();

            Buscar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            Vw_Orcamento orcamento = (dataGrid.DataSource as List<Vw_Orcamento>)[dataGrid.CurrentRow.Index];

            CadOrcamento cad = new CadOrcamento();
            cad.FillForm(orcamento.Id);
            cad.ShowDialog();

            Buscar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            Vw_Orcamento orcamento = (dataGrid.DataSource as List<Vw_Orcamento>)[dataGrid.CurrentRow.Index];
            DialogResult res = MessageBox.Show("Confirmar a exclusão do orçamento selecionado? \nEsta ação não poderá ser revertida!",
                "Excluir orçamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;

            try
            {
                OrcamentoBLL bll = new OrcamentoBLL();
                bll.RemoveOrcamento(orcamento.Id);

                Buscar();
            }
            catch (Exception ex)
            {
                Messages.Error("Não foi possível excluir o orçamento", ex);
            }
        }
    }
}
