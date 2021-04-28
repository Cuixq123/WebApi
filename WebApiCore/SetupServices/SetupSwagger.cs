using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApiCore.SetupServices
{
    public static class SetupSwagger
    {
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));
            var ApiName = "WepApi.Core";
            services.AddSwaggerGen(c =>
            {
                typeof(CustomApiVersion.ApiVersions).GetEnumNames().ToList().ForEach(Version =>
                {
                    c.SwaggerDoc(Version, new OpenApiInfo
                    {
                        Version = Version,
                        Title = $"{ApiName} 接口文档{Version}版本---Netcore 3.1",
                        Description = $"{ApiName}的{Version}版本"
                    });
                    c.OrderActionsBy(o => o.RelativePath);
                });
                //c.SwaggerDoc("v1", new OpenApiInfo
                //{
                //    Version="V1",
                //    Title=$"{ApiName} 接口文档---Netcore 3.1",
                //    Description=$"{ApiName} Http API V1"
                //});
                //c.OrderActionsBy(o => o.RelativePath);
                //获取xml注释文件的目录
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlpath, true);//默认的第二个参数是false,这个是controller的注释。
            });
        }
    }
}
