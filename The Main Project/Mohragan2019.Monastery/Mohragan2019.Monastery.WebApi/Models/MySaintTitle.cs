﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mohragan2019.Monastery.WebApi.Models
{
    public class MySaintTitle
    {
        public string Title { get; set; }

        public string Image { get; set; }

        public List<string> Paragraphs { get; set; }
    }
}