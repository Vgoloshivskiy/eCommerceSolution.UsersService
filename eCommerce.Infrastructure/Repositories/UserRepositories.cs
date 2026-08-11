using Dapper;
using eCommerce.Core.Entities;
using eCommerce.Core.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eCommerce.Infrastructure.Repositories
{
    internal class UserRepositories : eCommerce.Core.RepositoryContracts.IUserRepository
    {
        private readonly eCommerce.Infrastructure.DbContext.DapperDbContext _dbContext;
        public UserRepositories(eCommerce.Infrastructure.DbContext.DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            user.UserID = Guid.NewGuid();
            //add user to database using Dapper
            var query = "INSERT INTO public.\"Users\" (\"UserID\", \"PersonName\", \"Email\", \"Password\", \"Gender\")" +
                " VALUES (@UserID, @PersonName, @Email, @Password, @Gender)";

            int rowaffected =
                await _dbContext.DbConnection.ExecuteAsync(query, user);
            if (rowaffected > 0)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            string query = "SELECT * FROM public.\"Users\" WHERE \"Email\" = @Email AND \"Password\" = @Password";
            var user = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, new { Email = email, Password = password });

            return user;
        }
    }
}
