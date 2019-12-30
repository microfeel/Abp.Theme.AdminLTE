using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.NotificationsBar
{
    public class NotificationsBarComponent : AbpViewComponent
    {
        private IEnumerable<Notification> _notifications;

        public NotificationsBarComponent(IEnumerable<Notification> notifications)
        {
            _notifications = notifications;
        }
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/Toolbar/NotificationsBar/Default.cshtml", _notifications);
        }
    }

    public class Notification
    {
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string TimeStr { get { return (DateTime.Now - Time).ToString(); } }
    }
}
