using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataNotifications.Common;

namespace System.Web.Mvc
{
    public static class NotifyHelpers
    {
        public static void Notify(this Controller controller, string type, string area, string message)
        {
            List<Notification> notifications = controller.TempData["Notifications"] as List<Notification>;

            if (notifications == null)
                notifications = new List<Notification>();

            Notification notification = new Notification();
            notification.Area = area;
            notification.Type = type;
            notification.Message = message;

            switch (type.ToUpper())
            {
                case "ERROR":
                    notification.Class = NotifyCssClass.Error;
                    notification.DisplayOrderNumber = 2;
                    break;
                case "INFO":
                    notification.Class = NotifyCssClass.Info;
                    notification.DisplayOrderNumber = 4;
                    break;
                case "SUCCESS":
                    notification.Class = NotifyCssClass.Success;
                    notification.DisplayOrderNumber = 1;
                    break;
                case "WARNING":
                    notification.Class = NotifyCssClass.Warning;
                    notification.DisplayOrderNumber = 3;
                    break;
                default:
                    notification.Class = NotifyCssClass.Info;
                    notification.DisplayOrderNumber = 4;
                    break;
            }

            notifications.Add(notification);
            notifications.OrderBy(x => x.DisplayOrderNumber);

            controller.TempData["Notifications"] = notifications;
        }
    }
}