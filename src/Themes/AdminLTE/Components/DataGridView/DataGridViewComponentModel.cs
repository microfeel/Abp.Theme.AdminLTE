using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Button;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Table;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.UI.Navigation;

namespace MicroFeel.Abp.Theme.AdminLTE.Components
{
    public class DataGridViewComponentModel
    {
        public AbpTableTagHelper TableProperties { get; set; }
        public List<DataGriidMainToolBar> Toolbars { get; set; }
        public string ResourceName { get; set; }
        public List<string> TableHeads { get; set; }
    }

    public enum ToolbarAlign
    {
        text_left,
        text_right,
        text_center
    }

    public class DataGriidMainToolBar
    {
        public string Id { get; set; }
        public List<AbpButtonGroup> Groups { get; set; }
        public int Space { get; set; }
        public ToolbarAlign ToolBar { get; set; }
        public string Width { get; set; } = "_6";
    }

    public class AbpButtonGroup
    {
        public string Id { get; set; }
        public List<AbpButtonTagHelper> Buttons { get; set; }
        public AbpButtonGroupTagHelper GroupProperty { get; set; }
    }
}
