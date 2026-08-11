using eCommerce.Core.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.ServiceContracts
{
    public interface IUsersService
    {
        /// <summary>
        /// Method to login user using Login request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Login(LoginRequest request);
        /// <summary>
        /// Method to login user using Register request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Register(RegisterRequest request);
    }
}
