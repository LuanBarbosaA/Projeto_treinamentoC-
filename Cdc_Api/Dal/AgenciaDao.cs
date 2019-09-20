using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class AgenciaDao
    {
        public IEnumerable<Agencia> BuscarAgencias()
        {
            using (var context = new IBEntitiesModel())
            {
                return context.Agencias.ToList();
            }
        }
        public bool IncluirAgencia(Agencia agencia)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Agencias.Add(agencia);
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