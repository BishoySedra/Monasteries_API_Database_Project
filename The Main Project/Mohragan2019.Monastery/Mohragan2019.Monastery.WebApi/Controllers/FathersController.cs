using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/Fathers")]
    public class FathersController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("GetFathersByMonasteryID/{MonansteryId}")]
        public List<MyFathers> GetFathersByMonasteryID(int MonansteryId)
        {
            var context = new MonasteryEntities();
            List<MyFathers> fathers = context.Fathers.Where(f => f.MonasteryID == MonansteryId).Select(f => new MyFathers
            {
                Image = f.Image,
                Name = f.Name,
                MainStoryTitle = f.MainStoryTitle,
                StoryTitles = f.StoryTitles.Select(s=> new MyFatherStoryTitle {
                    Title = s.Title,
                    Paragraphs = s.StoryParagraphs.Select(p=>p.Paragraph).ToList()
                }).ToList()
            }).ToList();
            return fathers;
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