﻿using System.Web;
using System.Web.Mvc;

namespace DotNet_Project7._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
