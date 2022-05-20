using Mohragan2019.Monastery.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mohragan2019.Monastery.WebApi.Controllers
{
    [RoutePrefix("api/Videos")]
    public class VideosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("GetVideosByMonasteryID/{monasteryID}")]
        public VideoPage GetVideosByMonasteryID(int monasteryID)
        {
            var context = new MonasteryEntities();
            var videos = context.Videos.Where(v => v.MonasteryID == monasteryID).Select(v => new MyVideos
            {
                VideoLink = v.VideoLink,
                VideoDescription = v.VideoDescription

            }).ToList();

            string monasteryName = context.Monasteries.Where(m => m.ID == monasteryID).Select(m => m.Name).FirstOrDefault();

            var videoPage = new VideoPage
            {
                MonasteryName = monasteryName,
                Videos = videos
            };

            return videoPage;
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