using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cdc_Api.BLL;
using Cdc_Api.Dados;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cdc_Api.Controllers
{
    public class EnderecoController : ApiController
    {
        private EnderecoBll bll;

        /*public void Serializar(List<string> lista)
        {
            lista
        }*/

        public EnderecoController(EnderecoBll enderecoBll)
        {
            this.bll = enderecoBll;
        }
        // GET api/<controller>
        /*[HttpGet]
        public IEnumerable<Endereco> Get()
        {
            var lista = bll.BuscarEnderecos();
            //return Json(lista);
            return lista;
        }*/

        //[Route("getenderecos")]
        [HttpGet]
        public string Get()
        {
            var lista = bll.BuscarEnderecos();
            var json = JsonConvert.SerializeObject(lista.ToList());
            return json;
            /*var lista = bll.BuscarEnderecos().ToString();
            return Json(lista.ToList());*/
        }
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}