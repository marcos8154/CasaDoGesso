using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public   class VisitaBLL
    {
        private VisitaDAL db = null;

        public VisitaBLL()
        {
            db = new VisitaDAL();
        }

        public void Save(Visita visita)
        {
            if (db.Find(visita.Id) == null)
                db.Save(visita);
            else
                db.Update(visita);

            db.Commit();
        }

        public Visita Find(int id)
        {
            return db.Find(id);
        }

        public List<Visita> List(DateTime dataInicio, DateTime dataFim)
        {
            return db.Where(v => v.DataVisita >= dataInicio &&
                v.DataVisita <= dataFim &&
                !v.Realizado).ToList();
        }
    }
}
