using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/Monastery")]
    public class MonasteryController : ApiController
    {

        [Route("GetAll")]
        // GET api/<controller>
        public List<MonasteryList> Get()
        {
            var context = new MonasteryEntities();

            var monasteries = context.Monasteries.OrderByDescending(m => m.ID).Select(m => new MonasteryList
            {
                ID = m.ID,
                Name = m.Name,
                Description = m.Description,
                Image = m.Image
            }).ToList();

            return monasteries;
        }

        [Route("GetMonasteryBySearch")]
        // GET api/<controller>/5
        public List<MonasteryList> GetMonasteryBySearch(string search)
        {
            var context = new MonasteryEntities();
            var Monastery = context.Monasteries.OrderBy(m => m.ID).Where(m => m.Name.Contains(search)).Select(m => new MonasteryList
            {
                ID = m.ID,
                Name = m.Name,
                Image = m.Image,
                Description = m.Description
            }).ToList();
            return Monastery;
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