using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrcamentoDAL : RepositoryImpl<Orcamento>
    {
        public List<Vw_Orcamento> GetOrcamentosVw(DateTime dataInicio,
            DateTime dataFim)
        {
            var q = (from orc in Context.Vw_Orcamento.AsNoTracking()
                     where orc.Data >= dataInicio &&
                     orc.Data <= dataFim
                     select orc);

            return q.ToList();
        }
    }
}
