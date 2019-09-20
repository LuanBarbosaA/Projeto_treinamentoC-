using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class LancamentoDao
    {
        public IEnumerable<Lancamento> BuscarLancamentos()
        {
            using (var context = new IBEntitiesModel())
            {
                return context.Lancamentos.ToList();
            }
        }

        public bool IncluirLancamento(Lancamento lancamento)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Lancamentos.Add(lancamento);
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