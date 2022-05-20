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
    public class SaintTitleController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("GetSaintByMonasteryID/{MonansteryId}")]
        // GET api/<controller>/5
        public List<MySaintTitle>  GetSaintByMonasteryID(int MonansteryId)
        {
            var context = new MonasteryEntities();
            var saintTitle = context.SaintTitles.Where(t => t.MonasteryID == MonansteryId).Select(t => new MySaintTitle
            {
                Title = t.Title,
                Image = t.Image,
                Paragraphs = t.SaintParagraphs.Select(p => p.Paragraph).ToList()
            }).ToList();

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