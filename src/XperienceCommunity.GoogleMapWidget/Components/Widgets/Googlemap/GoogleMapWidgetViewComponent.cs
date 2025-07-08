using CMS;
using CMS.Core;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using XperienceCommunity.GoogleMapWidget.Components.Widgets.Googlemap;

[assembly: AssemblyDiscoverable]
[assembly:
    RegisterWidget(
        identifier: GoogleMapWidgetViewComponent.IDENTIFIER,
        viewComponentType: typeof(GoogleMapWidgetViewComponent),
        name: "GoogleMap Widget",
        propertiesType: typeof(GoogleMapWidgetProperties),
        Description = "GoogleMapWidget.",
        IconClass = "icon-map-marker")]
namespace XperienceCommunity.GoogleMapWidget.Components.Widgets.Googlemap
{
    /// <summary>
    /// Controller for GoogleMap widget.
    /// </summary>
    public class GoogleMapWidgetViewComponent : ViewComponent
    {
        /// <summary>
        /// Widget identifier.
        /// </summary>
        public const string IDENTIFIER = "RBT.XBYK.Custom.Widgets.GoogleMapWidget";
        private readonly IConfiguration configuration;
        private readonly IEventLogService eventLogService;
        public GoogleMapWidgetViewComponent(IConfiguration configuration, IEventLogService eventLogService)
        {
            this.configuration = configuration;
            this.eventLogService = eventLogService;
        }
        public async Task<IViewComponentResult> InvokeAsync(GoogleMapWidgetProperties properties)
        {
            try
            {
                string? googleApiKey = configuration["GoogleMapsApiKey"];

                return await Task.FromResult((IViewComponentResult)View("~/Components/Widgets/Googlemap/_GoogleMap.cshtml", new GoogleMapWidgetViewModel
                {
                    IsVisible = properties.IsVisible,
                    Latitude = properties.Latitude,
                    Longitude = properties.Longitude,
                    ApiKey = googleApiKey
                }));
            }
            catch (Exception ex)
            {
                eventLogService.LogException(nameof(GoogleMapWidgetViewComponent), nameof(InvokeAsync), ex);
                return await Task.FromResult<IViewComponentResult>(Content(string.Empty));
            }
        }
    }
}