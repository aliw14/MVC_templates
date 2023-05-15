namespace MVC_TEMPLATESs;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();


        app.UseEndpoints(endpoint =>
        {
            endpoint.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
        });

        app.Run();
    }
}

