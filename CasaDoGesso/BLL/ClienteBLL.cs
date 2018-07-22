using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL db = null;

        public ClienteBLL()
        {
            db = new ClienteDAL();
        }

        public void Save(Cliente cliente)
        {
            Valid(cliente);

            if (db.Find(cliente.Id) == null)
                db.Save(cliente);
            else
                db.Update(cliente);

            db.Commit();
        }

        private void Valid(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
                throw new Exception("O nome do cliente é obrigatório");

            if (string.IsNullOrEmpty(cliente.Logradouro))
                throw new Exception("O logradouro do cliente é obrigatório");

            if (string.IsNullOrEmpty(cliente.Bairro))
                throw new Exception("O bairro do cliente é obrigatório");

            if (cliente.Numero == 0)
                throw new Exception("O número da residência do cliente é obrigatório");
        }

        public Cliente Find(int id)
        {
            return db.Find(id);
        }

        public List<Cliente> Search(string search)
        {
            return db.Search(search);
        }

        public void Remove(int id)
        {
            Cliente cliente = Find(id);
            if (cliente.Visita.Count > 0)
                throw new Exception("Existem uma ou mais visitas relacionadas a ele");

            if (cliente.Orcamento.Count > 0)
                throw new Exception("Existem um ou mais orçamentos cadastrados para ele");

            if (cliente.Servico.Count > 0)
                throw new Exception("Exitem um ou mais serviços cadastrados para ele");

            db.Remove(cliente);
            db.Commit();
        }
    }
}
