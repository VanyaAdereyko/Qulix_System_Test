using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Qulix_Test_Task.Data;
using Qulix_Test_Task.Data.Interfaces;
using Qulix_Test_Task.Data.Mocks;
using Qulix_Test_Task.Data.Repository;

namespace Qulix_Test_Task
{
    public class Startup
    {
        private  IConfigurationRoot _configstring;

        public Startup(IHostingEnvironment hosting)
        {
            _configstring = new ConfigurationBuilder().SetBasePath(hosting.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<ICompany, CompanyRepository>();
            services.AddTransient<IEmployee, EmployeeRepository>();
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_configstring.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            DBObjects.Initial(app);

        }
    }
}
