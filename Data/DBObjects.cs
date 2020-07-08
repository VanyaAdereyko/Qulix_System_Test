using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Qulix_Test_Task.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Qulix_Test_Task.Data
{
    public class DBObjects
    {
        public static void Initial(IApplicationBuilder app)
        {
            AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>()

            //if (!content.Company.Any())

            //    content.Company.AddRange(Companys.Select(c => c.Value));
            
        }
    }
}
