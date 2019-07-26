using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ImageToText
{
    class DesignTimeDBContexFfactory : IDesignTimeDbContextFactory<MessageDBContext>
    {
        public MessageDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<MessageDBContext>();
            var connectionString = configuration.GetConnectionString("MessageServiceDB");
            builder.UseMySql(connectionString);
            return new MessageDBContext(builder.Options);
        }
    }
}
