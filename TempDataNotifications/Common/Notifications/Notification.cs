using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempDataNotifications.Common
{
    [Serializable]
    public class Notification
    {
        public string Area { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Message { get; set; }

        public int DisplayOrderNumber { get; set; }
    }
}
