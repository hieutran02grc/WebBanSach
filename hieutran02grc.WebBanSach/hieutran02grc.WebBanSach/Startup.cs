using hieutran02grc.WebBanSach.Data;
using hieutran02grc.WebBanSach.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace hieutran02grc.WebBanSach
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddRazorPages();
            services.AddControllersWithViews();

#if DEBUG


#endif
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseAuthorization();
            app.MapRazorPages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //    name: "Default",
                //    pattern: "bookApp/{controller=Home}/{action=Index}/{id?}");
                 
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });

            app.Run();
        }
    }
}
