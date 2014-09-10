using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataNotifications.Common;

namespace TempDataNotifications.Controllers
{
    //public class HomeController : Controller

    // Here we inherit from our custom basecontroller, which uses the cookieTempDataProvider
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            this.Notify(NotifyType.Error, NotifyArea.Page, "Error: ServerSide: Page Notification");
            this.Notify(NotifyType.Success, NotifyArea.Page, "Success: ServerSide: Page Notification");

            this.Notify(NotifyType.Warning, NotifyArea.Footer, "Warning: ServerSide: Footer Notification");
            this.Notify(NotifyType.Info, NotifyArea.Footer, "Info: ServerSide: Footer Notification");


            return View();
        }

    }
}
