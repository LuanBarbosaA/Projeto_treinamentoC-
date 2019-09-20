using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dados;

namespace Cdc_Api.Dal
{
    public class EnderecoDao
    {
        public IEnumerable<Endereco> BuscarEnderecos()
        {
            using (var context = new IBEntitiesModel())
            {
                return context.Enderecos.ToList();
            }
        }
        public bool IncluirEndereco(Endereco endereco)
        {
            try
            {
                using (var context = new IBEntitiesModel())
                {
                    context.Enderecos.Add(endereco);
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