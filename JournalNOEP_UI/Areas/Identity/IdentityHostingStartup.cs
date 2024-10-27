using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(JournalNOEP_UI.Areas.Identity.IdentityHostingStartup))]
namespace JournalNOEP_UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}