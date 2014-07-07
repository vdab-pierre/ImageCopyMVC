using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageCopyMVC.Startup))]
namespace ImageCopyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
