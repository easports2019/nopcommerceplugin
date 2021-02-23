using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.HelloWorld.Models;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.HelloWorld.Components
{
    [ViewComponent(Name = "WidgetsHelloWorld")]
    public class WidgetsNivoSliderViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;

        public WidgetsNivoSliderViewComponent(IStoreContext storeContext, 
            IStaticCacheManager staticCacheManager, 
            ISettingService settingService, 
            IPictureService pictureService,
            IWebHelper webHelper)
        {
            _storeContext = storeContext;
            _settingService = settingService;
            _webHelper = webHelper;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            var helloWorldSettings = await _settingService.LoadSettingAsync<HelloWorldSettings>((await _storeContext.GetCurrentStoreAsync()).Id);

            var model = new PublicInfoModel
            {
                Text = helloWorldSettings.Text,
            };

            if (string.IsNullOrEmpty(model.Text))
                //no pictures uploaded
                return Content("");

            return View("~/Plugins/Widgets.HelloWorld/Views/PublicInfo.cshtml", model);
        }
    }
}
