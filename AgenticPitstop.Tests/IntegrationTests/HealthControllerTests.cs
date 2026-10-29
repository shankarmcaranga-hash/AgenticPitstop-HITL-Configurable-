using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenticPitstop;
using Microsoft.VisualStudio.TestPlatform.TestHost; // Assumes your Program class is in the AgenticPitstop namespace

namespace AgenticPitstop.Tests.IntegrationTests
{
    public class HealthControllerTests :
     IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public HealthControllerTests(
            WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Health_Returns_OK()
        {
            var response =
                await _client.GetAsync("/health");

            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
