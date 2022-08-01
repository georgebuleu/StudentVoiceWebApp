using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using StudentVoice.Api;
using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Integration.Tests
{
    [TestClass]
    public class UserControllerTests
    {
        [TestMethod]
        public async Task When_AddUser_ShouldInsertUser()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var model = new UserModel
            {
                FirstName = "Cosmin",
                LastName = "Capraru",
                Email = "cosmin@gmail.com",
                Password = "1234",
                IsAdmin = false,
            };

            var result = await client.PostAsJsonAsync("api/user", model);
            result.EnsureSuccessStatusCode();
            var userIdFromResult = await result.Content.ReadAsStringAsync();
            Assert.AreEqual("2", userIdFromResult);

            var resultOfGetUserById = await client.GetAsync($"api/user{userIdFromResult}");
            resultOfGetUserById.EnsureSuccessStatusCode();
            var userFromResult = await resultOfGetUserById.Content.ReadFromJsonAsync<User>();
            userFromResult.Should().NotBeNull();
            userFromResult.Id.ToString().Should().Be(userIdFromResult);
        }

        [TestMethod]
        public async Task When_UpdateUser_ShouldChangeUser()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var addUserModel = new UserModel
            {
                FirstName = "Andrei",
                LastName = "Capraru",
                Email = "andrei@gmail.com",
                Password = "1234",
                IsAdmin = false,
            };

            var result = await client.PostAsJsonAsync("api/user", addUserModel);
            result.EnsureSuccessStatusCode();
            var userIdFromResult=await result.Content.ReadAsStringAsync();
            var newPassword = "12345";

            var user = new User
            {
                Id = Convert.ToInt32(userIdFromResult),
                FirstName = "Andrei",
                LastName = "Capraru",
                Email = "andrei@gmail.com",
                Password = newPassword,
                isAdmin = false,
            };

            var resultForUpdateUser = await client.PutAsJsonAsync("api/user", user);
            resultForUpdateUser.EnsureSuccessStatusCode();
        }

        [TestMethod]

        public async Task When_DeleteUser()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var addUserModel = new UserModel
            {
                FirstName = "Alex",
                LastName = "Campanu",
                Email = "alex1@gmail.com",
                Password = "1234",
                IsAdmin = false,
            };

            var result = await client.PostAsJsonAsync("api/user", addUserModel);
            result.EnsureSuccessStatusCode();

            var userIdFromResult= await result.Content.ReadAsStringAsync();
            var resultForDeleteUser = await client.DeleteAsync($"api/user/{userIdFromResult}");
            resultForDeleteUser.EnsureSuccessStatusCode();
        }
    }
}
