using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mohragan2019.Monastery.WebApi.Models
{
    public class VideoPage
    {
        public string MonasteryName { get; set; }

        public List<MyVideos> Videos { get; set; }
    }
}