using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrcamentoBLL
    {
        private OrcamentoDAL db = null;
        public OrcamentoBLL()
        {
            db = new OrcamentoDAL();
        }

        public void Save(Orcamento orcamento)
        {
            if (db.Find(orcamento.Id) == null)
                db.Save(orcamento);
            else
                db.Update(orcamento);

            db.Commit();
        }

        public void AdicionaItem(ItemOrcamento item)
        {
            db.Context.ItemOrcamento.Add(item);
            db.Commit();
        }

        public List<Vw_Orcamento> GetOrcamentosView(DateTime dataInicio, DateTime dataFim)
        {
            return db.GetOrcamentosVw(dataInicio, dataFim);
        }

        public void RemoveItem(int id)
        {
            var item = db.Context.ItemOrcamento.Find(id);
            db.Context.ItemOrcamento.Remove(item);
            db.Commit();
        }

        public Orcamento Find(int id)
        {
            return db.Find(id);
        }

        public void RemoveOrcamento(int id)
        {
            UnitOfWork unit = null;

            try
            {
                unit = new UnitOfWork();
                unit.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                db.Context = unit.Context;

                var orcamento = Find(id);

                foreach (ItemOrcamento item in orcamento.ItemOrcamento.ToList())
                    db.Context.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                db.Commit();

                db.Remove(orcamento);
                db.Commit();

                unit.Commit();
            }
            catch(Exception ex)
            {
                if (unit != null)
                    unit.RollBack();

                throw;
            }
        }
    }
}
