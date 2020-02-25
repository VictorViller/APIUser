using APIUser.DTOs;
using System.Collections.Generic;

namespace APIUser.Repository
{
    public interface IUserRepository
    {
        UserDto GetUserById(int id);
        ICollection<UserDto> GetAllUsers();
        int InsertUser(UserDto userDto);
        int UpdateUser(UserDto userDto);
        int DeleteUser(int id);
    }
}
