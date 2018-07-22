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

namespace CasaDoGesso.Orcamentos
{
    public partial class CadOrcamento : Form
    {
        public CadOrcamento()
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

        private List<ItemOrcamento> Itens = new List<ItemOrcamento>();

        private void btInserir_Click(object sender, EventArgs e)
        {
            ItemOrcamento item = new ItemOrcamento();
            item.OrcamentoId = IdAtual;
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

            txQuant.Focus();

            txTotalOrcamento.Value = Itens.Sum(i => i.Total);

            OrcamentoBLL bll = new OrcamentoBLL();
            bll.AdicionaItem(item);
        }

        public void FillForm(int id)
        {
            Orcamento orcamento = new OrcamentoBLL().Find(id);
            if (orcamento == null)
                return;

            FillCliente(orcamento.Cliente);
            IdAtual = orcamento.Id;
            txData.Value = orcamento.Data;
            txObs.Text = orcamento.Observacoes;

            Itens = orcamento.ItemOrcamento.ToList();
            dataGrid.DataSource = Itens;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private Orcamento GetOrcamento()
        {
            Cliente cliente = new ClienteBLL().Find((int)txCodCliente.Value);
            if (cliente == null)
                throw new Exception("Cliente inválido");

            Orcamento or = new Orcamento();
            or.ClienteId = cliente.Id;
            or.Data = txData.Value;
            or.Observacoes = txObs.Text;
            or.Encerrado = false;

            or.ItemOrcamento = Itens;

            return or;
        }

        private void Salvar()
        {
            try
            {
                Orcamento o = GetOrcamento();
            }
            catch(Exception ex)
            {
                Messages.Error("Não foi possível salvar o orçamento", ex);
            }
        }

        private void txQuant_Leave(object sender, EventArgs e)
        {
            Calcular();
            txDescricao.Focus();
            txDescricao.SelectAll();
        }

        private void Calcular()
        {
            txTotal.Value = (txValorUnit.Value * txQuant.Value);
        }

        private void txValorUnit_Leave(object sender, EventArgs e)
        {
            Calcular();
            btInserir.Focus();
        }

        private void txDescricao_Leave(object sender, EventArgs e)
        {
            txValorUnit.Focus();
        }
        
        private void dataGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private int IdAtual { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OrcamentoBLL bll = new OrcamentoBLL();

                Orcamento o = (IdAtual == 0
                    ? new Orcamento()
                    : bll.Find(IdAtual));

                o.ClienteId = (int)txCodCliente.Value;
                o.Data = txData.Value;
                o.Observacoes = txObs.Text;
                o.Encerrado = false;
                
                bll.Save(o);
                IdAtual = o.Id;
                tabControl.SelectedTab = tabControl.TabPages[1];
            }
            catch(Exception ex)
            {
                Messages.Error("Não foi possível salvar o orçamento", ex);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab == tabControl.TabPages[1])
            {
                if(IdAtual == 0)
                {
                    MessageBox.Show("Salve o orçamento antes de incluir os itens!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    tabControl.SelectedTab = tabControl.TabPages[0];
                    return;
                }
            }
        }

        private void btRemoverItem_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            ItemOrcamento item = (dataGrid.DataSource as List<ItemOrcamento>)[dataGrid.CurrentRow.Index];
            Itens.Remove(item);

            OrcamentoBLL bll = new OrcamentoBLL();
            bll.RemoveItem(item.Id);

            dataGrid.DataSource = null;
            dataGrid.DataSource = Itens;
            txTotalOrcamento.Value = Itens.Sum(i => i.Total);
        }
    }
}
