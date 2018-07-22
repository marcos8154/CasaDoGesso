using BLL;
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

namespace CasaDoGesso.AgendamentoVisitas.Painel
{
    public partial class PainelVisitas : Form
    {
        public PainelVisitas()
        {
            InitializeComponent();

            FillDias();

            Timer t = new Timer();
            t.Interval = 10000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            FillDias();
        }

        private DateTime GetSegunda()
        {
            var dataBase = DateTime.Now.Date;
            
            if (dataBase.DayOfWeek == DayOfWeek.Monday)
                return dataBase;
            if (dataBase.DayOfWeek == DayOfWeek.Tuesday)
                return dataBase.AddDays(-1);
            if (dataBase.DayOfWeek == DayOfWeek.Wednesday)
                return dataBase.AddDays(-2);
            if (dataBase.DayOfWeek == DayOfWeek.Thursday)
                return dataBase.AddDays(-3);
            if (dataBase.DayOfWeek == DayOfWeek.Friday)
                return dataBase.AddDays(-4);
            if (dataBase.DayOfWeek == DayOfWeek.Saturday)
                return dataBase.AddDays(-5);
            if (dataBase.DayOfWeek == DayOfWeek.Sunday)
                return dataBase.AddDays(-6);

            return dataBase;
        }

        private void FillDias()
        {
            FillDiaSemana(DiaSemana.SEGUNDA, painelSegunda);
            FillDiaSemana(DiaSemana.TERCA, painelTerca);
            FillDiaSemana(DiaSemana.QUARTA, painelQuarta);
            FillDiaSemana(DiaSemana.QUINTA, painelQuinta);
            FillDiaSemana(DiaSemana.SEXTA, painelSexta);
        }

        private void FillDiaSemana(DiaSemana dia, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            var data = GetData(dia);
            VisitaBLL bll = new VisitaBLL();
            List<Visita> segunda = bll.List(data, data.AddHours(23));
            segunda.ForEach(v => panel.Controls.Add(new CardVista(v)));
        }
        
        private DateTime GetData(DiaSemana dia)
        {
            DateTime dataBase = GetSegunda();

            switch(dia)
            {
                case DiaSemana.SEGUNDA: return dataBase;
                case DiaSemana.TERCA: return dataBase.AddDays(1);
                case DiaSemana.QUARTA: return dataBase.AddDays(2);
                case DiaSemana.QUINTA: return dataBase.AddDays(3);
                case DiaSemana.SEXTA: return dataBase.AddDays(4);
            }

            return dataBase;
        }
    }
}
