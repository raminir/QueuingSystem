using Core.Abstraction.ApiServices;
using Microsoft.Owin;
using QueuingSystem.WebUI.WebForms.Infrastructure.ApiServices;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Lifetime;
[assembly: OwinStartup(typeof(QueuingSystem.WebUI.WebForms.Presentation.Global))]
namespace QueuingSystem.WebUI.WebForms.Presentation
{
    public class Global : HttpApplication
    {
        public static IUnityContainer unityContainer { get; private set; }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            unityContainer = new UnityContainer();
            unityContainer.RegisterType<IQueuingService, QueuingService>(new HierarchicalLifetimeManager());
            unityContainer.RegisterType<IApiClient, ApiClient>(new HierarchicalLifetimeManager());
            unityContainer.RegisterType<ApiConfig>(new HierarchicalLifetimeManager());
            Application["UnityContainer"] = unityContainer;
        }
    }
}