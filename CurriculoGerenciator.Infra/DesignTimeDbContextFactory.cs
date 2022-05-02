﻿using CurriculoGerenciator.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CurriculoGerenciator.Infra
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CurriculoContext>
    {
        public CurriculoContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCPRE_ENVIROMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../CurriculoGerenciator.Interface/appsettings.{environmentName}.json";

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(fileName)
                .Build();

            var builder = new DbContextOptionsBuilder<CurriculoContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new CurriculoContext(builder.Options);
        }
    }
}
