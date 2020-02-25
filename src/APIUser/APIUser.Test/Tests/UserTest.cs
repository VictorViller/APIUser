using APIUser.DTOs;
using APIUser.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIUser.Test.Tests
{
    public class UserTest
    {
        private Mock<IUserRepository> _userRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
        }

        [Test]
        public void Test1_InsertUser_ReturnsOkResult()
        {
            var user = new UserDto
            {
                Id = 10,
                Name = "María",
                LastName = "Fernández",
                Address = "Calle AAA"
            };

            _userRepositoryMock.Setup(x => x.InsertUser(user)).Returns(0);

            Assert.AreEqual(0, _userRepositoryMock.Object.InsertUser(user));
        }

        [Test]
        public void Test2_InsertUser_ReturnsBadResult()
        {
            var user = new UserDto
            {
                Id = 0,
                Name = "María",
                LastName = "Fernández",
                Address = "Calle AAA"
            };

            _userRepositoryMock.Setup(x => x.InsertUser(user)).Returns(-1);

            Assert.AreEqual(-1, _userRepositoryMock.Object.InsertUser(user));
        }

        [Test]
        public void Test3_UpdateUser_ReturnsOkResult()
        {
            var user = new UserDto
            {
                Id = 10,
                Name = "María",
                LastName = "Fernández",
                Address = "Calle BBB"
            };

            _userRepositoryMock.Setup(x => x.UpdateUser(user)).Returns(0);

            Assert.AreEqual(0, _userRepositoryMock.Object.UpdateUser(user));
        }

        [Test]
        public void Test4_UpdateUser_ReturnsBadResult()
        {
            var user = new UserDto
            {
                Id = 0,
                Name = "María",
                LastName = "Fernández",
                Address = "Calle BBB"
            };

            _userRepositoryMock.Setup(x => x.UpdateUser(user)).Returns(-1);

            Assert.AreEqual(-1, _userRepositoryMock.Object.UpdateUser(user));
        }

        [Test]
        public void Test5_DeleteUser_ReturnsOkResult()
        {
            int id = 10;

            _userRepositoryMock.Setup(x => x.DeleteUser(id)).Returns(0);

            Assert.AreEqual(0, _userRepositoryMock.Object.DeleteUser(id));
        }

        [Test]
        public void Test6_DeleteUser_ReturnsBadResult()
        {
            int id = 0;

            _userRepositoryMock.Setup(x => x.DeleteUser(id)).Returns(-1);

            Assert.AreEqual(-1, _userRepositoryMock.Object.DeleteUser(id));
        }
    }
}
