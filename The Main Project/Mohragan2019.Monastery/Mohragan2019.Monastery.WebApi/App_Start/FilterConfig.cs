﻿using System.Web;
using System.Web.Mvc;

namespace Mohragan2019.Monastery.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
