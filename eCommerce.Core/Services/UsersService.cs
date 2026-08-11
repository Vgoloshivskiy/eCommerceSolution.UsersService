using eCommerce.Core.Entities.DTO;
using System;
using System.Collections.Generic;
using eCommerce.Core.Entities;
using System.Text;
using AutoMapper;

namespace eCommerce.Core.Services
{
    internal class UsersService : eCommerce.Core.ServiceContracts.IUsersService
    {
        private readonly eCommerce.Core.RepositoryContracts.IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersService(eCommerce.Core.RepositoryContracts.IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<AuthenticationResponse?> Login(LoginRequest request)
        {
             ApplicationUser? user = await _userRepository.GetUserByEmailAndPassword(request.Email, request.Password);


            if (user == null)
            {
                return null;
            }
            else
            {
                return _mapper.Map<AuthenticationResponse>(user) with { Success = true , Token = "token_dummy" };
            }
        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest request)
        {
            var user = _mapper.Map<ApplicationUser>(request);
            var db_user = await _userRepository.AddUser(user);
            if (db_user == null)
            {
                return null;
            }
            else
            {

                return _mapper.Map<AuthenticationResponse>(db_user) with { Success = true, Token = "token_dummy" };
            }
        }
    }
}
