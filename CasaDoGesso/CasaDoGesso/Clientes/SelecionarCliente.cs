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

namespace CasaDoGesso.Clientes
{
    public partial class SelecionarCliente : Form
    {
        public Cliente Selecionado = new Cliente();
        public SelecionarCliente()
        {
            InitializeComponent();
            dataGrid.AplicarPadroesDataGrid();
            Buscar();
        }

        private void Buscar()
        {
            ClienteBLL bll = new ClienteBLL();
            List<Cliente> list = bll.Search(txPesquisa.Text);
            dataGrid.DataSource = list;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void Selecionar()
        {
            if (dataGrid.CurrentRow == null)
                return;

            Cliente cliente = (dataGrid.DataSource as List<Cliente>)[dataGrid.CurrentRow.Index];
            Selecionado = cliente;
            Close();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Selecionar();
        }
    }
}
