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
    public class NotificationControllerTests
    {
        [TestMethod]

        public async Task When_AddNotification_ShouldInsertNotification()
        {
            var aplication = new WebApplicationFactory<Startup>()
               .WithWebHostBuilder(builder =>
               {

               });
            var client = aplication.CreateClient();

            var model = new NotificationModel
            {
                Notification = "Question needs to be approved",
                NotificationDate = DateTime.Now,
                isSeen = false
            };

            var result = await client.PostAsJsonAsync("api/notification", model);
            result.EnsureSuccessStatusCode();
            var notificationIdFromResult = await result.Content.ReadAsStringAsync();
            Assert.AreEqual("1", notificationIdFromResult);

            var resultOfGetNotificationById = await client.GetAsync($"api/notification/{notificationIdFromResult}");
            resultOfGetNotificationById.EnsureSuccessStatusCode();
            var notificationFromResult = await resultOfGetNotificationById.Content.ReadFromJsonAsync<Notification>();
            notificationFromResult.Should().NotBeNull();
            notificationFromResult.Id.ToString().Should().Be(notificationIdFromResult);
        }

        [TestMethod]

        public async Task SeenNotification()
        {
            var aplication = new WebApplicationFactory<Startup>()
              .WithWebHostBuilder(builder =>
              {

              });
            var client = aplication.CreateClient();

            var notificationModel = new NotificationModel
            {
                Notification = "Question needs to be approved",
                NotificationDate = DateTime.Now,
                isSeen = false
            };

            var result = await client.PostAsJsonAsync("api/notification", notificationModel);
            result.EnsureSuccessStatusCode();
            var notificationIdFromResult= await result.Content.ReadAsStringAsync();
            var isSeen = true;

            var notification = new Notification
            {
                Id = Convert.ToInt32(notificationIdFromResult),
                NotificationName = "Question needs to be approved",
                NotificationDate = DateTime.Now,
                isSeen = isSeen,
            };

            var resultForSeenNotification = await client.PutAsJsonAsync($"api/notification/{notificationIdFromResult}", notification);
            resultForSeenNotification.EnsureSuccessStatusCode();
        }
    }
}
