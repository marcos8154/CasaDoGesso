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
    public partial class CadServico : Form
    {
        public CadServico()
        {
            InitializeComponent();

            dataGrid.AplicarPadroesDataGrid();
        }

        private void btSelecionarCliente_Click(object sender, EventArgs e)
        {
            SelecionarCliente sc = new SelecionarCliente();
            sc.ShowDialog();

            FillCliente(sc.Selecionado);
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

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente(true);
            cad.ShowDialog();

            FillCliente(cad.UltimoCadastrado);
        }

        private int IdAtual { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ServicoBLL bll = new ServicoBLL();

                Servico o = (IdAtual == 0
                    ? new Servico()
                    : bll.Find(IdAtual));

                o.ClienteId = (int)txCodCliente.Value;
                o.Data = txData.Value;
                o.Observacoes = txObs.Text;
         
                bll.Save(o);
                IdAtual = o.Id;
                tabControl.SelectedTab = tabControl.TabPages[1];
            }
            catch (Exception ex)
            {
                Messages.Error("Não foi possível salvar o orçamento", ex);
            }
        }

        internal void FillForm(int id)
        {
            Servico servico = new ServicoBLL().Find(id);
            if (servico == null)
                return;

            FillCliente(servico.Cliente);
            IdAtual = servico.Id;
            txData.Value = servico.Data;
            txObs.Text = servico.Observacoes;

            Itens = servico.ItemServico.ToList();
            dataGrid.DataSource = Itens;

            txTotalOrcamento.Value = Itens.Sum(i => i.Total);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            InserirItem();
        }

        private List<ItemServico> Itens = new List<ItemServico>();

        private void InserirItem()
        {
            ItemServico item = new ItemServico();
            item.ServicoId = IdAtual;
            item.Quant = txQuant.Value;
            item.Descricao = txDescricao.Text;
            item.Unit = txValorUnit.Value;
            item.Total = txTotal.Value;

            if (item.Quant == 0)
                return;
            if (item.Unit == 0)
                return;
            if (string.IsNullOrEmpty(item.Descricao))
                return;

            Itens.Add(item);

            dataGrid.DataSource = null;
            dataGrid.DataSource = Itens;

            txQuant.Value = 0;
            txDescricao.Text = string.Empty;
            txValorUnit.Value = 0;
            txTotal.Value = 0;

            txTotalOrcamento.Value = Itens.Sum(i => i.Total);

            ServicoBLL bll = new ServicoBLL();
            bll.AdicionaItem(item);

            txQuant.Focus();
        }

        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            ItemServico item = (dataGrid.DataSource as List<ItemServico>)[dataGrid.CurrentRow.Index];
            Itens.Remove(item);

            ServicoBLL bll = new ServicoBLL();
            bll.RemoveItem(item.Id);

            dataGrid.DataSource = null;
            dataGrid.DataSource = Itens;
            txTotalOrcamento.Value = Itens.Sum(i => i.Total);
        }

        private void txQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txDescricao.Focus();
        }

        private void txDescricao_Enter(object sender, EventArgs e)
        {
            txDescricao.SelectAll();
        }

        private void txDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txValorUnit.Focus();
        }

        private void txValorUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btInserir.Focus();
        }

        private void txValorUnit_Leave(object sender, EventArgs e)
        {
            txTotal.Value = (txValorUnit.Value * txQuant.Value);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages[1])
            {
                if (IdAtual == 0)
                {
                    MessageBox.Show("Salve o serviço antes de incluir os itens!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    tabControl.SelectedTab = tabControl.TabPages[0];
                    return;
                }
            }
        }

        private void txValorUnit_Enter(object sender, EventArgs e)
        {
            txValorUnit.Select(0, txValorUnit.Value.ToString("N2").Length);
        }

        private void txQuant_Enter(object sender, EventArgs e)
        {
            txQuant.Select(0, txQuant.Value.ToString("N3").Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
