﻿using System.Web;
using System.Web.Mvc;

namespace Nop.Plugin.Widgets.ProductAction
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
