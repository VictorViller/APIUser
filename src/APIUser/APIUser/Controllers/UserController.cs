using APIUser.DTOs;
using APIUser.Extensions;
using APIUser.Models;
using APIUser.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var user = _userRepository.GetUserById(id);

            return JsonConvert.SerializeObject(user);
        }

        [HttpGet("all")]
        public ActionResult<string> GetAll()
        {
            string result = string.Empty;
            var users = _userRepository.GetAllUsers();

            foreach (var user in users)
                result += $"{JsonConvert.SerializeObject(user)}\n";

            return result;
        }

        [HttpPost]
        public void Post([FromBody] UserDto value)
        {
            _userRepository.InsertUser(value);
        }

        [HttpPut]
        public void Put([FromBody] UserDto value)
        {
            _userRepository.UpdateUser(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
