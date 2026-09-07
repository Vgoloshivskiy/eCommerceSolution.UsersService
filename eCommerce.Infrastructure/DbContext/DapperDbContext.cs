using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace eCommerce.Infrastructure.DbContext
{
    public class DapperDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;
        public DapperDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            string connectionStringTemplate = _configuration.GetConnectionString("PstgresConnection")!;
            string connectionString = connectionStringTemplate.Replace("$POSTGRES_HOST", Environment.GetEnvironmentVariable("POSTGRES_HOST"))
                                                           .Replace("$POSTGRES_PASSWORD", Environment.GetEnvironmentVariable("POSTGRES_PASSWORD"));
            _dbConnection = new NpgsqlConnection(connectionString);
        }
        public IDbConnection DbConnection => _dbConnection;
    }
}
