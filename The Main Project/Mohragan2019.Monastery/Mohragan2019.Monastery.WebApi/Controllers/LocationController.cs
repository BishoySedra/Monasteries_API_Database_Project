using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{

    [RoutePrefix("api/Location")]

    public class LocationController : ApiController
    {
        private object l;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("GetLocationByMonasteryID/{monasteryID}")]
        public MyLocation GetLocationByMonasteryID(int monasteryID)
        {
            var context = new MonasteryEntities();
            var location = context.Locations.Where(l => l.MonasteryID == monasteryID).Select(l => new MyLocation
            {

                LinkOfLocation = l.LinkOfLocation,
                HowToGoText = l.HowToGoText,
                NameOfMonastery = l.Monastery.Name

            }).FirstOrDefault();
                return location;
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