using eCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.RepositoryContracts
{
    public interface IUserRepository
    {
        /// <summary>
        /// Create us
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ApplicationUser?> AddUser(ApplicationUser user);
        /// <summary>
        /// Method to retrieve users by their email and password (for login)
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
    }
}
