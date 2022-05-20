using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mohragan2019.Monastery.WebApi.Models
{
    public class MyFathers
    {
        public string Image { get; set; }

        public string Name { get; set; }

        public string MainStoryTitle { get; set; }

        public List<MyFatherStoryTitle> StoryTitles { get; set; }

    }
}