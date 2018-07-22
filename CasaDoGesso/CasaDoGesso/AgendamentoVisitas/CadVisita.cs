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

namespace CasaDoGesso.AgendamentoVisitas
{
    public partial class CadVisita : Form
    {
        public CadVisita()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillCliente();
        }

        private void FillCliente(Cliente cli = null)
        {
            if (cli == null)
            {
                cli = new ClienteBLL().Find((int)txCodCliente.Value);
                if (cli == null)
                    return;
            }

            txCodCliente.Value = cli.Id;
            txNomeCliente.Text = cli.Nome;
            txTelefone.Text = cli.Telefone;
            txCelular.Text = cli.Celular;
            txLogradouro.Text = cli.Logradouro;
            txBairro.Text = cli.Bairro;
            txMunicipio.Text = cli.Municipio;
            txNumero.Value = cli.Numero;
        }

        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            SelecionarCliente sc = new SelecionarCliente();
            sc.ShowDialog();

            FillCliente(sc.Selecionado);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VisitaBLL bll = new VisitaBLL();

                Visita visita = new Visita();
                visita.DataVisita = txData.Value;
                visita.Motivo = txMotivo.Text;
                visita.ClienteId = (int)txCodCliente.Value;
                visita.Realizado = false;

                bll.Save(visita);
                LimparCampos();
                Messages.Info("Visita salva com sucesso");
            }
            catch (Exception ex)
            {
                Messages.Error("Não foi possível salvar a visita", ex);
            }
        }

        private void LimparCampos()
        {
            txCodCliente.Value = 0;
            txNomeCliente.Text = string.Empty;
            txTelefone.Text = string.Empty;
            txCelular.Text = string.Empty;
            txLogradouro.Text = string.Empty;
            txBairro.Text = string.Empty;
            txNumero.Value = 0;
            txMunicipio.Text = string.Empty;
            txMotivo.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente(true);
            cad.ShowDialog();

            FillCliente(cad.UltimoCadastrado);
        }
    }
}
