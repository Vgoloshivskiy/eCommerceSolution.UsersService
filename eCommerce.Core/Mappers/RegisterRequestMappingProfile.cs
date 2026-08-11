using AutoMapper;
using eCommerce.Core.Entities;
using eCommerce.Core.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Mappers
{
    internal class RegisterRequestMappingProfile : Profile
    {
        public RegisterRequestMappingProfile()
        {
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender.ToString()))
                .ForMember(dest => dest.UserID, opt => opt.Ignore());
        }
    }
}
