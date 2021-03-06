using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/Places")]

    public class PlacesController : ApiController
    {
        private readonly List<MyPlaces> places;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("GetPlacesByMonasteryID/{monasteryID}")]
        public List<MyPlaces> GetPlacesByMonasteryID(int monasteryID)
        {
            var context = new MonasteryEntities();
            var place = context.Places.Where(p => p.MonasteryID == monasteryID).Select(p => new MyPlaces {

                Name = p.Name,
                Image = p.Image,
                ImageDescription=p.ImageDescription,
                PlaceContent=p.PlaceContent

            }).ToList();

            return place;
        }

        private void tolist()
        {
            throw new NotImplementedException();
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