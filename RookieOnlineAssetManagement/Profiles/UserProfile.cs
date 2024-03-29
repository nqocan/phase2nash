﻿using AutoMapper;
using RookieOnlineAssetManagement.Entities;
using RookieOnlineAssetManagement.Models;

namespace RookieOnlineAssetManagement.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<User, UserDto>().ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == Enum.Gender.Female ? "Female" : "Male")).ReverseMap();
            CreateMap<UserEditDto, User>();
        }
    }
}
