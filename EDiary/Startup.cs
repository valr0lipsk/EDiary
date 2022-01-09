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
using Microsoft.AspNetCore.Authorization;

namespace EDiary
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            //������
            Configuration.Bind("Project", new Config());
            //���������� ��������� ������
            services.AddDbContext<EDContext>(options => options.UseSqlServer(Config.ConnectionString));
            services.AddControllersWithViews();
            //����������� ������� �������� �� �����
            services.AddTransient<EmailService>();
            //����������� ����������� � ������������
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddTransient<ILessonRepository, LessonRepository>();
            services.AddTransient<IMarkRepository, MarkRepository>();
            services.AddTransient<ISetMarkRepository, setMarkRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<ISubjectTaughtRepository, subjectTaughtRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            //����������� ������������� �������������
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.Password.RequiredLength = 8;   // ����������� �����
                opts.Password.RequireNonAlphanumeric = false;   // ��������� �� �� ���������-�������� �������
                opts.Password.RequireLowercase = false; // ��������� �� ������� � ������ ��������
                opts.Password.RequireUppercase = false; // ��������� �� ������� � ������� ��������
                opts.Password.RequireDigit = true; //��������� �� �����
            }).AddEntityFrameworkStores<EDContext>().AddDefaultTokenProviders();
            //���������� � ��������� ������
            services.AddSession();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(6);
            });
            //����������� �������������� � ����
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "ElectronicDiaryMRK";
                options.LoginPath = "/LogIn/Login";
                options.AccessDeniedPath = "/LogIn/AccessDenied";
                options.LogoutPath = "/LogIn/Logout";
            });
            //�������� �������� ��� ������������ � �������������
            services.AddControllersWithViews();
            //��������� �������� ����������� ��� �������
            services.AddAuthorization();
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
            //������������� ����������� ������
            app.UseStaticFiles();
            //������� �������������
            app.UseRouting();
            //�������������� � �����������
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            //��������� �������������
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=LogIn}/{action=Login}/{id?}");
            });

        }
    }
}
