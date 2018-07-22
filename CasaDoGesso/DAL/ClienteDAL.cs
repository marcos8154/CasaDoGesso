using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL : RepositoryImpl<Cliente>
    {
        public List<Cliente> Search(string search)
        {
            int id = 0;
            int.TryParse(search, out id);

            var q = (from cliente in Context.Cliente.AsNoTracking()
                     where cliente.Id == id &&
                           cliente.Nome.Contains(search) ||
                           cliente.Email.Contains(search) ||
                           cliente.CpfCnpj.Contains(search) ||
                           cliente.Logradouro.Contains(search) ||
                           cliente.Municipio.Contains(search) ||
                           cliente.Telefone.Contains(search) ||
                           cliente.Celular.Contains(search) ||
                           cliente.Bairro.Contains(search)
                     select cliente);

            return q.ToList();
        }
    }
}
