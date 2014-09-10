using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TempDataNotifications.Common
{
    public static class Notify
    {
        /// <summary>
        /// Handles showing all server side notifications
        /// </summary>
        /// <param name="html"></param>
        /// <param name="tempData"></param>
        /// <returns></returns>
        public static MvcHtmlString ShowNotification(this HtmlHelper html, List<Notification> tempData)
        {
            // Create new StringBuilder to hold all the output
            StringBuilder output = new StringBuilder();
             
            // Pull out the List<Notifications> from the TempData object
            List<Notification> notifications = tempData;
 
            // If they are not null and not empty build the script
            if (notifications != null && notifications.Count > 0)
            {
                // Pull out each type of notification to process
                List<Notification> pageNotifications = notifications.Where(x => x.Area == NotifyArea.Page).ToList();
                List<Notification> footerNotifications = notifications.Where(x => x.Area == NotifyArea.Footer).ToList();
 
                // Add Document.Ready script beginning
                output.Append("<script type='text/javascript'>");
                output.Append("$(document).ready(function () {");
 
                // If there are footer notifications add them to the function call
                if (footerNotifications.Count > 0)
                {
                    // StringBuilder to build out notifications script
                    StringBuilder allBusinessMessages = new StringBuilder();
 
                    foreach (var not in footerNotifications)
                    {
                        allBusinessMessages.Append("NOTIFICATION_JS.showFooterNotification('" + not.Type + "','" + not.Message + "');");
                    }
 
                    output.Append(allBusinessMessages.ToString());
                }

                // If there are page notifications add them to the function call
                if (pageNotifications.Count > 0)
                {
                    // StringBuilder to build out notifications script
                    StringBuilder allPageMessages = new StringBuilder();
 
                    foreach (var not in pageNotifications)
                    {
                        allPageMessages.Append("NOTIFICATION_JS.showPageNotification('" + not.Type + "','" + not.Message + "');");
                    }
 
                    output.Append(allPageMessages.ToString());
                }
 
                // Add Document.Ready script ending
                output.Append("});");
                output.Append("</script>");
            }
 
            return new MvcHtmlString(output.ToString());
        }
    }
}