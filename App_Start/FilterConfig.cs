﻿using System.Web;
using System.Web.Mvc;

namespace Food_Sharing_Food
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
