using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FormaPagamentoBLL
    {
        private FormaPagamentoDAL db = null;

        public FormaPagamentoBLL()
        {
            db = new FormaPagamentoDAL();
        }

        public void Save(FormaPagamento formaPg)
        {
            Valid(formaPg);

            if (db.Find(formaPg.Id) == null)
                db.Save(formaPg);
            else
                db.Update(formaPg);

            db.Commit();
        }

        private void Valid(FormaPagamento fpg)
        {
            if (string.IsNullOrEmpty(fpg.Nome))
                throw new Exception("O nome da forma de pagamento é obrigatório");
        }

        public List<FormaPagamento> Search(string search)
        {
            int id = 0;
            int.TryParse(search, out id);
            return db.Where(e => e.Id == id || e.Nome.Contains(search))
                .ToList();
        }

        public FormaPagamento Find(int id)
        {
            return db.Find(id);
        }

        public void Remove(int id)
        {
            FormaPagamento fpg = Find(id);
            db.Remove(fpg);
            db.Commit();
        }
    }
}
