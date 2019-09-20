using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cdc_Api.Dal;
using Cdc_Api.Dados;

namespace Cdc_Api.BLL
{
    public class EnderecoBll
    {
        private EnderecoDao dao;

        public EnderecoBll(EnderecoDao enderecoDao)
        {
            this.dao = enderecoDao;
        }

        public void Validar(Endereco endereco)
        {
            if (string.IsNullOrEmpty(endereco.Numero))
            {
                throw new Exception("O núemero deve ser informado");
            }
            /*else if()
            {

            }*/
        }

        public IEnumerable<Endereco> BuscarEnderecos()
        {
            var lista = dao.BuscarEnderecos();
            return lista;
        }

        public void IncluirEndereco(Endereco endereco)
        {
            Validar(endereco);
            dao.IncluirEndereco(endereco);
        }
    }
}