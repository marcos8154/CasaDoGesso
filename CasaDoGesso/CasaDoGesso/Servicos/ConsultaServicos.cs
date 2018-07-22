using BLL;
using CasaDoGesso.Clientes;
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

namespace CasaDoGesso.Servicos
{
    public partial class ConsultaServicos : Form
    {
        public ConsultaServicos()
        {
            InitializeComponent();

            dataGrid.AplicarPadroesDataGrid();
            Buscar();
        }

        private void Buscar()
        {
            List<Vw_Servico> list = new ServicoBLL().GetServicosView(txDataFim.Value,
               txDataFim.Value, (int)txCodCliente.Value);
            dataGrid.DataSource = list;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            CadServico cad = new CadServico();
            cad.ShowDialog();

            Buscar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            Vw_Servico servico = (dataGrid.DataSource as List<Vw_Servico>)[dataGrid.CurrentRow.Index];
            DialogResult res = MessageBox.Show("Confirmar a exclusão do serviço selecionado? \nEsta ação não poderá ser revertida!",
                "Excluir serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                return;

            try
            {
                ServicoBLL bll = new ServicoBLL();
                bll.RemoveServico(servico.Id);

                Buscar();
            }
            catch (Exception ex)
            {
                Messages.Error("Não foi possível excluir o serviço", ex);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            Vw_Servico servico = (dataGrid.DataSource as List<Vw_Servico>)[dataGrid.CurrentRow.Index];

            CadServico cad = new CadServico();
            cad.FillForm(servico.Id);
            cad.ShowDialog();

            Buscar();
        }

        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            SelecionarCliente sc = new SelecionarCliente();
            sc.ShowDialog();

            FillCliente(sc.Selecionado);
        }

        private void FillCliente(Cliente cliente = null)
        {
            if (cliente != null)
            {
                txCodCliente.Value = cliente.Id;
                txNomeCliente.Text = cliente.Nome;
            }
            else
            {
                cliente = new ClienteBLL().Find((int)txCodCliente.Value);
                txNomeCliente.Text = (cliente == null
                    ? ""
                    : cliente.Nome);
            }
        }

        private void txCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillCliente();
        }
    }
}
