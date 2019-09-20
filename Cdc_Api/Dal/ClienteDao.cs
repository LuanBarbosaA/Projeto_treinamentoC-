using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class ClienteDao
    {
        public IEnumerable<Cliente> BuscarCliente()
        {
            using (var context = new IBEntitiesModel())
            {
                return context.Clientes.ToList();
            }
        }
        public bool IncluirCliente(Cliente cliente)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}