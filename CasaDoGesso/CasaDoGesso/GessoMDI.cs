using CasaDoGesso.AgendamentoVisitas;
using CasaDoGesso.AgendamentoVisitas.Painel;
using CasaDoGesso.Clientes;
using CasaDoGesso.FormasPag;
using CasaDoGesso.Orcamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDoGesso
{
    public partial class GessoMDI : Form
    {
        private int childFormNumber = 0;

        public GessoMDI()
        {
            InitializeComponent();

            PainelVisitas pv = new PainelVisitas();
            pv.MdiParent = this;
            pv.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFormaPag cad = new CadastroFormaPag();
            cad.MdiParent = this;
            cad.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cad = new CadastroCliente();
            cad.MdiParent = this;
            cad.Show();
        }

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVisita cad = new CadVisita();
            cad.MdiParent = this;
            cad.Show();
        }

        private void estaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelVisitas painel = new PainelVisitas();
            painel.MdiParent = this;
            painel.Show();
        }

        private void orçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOrcamentos co = new ConsultaOrcamentos();
            co.MdiParent = this;
            co.Show();
        }
    }
}
