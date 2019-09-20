using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class PacoteDao
    {
        public IEnumerable<Pacote> BusacarPacotes()
        {
            using (var context = new IBEntitiesModel())
            {
                return context.Pacotes.ToList();
            }
        }

        public bool IncluirPacote(Pacote pacote)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Pacotes.Add(pacote);
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