﻿using System.Web;
using System.Web.Mvc;

namespace RetailUseCase_OCR_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
