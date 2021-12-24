using ClubManagerBackup.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagerBackup
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
         var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value);
         services.AddControllers();
         services.AddSwaggerGen(c =>
         {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClubManagerBackup", Version = "v1" });
         });
         services.AddDbContext<DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
         services.AddAutoMapper(typeof(Startup));
         services.AddMvc();
         /*    .AddJsonOptions(opt =>
         {
             opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
         });*/
         services.AddCors();
         services.AddScoped<IEventRepository, EventRepository>();
         services.AddScoped<IUserRepository, UserRepository>();
         services.AddScoped<IAuthRepository, AuthRepository>();
         services.AddScoped<IClubRepository, ClubRepository>();
         services.AddScoped<IPlaceRepository, PlaceRepository>();
         services.AddScoped<ICategoryRepository, CategoryRepository>();
         services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
         {
            options.TokenValidationParameters = new TokenValidationParameters
            {
               ValidateIssuerSigningKey = true,
               IssuerSigningKey = new SymmetricSecurityKey(key),
               ValidateIssuer = false,
               ValidateAudience = false
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
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ClubManagerBackup v1"));
         }

         app.UseHttpsRedirection();

         app.UseRouting();

         app.UseAuthorization();
         app.UseAuthentication();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });
      }
   }
}
