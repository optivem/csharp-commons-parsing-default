using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Atomiv.Core.Common.Http;
using Atomiv.Core.Common.Reflection;
using Atomiv.Core.Common.Serialization;
using Atomiv.Infrastructure.AspNetCore;
using Atomiv.Infrastructure.NewtonsoftJson;
using Atomiv.Infrastructure.System.Reflection;
using Cli.Core.Application.MyFoos.Services;
using Cli.Web.RestClient;
using Cli.Web.RestClient.Http;
using Cli.Web.RestClient.Interface;
using Cli.Web.UI.Services;
using Cli.Web.UI.Services.Interfaces;

namespace Cli.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // NOTE: This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.Configure<ApiClientOptions>(Configuration.GetSection("ApiClient"));

            services.AddScoped<IClient, ApiClient>();
            services.AddScoped<IJsonSerializer, JsonSerializer>();
            services.AddScoped<IPropertyMapper, PropertyMapper>();

            services.AddScoped<IControllerClientFactory, JsonControllerClientFactory>();
            services.AddScoped<IMyFooHttpService, MyFooHttpService>();
            services.AddScoped<IMyFooService, MyFooService>();
            services.AddScoped<IMyFooPageService, MyFooPageService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // NOTE: The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
