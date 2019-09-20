using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class ContaDao
    {
        public IEnumerable<Conta> BuscarContas()
        {
            using (var context = new IBEntitiesModel())
            {
                //List<Conta> lista = new List<Conta>();                
                return context.Contas.ToList();
            }
        }

        public bool IncluirConta(Conta conta)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Contas.Add(conta);
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