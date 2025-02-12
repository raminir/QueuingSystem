using Core.Abstraction.ApiServices;
using System;
using System.Web.UI;
using Unity;

namespace QueuingSystem.WebUI.WebForms.Presentation
{
    public partial class _Default : Page
    {
        private IQueuingService queuingService;

        protected void Page_Init(object sender, EventArgs e)
        {
            // Retrieve the Unity container from Application state
            var container = (IUnityContainer)Application["UnityContainer"];

            queuingService = container.Resolve<IQueuingService>();
        }
        protected async void Page_Load(object sender, EventArgs e)
        {
            var queuingServiceResults = await queuingService.GetTicketsInProgressForTodayService();
            if (queuingServiceResults.IsSuccess)
            {
                rpt.DataSource = queuingServiceResults.Value;
                rpt.DataBind();
            }
        }
    }
}