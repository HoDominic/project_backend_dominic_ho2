using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BookAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace BookTest
{
    public class BookControllerTest : IClassFixture<WebApplicationFactory<BookAPI.Startup>>
    {

        public HttpClient Client { get; set; }


        public BookControllerTest(WebApplicationFactory<BookAPI.Startup> fixture)
        {
            Client = fixture.CreateClient();
        }
        [Fact]
        public async Task Get_Authors_Should_Return_Ok()
        {
            var response = await Client.GetAsync("/api/authors/");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var brands = JsonConvert.DeserializeObject<List<Author>>(await response.Content.ReadAsStringAsync());
            Assert.True(brands.Count > 0);

        }
    }
}
