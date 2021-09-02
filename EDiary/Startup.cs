using EDiary.Models;
using EDiary.Repositories;
using EDiary.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDiary.IRepositories;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace EDiary
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //конфиг
            Configuration.Bind("Project", new Config());
            //добавление контекста данных
            services.AddDbContext<EDContext>(options => options.UseSqlServer(Config.ConnectionString));
            services.AddControllersWithViews();
            //подключение интерфейсов и репозиториев
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<ILessonRepository, LessonRepository>();
            services.AddTransient<IMarkRepository, MarkRepository>();
            services.AddTransient<ISetMarkRepository, setMarkRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ISubjectTaughtRepository, subjectTaughtRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            //подключение идентификации пользователей
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.Password.RequiredLength = 10;   // минимальная длина
                opts.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                opts.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                opts.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                opts.Password.RequireDigit = true; //требуются ли цифры
            }).AddEntityFrameworkStores<EDContext>().AddDefaultTokenProviders();
            //подключение аутентификации и куки
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "ElectronicDiaryMRK";
                options.LoginPath = "/LogIn/Login";
                options.AccessDeniedPath = "/LogIn/AccessDenied";
            });
            //передача сервисов для контроллеров и представлений
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new Authorization("area", "Area"));
                //x.Conventions.Add(new teacherAuthorization("teacher", "teacherArea"));
            });
            //настройка политики авторизации для админов
            services.AddAuthorization(x =>
            {
                x.AddPolicy("area", policy => { policy.RequireRole("Area"); });
                //x.AddPolicy("teacherArea", teacherPolicy => { teacherPolicy.RequireRole("teacher"); });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //использование статических файлов
            app.UseStaticFiles();
            //система маршрутизации
            app.UseRouting();
            //аутентификация и авторизация
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            //настройка маршрутизации
            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapAreaControllerRoute(
                    name: "AdminArea",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");*/
                endpoints.MapControllerRoute("area", "{area:exists}/{controller=Home}/{action=Teacher}/{id?}");
                //endpoints.MapControllerRoute("teacher", "{area:exists}/{controller=Teacher}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=LogIn}/{action=Login}/{id?}");

            });

        }
    }
}
