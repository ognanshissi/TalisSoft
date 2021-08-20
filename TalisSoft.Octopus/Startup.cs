using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using TalisSoft.Octopus.Application;
using TalisSoft.Octopus.Persistence;

namespace TalisSoft.Octopus
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
            services.AddOctopusApplicationService();
            services.AddOctopusPersistenceServices(Configuration);
            services.AddControllers();
            
            // JWT
            services.AddAuthentication("Bearer")
              .AddJwtBearer("Bearer", options =>
              {
                options.Authority = "https://localhost:4343";

                options.TokenValidationParameters = new TokenValidationParameters
                {
                  ValidateAudience = false
                };
                options.Events = new JwtBearerEvents()
                {
                  OnAuthenticationFailed = c =>
                  {
                    c.NoResult();
                    c.Response.StatusCode = 500;
                    c.Response.ContentType = "text/plain";
                    return c.Response.WriteAsync(c.Exception.ToString());
                  },
                  OnChallenge = context =>
                  {
                    context.HandleResponse();
                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";
                    var result = JsonConvert.SerializeObject(new {Message = "401 Not authorized"});
                    return context.Response.WriteAsync(result);
                  },
                  OnForbidden = context =>
                  {
                    context.Response.StatusCode = 403;
                    context.Response.ContentType = "application/json";
                    var result = JsonConvert.SerializeObject("403 Not authorized");
                    return context.Response.WriteAsync(result);
                  }
                };
              });
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Octopus", Version = "v1"});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Octopus v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}