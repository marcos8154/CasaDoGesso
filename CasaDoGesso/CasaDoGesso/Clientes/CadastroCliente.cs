using BLL;
using Correios.Net;
using DAL;
using DAL.Enum;
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
    public partial class CadastroCliente : Form
    {
        public Cliente UltimoCadastrado = new Cliente();
        private bool FecharAposCadastro { get; set; }

        public CadastroCliente(bool fecharAposCadastro = false)
        {
            InitializeComponent();
            FecharAposCadastro = fecharAposCadastro;
            FillCbTipo();
        }

        public void FillCbTipo()
        {
            List<KeyValuePair<int, string>> tipos = new List<KeyValuePair<int, string>>();
            tipos.Add(new KeyValuePair<int, string>((int)TipoPessoa.FISICA, "Física"));
            tipos.Add(new KeyValuePair<int, string>((int)TipoPessoa.JURIDICA, "Jurídica"));

            cbTipoPessoa.ValueMember = "Key";
            cbTipoPessoa.DisplayMember = "Value";
            cbTipoPessoa.DataSource = tipos;
            cbTipoPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoPessoa.SelectedIndex = 0;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarCep();
        }

        private void BuscarCep()
        {
            try
            {
                string cep = txCEP.Text.RemoverCaracteres();
                Address address = SearchZip.GetAddress(cep);
                if (!string.IsNullOrEmpty(address.Zip))
                {
                    txLogradouro.Text = address.Street;
                    txBairro.Text = address.District;
                    txMunicipio.Text = address.City;
                    txUF.Text = address.State;

                    if (address.Street != "Não encontrado")
                        txNumero.Focus();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void txCEP_Leave(object sender, EventArgs e)
        {
            BuscarCep();
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbTipoPessoa.SelectedValue == (int)TipoPessoa.FISICA)
            {
                txCpfCnpj.Mask = "###,###,###-##";
                lbCpfCnpj.Text = "CPF";
            }
            else
            {
                txCpfCnpj.Text = "##,###,###/####-##";
                lbCpfCnpj.Text = "CNPJ";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL bll = new ClienteBLL();

                Cliente cliente = (txCod.Value > 0
                    ? bll.Find((int)txCod.Value)
                    : new Cliente());

                cliente.Nome = txNome.Text;
                cliente.TipoPessoa = (int)cbTipoPessoa.SelectedValue;
                cliente.CpfCnpj = txCpfCnpj.Text;
                cliente.Telefone = txTelefone.Text;
                cliente.Celular = txCelular.Text;
                cliente.Email = txEmail.Text;
                cliente.CEP = txCEP.Text;
                cliente.Logradouro = txLogradouro.Text;
                cliente.Bairro = txBairro.Text;
                cliente.Municipio = txMunicipio.Text;
                cliente.Numero = (int)txNumero.Value;
                cliente.UF = txUF.Text;

                bll.Save(cliente);
                UltimoCadastrado = bll.Find(cliente.Id);
                LimparCampos();
                Messages.Info("Cliente salvo com sucesso");
                if (FecharAposCadastro)
                    Close();
            }
            catch(Exception ex)
            {
                Messages.Error("Não foi possível salvar o cliente", ex);
            }
        }

        private void LimparCampos()
        {
            txCod.Value = 0;
            txNome.Text = string.Empty;
            txCpfCnpj.Text = string.Empty;
            txTelefone.Text = string.Empty;
            txCelular.Text = string.Empty;
            txEmail.Text = string.Empty;
            txCEP.Text = string.Empty;
            txLogradouro.Text = string.Empty;
            txBairro.Text = string.Empty;
            txMunicipio.Text = string.Empty;
            txNumero.Value = 0;
            txUF.Text = string.Empty;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            SelecionarCliente sc = new SelecionarCliente();
            sc.ShowDialog();

            FillForm(sc.Selecionado);
        }

        private void FillForm(Cliente cli)
        {
            txCod.Value = cli.Id;
            txNome.Text = cli.Nome;
            cbTipoPessoa.SelectedValue = cli.TipoPessoa;
            txCpfCnpj.Text = cli.CpfCnpj;
            txTelefone.Text = cli.Telefone;
            txCelular.Text = cli.Celular;
            txEmail.Text = cli.Email;
            txCEP.Text = cli.CEP;
            txLogradouro.Text = cli.Logradouro;
            txBairro.Text = cli.Bairro;
            txMunicipio.Text = cli.Municipio;
            txNumero.Value = cli.Numero;
            txUF.Text = cli.UF;

            txNome.Focus();
            txNome.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txCod.Value == 0)
                return;

            DialogResult res = Messages.Dialog($"Confirmar a exclusão do cliente '{txNome.Text}'? \nEsta ação não poderá ser revertida!");
            if (res == DialogResult.No)
                return;

            try
            {
                ClienteBLL bll = new ClienteBLL();
                bll.Remove((int)txCod.Value);
                LimparCampos();
                Messages.Info("Cliente excluido");
            }
            catch(Exception ex)
            {
                Messages.Error("Não foi possível excluir o cliente", ex);
            }
        }
    }
}
