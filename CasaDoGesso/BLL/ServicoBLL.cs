using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicoBLL
    {
        private ServicoDAL db = null;

        public ServicoBLL()
        {
            db = new ServicoDAL();
        }

        public void Save(Servico servico)
        {
            if (db.Find(servico.Id) == null)
                db.Save(servico);
            else
                db.Update(servico);

            db.Commit();
        }

        public Servico Find(int id)
        {
            return db.Find(id);
        }

        public void AdicionaItem(ItemServico item)
        {
            db.Context.ItemServico.Add(item);
            db.Commit();
        }

        public List<Vw_Servico> GetServicosView(DateTime dataInicio,
            DateTime dataFim, int clienteId =0)
        {
            dataInicio = dataInicio.Date;
            dataFim = dataFim.Date;

            return db.GetServicosView(dataInicio, dataFim, clienteId);
        }

        public void RemoveItem(int id)
        {
            var item = db.Context.ItemServico.Find(id);
            db.Context.ItemServico.Remove(item);
            db.Commit();
        }

        public void RemoveServico(int id)
        {
            UnitOfWork unit = null;

            try
            {
                unit = new UnitOfWork();
                unit.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                db.Context = unit.Context;

                var servico = Find(id);

                foreach (ItemServico item in servico.ItemServico.ToList())
                    db.Context.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                db.Commit();

                db.Remove(servico);
                db.Commit();

                unit.Commit();
            }
            catch (Exception ex)
            {
                if (unit != null)
                    unit.RollBack();

                throw;
            }
        }
    }
}
