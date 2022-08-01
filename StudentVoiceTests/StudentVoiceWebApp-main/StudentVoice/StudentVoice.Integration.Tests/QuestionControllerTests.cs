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
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentVoice.Integration.Tests
{
    [TestClass]
    public class QuestionControllerTests
    {
        [TestMethod]
        
        public async Task When_AddQuestion_ShouldInsertQuestion()
        {
            var aplication = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {

                });
            var client = aplication.CreateClient();

            var model = new QuestionModel
            {
                QuestionName = "What is something you liked about this class?",
                Answer = "I really liked the fact that this class focused more on the quality of code than the quantity",
                Type = "Text",
            };

            var result = await client.PostAsJsonAsync("api/question",model);
            result.EnsureSuccessStatusCode();
            var questionIdFromResult = await result.Content.ReadAsStringAsync();
            Assert.AreEqual("20", questionIdFromResult);

            var resultOfGetQuestion = await client.GetAsync("api/question");
            resultOfGetQuestion.EnsureSuccessStatusCode();
            var questionFromResult = await resultOfGetQuestion.Content.ReadFromJsonAsync<Question>();
            questionFromResult.Should().NotBeNull();

        }
    }
}
