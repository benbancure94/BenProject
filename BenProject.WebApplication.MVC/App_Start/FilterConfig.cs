﻿using System.Web;
using System.Web.Mvc;

namespace BenProject.WebApplication.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
