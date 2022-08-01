using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using StudentVoice.Api.Filters;
using StudentVoice.Api.Helper;
using StudentVoice.Api.Middleware;
using StudentVoice.Bussiness;
using StudentVoice.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Api
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
            BuildMvc(services);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StudentVoice.Api", Version = "v1" });
            });
            services.AddPersistanceServices(Configuration);
            services.AddBusinessService();
            services.AddCors(options => options.AddPolicy(name:"ApiOrigins",
               policy =>
               {
                   policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
               } ));
            
            services.AddControllers();

            services.AddAuthentication(option =>
           {
               option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
           })
                .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,

                       ValidIssuer = "https://localhost:44389",
                       ValidAudience = "https://localhost:44389",
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VERY_SECURE_AND_UNBREAKEABLE_KEY"))
                   };
               });
           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentVoice.Api v1"));
            }
            app.UseAuthentication();
            

            app.UseCors("ApiOrigins");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ExceptionHandlerMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        
        }
        private void BuildMvc(IServiceCollection services)
        {
            services.AddMvc(options => { options.Filters.Add(typeof(ValidationFilter)); })
                .AddFluentValidation(c => { c.RegisterValidatorsFromAssemblyContaining<Startup>(); });
                
        }
    }
}
