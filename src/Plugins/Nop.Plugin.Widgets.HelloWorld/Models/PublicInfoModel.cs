using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.HelloWorld.Models
{
    public record PublicInfoModel : BaseNopModel
    {
        public string Text { get; set; }
    }
}