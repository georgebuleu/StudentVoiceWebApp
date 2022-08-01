
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
using FluentAssertions;
using StudentVoice.Api;
using StudentVoice.Business.Models;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Integration.Tests
{
    [TestClass]
    public class SurveyControllerTests
    {
        [TestMethod]
        public async Task When_AddSurvey_ShouldInsertSurvey()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var model = new SurveyModel
            {
                Rating=3,
                Likes=2,
                Date=DateTime.MaxValue,
                ExpirationDate=DateTime.Today,
                Professor="Pricop",
                Class="3",
                Subject="info"
            };

            

            var result = await client.PostAsJsonAsync("api/survey", model);
            result.EnsureSuccessStatusCode();
            var surveyIdFromResult = await result.Content.ReadAsStringAsync();
            Assert.AreEqual("6", surveyIdFromResult);
            var resultOfGetSurveyById = await client.GetAsync($"api/survey/{surveyIdFromResult}");
            resultOfGetSurveyById.EnsureSuccessStatusCode();
            var surveyFromResult = await resultOfGetSurveyById.Content.ReadFromJsonAsync<Survey>();
            surveyFromResult.Should().NotBeNull();
            surveyFromResult.Id.ToString().Should().Be(surveyIdFromResult);
        }

        [TestMethod]
        public async Task When_UpdateSurvey_ShouldChangeSurvey()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var addSurveyModel = new SurveyModel
            {
                Rating = 3,
                Likes = 2,
                Date = DateTime.MaxValue,
                ExpirationDate = DateTime.Today,
                Professor = "Pricop",
                Class = "3",
                Subject = "info"
            };

            var result = await client.PostAsJsonAsync("api/survey", addSurveyModel);
            result.EnsureSuccessStatusCode();
            var surveyIdFromResult = await result.Content.ReadAsStringAsync();
            var Subject = "mate";

            var survey = new Survey
            {
                Id = Convert.ToInt32(surveyIdFromResult),
                Rating = 3,
                Likes = 2,
                Date = DateTime.MaxValue,
                ExpirationDate = DateTime.Today,
                Professor = "Pricop",
                Class = "3",
                Subject = Subject
            };

            var resultForUpdateSurvey = await client.PutAsJsonAsync("api/survey", survey);
            resultForUpdateSurvey.EnsureSuccessStatusCode();
        }


        [TestMethod]
        public async Task When_DeleteSurvey()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var addSurveyModel = new SurveyModel
            {
                Rating = 3,
                Likes = 2,
                Date = DateTime.MaxValue,
                ExpirationDate = DateTime.Today,
                Professor = "Pricop",
                Class = "3",
                Subject = "info"
            };

            var result = await client.PostAsJsonAsync("api/survey", addSurveyModel);
            result.EnsureSuccessStatusCode();

            var surveyIdFromResult = await result.Content.ReadAsStringAsync();
            var resultForDeleteSurvey = await client.DeleteAsync($"api/survey/{surveyIdFromResult}");
            resultForDeleteSurvey.EnsureSuccessStatusCode();
        }
    }


}