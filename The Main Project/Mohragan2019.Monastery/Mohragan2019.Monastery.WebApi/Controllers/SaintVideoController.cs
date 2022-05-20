using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/SaintVideo")]
    public class SaintVideoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetSaintByMonasteryId/{MonansteryId}")]
        // GET api/<controller>/5
        public MySaintVideos GetSaintByMonasteryId(int MonansteryId)
        {
            var context = new MonasteryEntities();
            var video = context.SaintVideos.Where(v => v.MonasteryID == MonansteryId).Select(v => new MySaintVideos
            {
                VideoLink = v.VideoLink,
                VideoDescription = v.VidedoDescription
            }).FirstOrDefault();
            return video;
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