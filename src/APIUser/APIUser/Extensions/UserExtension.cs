using APIUser.DTOs;
using APIUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser.Extensions
{
    public static class UserExtension
    {
        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Address = user.Address
            };
        }

        public static User ToModel(this UserDto user)
        {
            return new User
            { 
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Address = user.Address
            };
        }

        public static List<UserDto> ToDto(this List<User> users)
        {
            var usersDto = new List<UserDto>();

            foreach (var user in users)
            {
                usersDto.Add(new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Address = user.Address
                });
            }

            return usersDto;
        }
    }
}
