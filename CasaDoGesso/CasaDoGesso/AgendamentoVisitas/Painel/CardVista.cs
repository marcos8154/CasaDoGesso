using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;

namespace CasaDoGesso.AgendamentoVisitas.Painel
{
    public partial class CardVista : UserControl
    {
        public CardVista(Visita visita)
        {
            InitializeComponent();

            lbData.Text = visita.DataVisita.ToString("dd/MM/yyyy HH:mm");
            lbCliente.Text = visita.Cliente.Nome;
            lbLogradouro.Text = $"{visita.Cliente.Logradouro}, n°{visita.Cliente.Numero}";
            lbBairro.Text = visita.Cliente.Bairro;
            lbMunicipio.Text = visita.Cliente.Municipio;
        }

        private void CardVista_Load(object sender, EventArgs e)
        {

        }
    }
}
