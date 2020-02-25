using APIUser.DTOs;
using APIUser.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIUser.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly APIUserContext _context;

        public UserRepository(APIUserContext context)
        {
            _context = context;
        }

        public UserDto GetUserById(int id)
        {
            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            var userDto = user.ToDto();

            return userDto;
        }

        public ICollection<UserDto> GetAllUsers()
        {
            
            var users = _context.Users.Where(x => x.Id > 0).ToList();
            var usersDto = users.ToDto();

            return usersDto;
        }

        public int InsertUser(UserDto userDto)
        {
            int res = 0;

            if(_context.Users.Any(x => x.Id == userDto.Id))
                return -1;

            var user = userDto.ToModel();

            user.CreateDate = DateTime.Now;
            user.UpdateTime = DateTime.Now;

            _context.Users.Add(user);
            res = _context.SaveChanges();

            return res;
        }

        public int UpdateUser(UserDto userDto)
        {
            int res = 0;

            if (userDto.Id <= 0)
                return -1;

            if (!_context.Users.Any(x => x.Id == userDto.Id))
                return -1;

            var userBD = _context.Users.Where(x => x.Id == userDto.Id).FirstOrDefault();

            if (userBD != null)
            {
                userBD.Name = userDto.Name;
                userBD.LastName = userDto.LastName;
                userBD.Address = userDto.Address;
                userBD.UpdateTime = DateTime.Now;

                _context.Users.Update(userBD);
                res = _context.SaveChanges();

                return res;
            }
            return -1;
        }

        public int DeleteUser(int id)
        {
            int res = 0;

            if (id <= 0)
                return -1;

            if (!_context.Users.Any(x => x.Id == id))
                return -1;

            var user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (user != null)
            {
                _context.Users.Remove(user);
                res = _context.SaveChanges();

                return res;
            }
            return -1;
        }
    }
}
