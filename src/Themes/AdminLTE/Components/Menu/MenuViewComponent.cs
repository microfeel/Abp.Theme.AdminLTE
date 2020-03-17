﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace MicroFeel.Abp.Theme.AdminLTE.Components.Menu
{
    public class MenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public MenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //获取当前页地址
            var pageUrl = RouteData.Values["page"];
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            //SetMenuItemActivateCssClass(pageUrl.ToString().ToUpper(), parentMenu: menu);
            return View("~/Themes/AdminLTE/Components/Menu/Default.cshtml", menu);
        }

        void SetMenuItemActivateCssClass(string pageUrl, ApplicationMenuItem menuItem = null, ApplicationMenu parentMenu = null)
        {
            ApplicationMenuItemList withItems = menuItem?.Items ?? parentMenu?.Items;

            withItems.ForEach(m =>
            {
                if (m.Url != null && (m.Url.ToUpper() == pageUrl || pageUrl == $"{m.Url}/index".ToUpper()))
                {
                    m.CssClass = "active";
                    // 存在父级
                    if (menuItem != null) menuItem.CssClass = "active menu-open";
                }
                SetMenuItemActivateCssClass(pageUrl, m, parentMenu);
            });
        }
    }
}
