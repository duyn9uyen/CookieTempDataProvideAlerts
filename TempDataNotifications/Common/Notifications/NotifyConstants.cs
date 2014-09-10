using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempDataNotifications.Common
{
    public static class NotifyType
    {
        public static string Info = "info";
        public static string Error = "error";
        public static string Warning = "warning";
        public static string Success = "success";
    }
 
    public static class NotifyCssClass
    {
        public static string Info = "alert alert-info";
        public static string Error = "alert alert-danger";
        public static string Warning = "alert alert-warning";
        public static string Success = "alert alert-success";
    }
 
    public static class NotifyArea
    {
        public static string Footer = "Business";
        public static string Page = "Page";
    }
 
    public static class TempDataVars
    {
        public static string NotificationsList = "NotificationsList";
    }
}