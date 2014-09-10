using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataNotifications.Common;

namespace TempDataNotifications.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Overrides the creation of the TempDataProvider
        /// to use a Cookie based TempDataProvider instead of Session
        /// </summary> 
        protected override ITempDataProvider CreateTempDataProvider()
        {
            return new CookieTempDataProvider(HttpContext);
        }
    }
}
