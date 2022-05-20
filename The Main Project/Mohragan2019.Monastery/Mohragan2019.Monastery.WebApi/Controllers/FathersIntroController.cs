using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/FathersIntro")]
    public class FathersIntroController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("GetFathersByMonasteryID/{monasteryID}")]
        public MyFathersIntro GetFathersByMonasteryID(int monasteryID)
        {
            var context = new MonasteryEntities();
            var fathersintro = context.FathersIntroes.Where(fi => fi.MonasteryID == monasteryID).Select(fi => new MyFathersIntro
            {
                TitleOfPage = fi.TitleOfPage,
                IntroText = fi.IntroText
            }).FirstOrDefault();
            return fathersintro;
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