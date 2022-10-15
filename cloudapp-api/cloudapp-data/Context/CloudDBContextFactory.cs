using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cloudapp_data.Context
{
    public class CloudDBContextFactory: IDesignTimeDbContextFactory<CloudDBContext>
    {
        public CloudDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CloudApp");

            var optionsBuilder = new DbContextOptionsBuilder<CloudDBContext> ();
            optionsBuilder.UseSqlServer(connectionString);

            return new CloudDBContext(optionsBuilder.Options);
        }
    }
}
