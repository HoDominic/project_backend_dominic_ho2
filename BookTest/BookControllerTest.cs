using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BookAPI.DTO;
using BookAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;


namespace BookTest
{
    public class BookControllerTest : IClassFixture<ApiWebapplicationFactory>
    {

        public HttpClient Client { get; set; }


        public BookControllerTest(ApiWebapplicationFactory fixture)
        {
            Client = fixture.CreateClient();
        }



        [Fact]
        public async Task Get_Genres_Should_Return_Ok()
        {

            var response = await Client.GetAsync("/api/genres/");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            // var genres = JsonConvert.DeserializeObject<List<BookGenre>>(await response.Content.ReadAsStringAsync());
            // Assert.True(genres.Count > 0);

        }

        [Fact]
        public async Task Get_Suppliers_Should_Return_Ok()
        {

            var response = await Client.GetAsync("/api/suppliers/");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            // var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(await response.Content.ReadAsStringAsync());
            // Assert.True(suppliers.Count > 0);

        }

        [Fact]
        public async Task Get_Books_Should_Return_Ok()
        {

            var response = await Client.GetAsync("/api/books/");
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            // var books = JsonConvert.DeserializeObject<List<Book>>(await response.Content.ReadAsStringAsync());
            // Assert.True(books.Count > 0);

        }
    }
}
