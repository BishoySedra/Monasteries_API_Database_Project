using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/SaintTitle")]
    public class SaintTitle : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("GetSaintByMonasteryID/{monansteryId}")]
        // GET api/<controller>/5
        public MySaintTitle GetSaintByMonasteryID(int monansteryId)
        {
            var context = new MonasteryEntities();
            var saintTitle = context.SaintTitles.Where(t => t.MonasteryID == monansteryId).Select(t => new MySaintTitle
            {
                Title = t.Title,
                Image = t.Image
            }).FirstOrDefault();

            return saintTitle;
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