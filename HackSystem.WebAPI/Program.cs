using System.IO;
using HackSystem.WebAPI.DataAccess;
using HackSystem.WebAPI.DataAccess.SeedData;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace HackSystem.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                //.InitializeDatabase()
                //.InitializeIdentityData()
                //.InitializeUserProgramMapData()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(options =>
                {
                    options.SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("hosting.json", optional: true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
