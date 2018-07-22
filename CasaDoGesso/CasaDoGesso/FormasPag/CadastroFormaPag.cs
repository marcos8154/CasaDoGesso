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
    public partial class CadastroFormaPag : Form
    {
        public CadastroFormaPag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FormaPagamentoBLL bll = new FormaPagamentoBLL();

                FormaPagamento forma = (txCod.Value == 0
                    ? new FormaPagamento()
                    : bll.Find((int)txCod.Value));

                forma.Nome = txNome.Text;

                bll.Save(forma);
                LimparCampos();
                Messages.Info("Forma de pagamento salva com sucesso");
            }
            catch (Exception ex)
            {
                Messages.Error("Não foi possível salvar a forma de pagamento", ex);
            }
        }

        private void LimparCampos()
        {
            txCod.Value = 0;
            txNome.Text = "";
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            SelecionarFormaPag sf = new SelecionarFormaPag();
            sf.ShowDialog();

            FillForm(sf.Selecionado);
        }

        private void FillForm(FormaPagamento fpg)
        {
            txCod.Value = fpg.Id;
            txNome.Text = fpg.Nome;
            txNome.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txCod.Value == 0)
                return;

            DialogResult res = Messages.Dialog($"Confirmar a exclusão da forma de pagamento '{txNome.Text}'? \nEsta ação não poderá ser revertida!");
            if (res == DialogResult.No)
                return;

            try
            {
                FormaPagamentoBLL bll = new FormaPagamentoBLL();
                bll.Remove((int)txCod.Value);
                LimparCampos();
                Messages.Info("Forma de pagamento excluida");
            }
            catch(Exception ex)
            {
                Messages.Error("Não foi possível excluir a forma de pagamento", ex);
            }
        }
    }
}
