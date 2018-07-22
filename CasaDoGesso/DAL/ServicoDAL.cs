using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicoDAL : RepositoryImpl<Servico>
    {
        public List<Vw_Servico> GetServicosView(DateTime dataInicio,
            DateTime dataFim, int clienteId = 0)
        {
            var q = (from servico in Context.Vw_Servico.AsNoTracking()
                     where servico.Data >= dataInicio &&
                     servico.Data <= dataFim &&
                     (clienteId == 0
                        ? servico.ClienteId >= 0
                        : servico.ClienteId == clienteId)
                     select servico);

            return q.ToList();
        }
    }
}
