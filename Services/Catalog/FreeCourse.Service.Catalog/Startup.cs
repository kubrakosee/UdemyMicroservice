using FreeCourse.Service.Catalog.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace FreeCourse.Service.Catalog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //AutoMapper.Extensions.Microsoft.DependencyInjection yükledikten sonra
            services.AddAutoMapper(typeof(Startup));
            //bu startupdaki classlarýn baðlý olduðu sml deki tüm mapperlarý tarayacak kendisi HANGÝ mapperlarý tarayacak hemen projeye gel sað týkla new folder de MAPPÝNG adýnda klasör oluþtur içine class oluþtur adý da GeneralMapping diyelim genel olsun


            //IOptions<DatabaseSettings>options
            //    options.value //þeklinde verebilirim
            //appsetting okumanýn bir çok yöntemi vardýr

            services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSetting"));//artýk bu ifadeyle herhangi bir classý IOptions a geçerek kullanabilirim.Ama ben interface üzerinden gelsin
            services.AddSingleton<IDatabaseSettings>(sp =>
            {
                return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
            });


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FreeCourse.Service.Catalog", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FreeCourse.Service.Catalog v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
