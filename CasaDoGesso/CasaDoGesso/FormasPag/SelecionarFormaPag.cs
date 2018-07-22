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

namespace CasaDoGesso.FormasPag
{
    public partial class SelecionarFormaPag : Form
    {
        public FormaPagamento Selecionado = new FormaPagamento();
        public SelecionarFormaPag()
        {
            InitializeComponent();

            dataGrid.AplicarPadroesDataGrid();
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void Buscar()
        {
            List<FormaPagamento> list = new FormaPagamentoBLL().Search(txPesquisa.Text);
            dataGrid.DataSource = list;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            if (dataGrid.CurrentRow == null)
                return;

            Selecionado = (dataGrid.DataSource as List<FormaPagamento>)[dataGrid.CurrentRow.Index];
            Close();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Selecionar();
        }
    }
}
