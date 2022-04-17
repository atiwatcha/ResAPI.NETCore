using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UserApiTestEntToEnd.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace UserApiTestEntToEnd
{
    public class UserControllerTest
    {
        private HttpClient _HttpClient;
        private ITestOutputHelper _Output;

        public UserControllerTest(ITestOutputHelper output)
        {
            _HttpClient = TestHttpClientFactory.Create();
            _Output = output;
        }

        [Fact]
        public async Task GetUsers_Alluser_Ok()
        {
            // Arrange
            var endpoint = "/Users";

            // Act
            var result = await _HttpClient.GetAsync(endpoint);

            // Assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);

            var content = await result.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<List<dynamic>>(content);

            _Output.WriteLine(content);
            Assert.True(user.Any());
        }

        [Fact]
        public async Task CreateUsers_Ok()
        {
            // Arrange
            var endpoint = "/Users";
            var user = new
            {
                //Id= Guid.NewGuid(),
                Name = "Atiwat Chananet"
            };
            var data = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            // Act
            var result = await _HttpClient.PostAsync(endpoint, data);

            // Assert
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);

            var content = await result.Content.ReadAsStringAsync();
            var responstUser = JsonConvert.DeserializeObject<dynamic>(content);

            _Output.WriteLine(content);
            Assert.NotNull(responstUser);
            Assert.NotNull(responstUser.id.ToString());
        }
    }
}
