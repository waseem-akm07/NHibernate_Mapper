using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataTransferObject.DTO;
using BusinessLogicLayer.Repo;
using DataAccessLayer.NHibernate;

namespace useNHibernate_Mvc.Controllers
{
    public class empController : ApiController
    {
        private IBusinessLayer _businessLayer = new BusinessLayer();


        // GET: api/emp
        [HttpGet]
        [Route("api/emp/getemployees")]
        public IEnumerable<Employees> Get()
        {
            return _businessLayer.GetEmployees();
        }

        // GET: api/emp/5
        [HttpGet]
        [Route("api/emp/getemployee/{id}")]
        public Employees Get(int id)
        {
            return _businessLayer.GetEmployee(id);
        }

        // POST: api/emp
        [HttpPost]
        [Route("api/emp/postemployee")]
        public void Post(Employees model)
        {
            _businessLayer.Create(model);
        }

        // PUT: api/emp/5
        [HttpPut]
        [Route("api/emp/putemployee/{id}")]
        public void Put(int id, Employees model)
        {
            _businessLayer.Update(id, model);
        }

        // DELETE: api/emp/5
        [HttpDelete]
        [Route("api/emp/delete/{id}")]
        public void Delete(int id)
        {
            _businessLayer.Delete(id);
        }
    }
}
