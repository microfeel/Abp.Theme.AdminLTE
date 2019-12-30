using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.Toolbar.MessagesBar
{
    public class MessagesBarComponent : AbpViewComponent
    {
        private readonly IEnumerable<Message> _messages;

        public MessagesBarComponent(IEnumerable<Message> messages)
        {
            _messages = messages;
        }

        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/Toolbar/MessagesBar/Default.cshtml", _messages);
        }
    }

    public class Message
    {
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public bool HasRead { get; set; }
        public string TimeStr { get { return (DateTime.Now - Time).ToString(); } }
    }
}
