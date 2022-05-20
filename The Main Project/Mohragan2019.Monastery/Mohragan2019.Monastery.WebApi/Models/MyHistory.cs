using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mohragan2019.Monastery.WebApi.Models
{
    public class MyHistory
    {
        public string Title { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public List<string> Contents { get; set; }
    }
}