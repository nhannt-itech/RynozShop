using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RynozShop.Data.EF
{
    public class RShopDBContextFactory : IDesignTimeDbContextFactory<RShopDBContext>
    {

        //Microsoft.Extensions.Configuration.FileExtensions
        //Microsoft.Extensions.Configuration.Json
        //Set Startup Project Data
        //Add-Migration Initial
        //update-database
        public RShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("RynozShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<RShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new RShopDBContext(optionsBuilder.Options);
        }
    }
}
