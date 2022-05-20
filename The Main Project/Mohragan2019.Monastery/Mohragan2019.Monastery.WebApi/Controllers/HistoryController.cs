using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/history")]
    public class HistoryController : ApiController
    {

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("GetHistoryByMonasteryID/{monasteryID}")]
        public List<MyHistory> GetHistoryByMonasteryID(int monasteryID)
        {
            var context = new MonasteryEntities();
            var history = context.Histories.Where(h => h.MonasteryID == monasteryID).Select(h => new MyHistory
            {
                Title = h.Title,
                Img = h.Image,
                Contents = h.HistoryContents.Select(C => C.ParagraphContent).ToList(),
                Description = h.ImageDescription
            }).ToList();

            return history;
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