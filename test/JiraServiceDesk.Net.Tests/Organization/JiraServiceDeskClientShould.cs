using System;
using System.Threading.Tasks;
using Xunit;

namespace JiraServiceDesk.Net.Tests
{
    public partial class JiraServiceDeskClientShould
    {
        [Fact]
        public async Task GetOrganizationsAsync()
        {
            var results = await _client.GetOrganizationsAsync(maxPages: 2, limit: 3);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task CreateAndDeleteOrganizationAsync()
        {
            string name = nameof(CreateAndDeleteOrganizationAsync) + DateTime.UtcNow;

            var result = await _client.CreateOrganizationAsync(name);
            Assert.NotNull(result);

            bool success = await _client.DeleteOrganizationAsync(result.Id);
            Assert.True(success);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetOrganizationAsync(string id)
        {
            var result = await _client.GetOrganizationAsync(id);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetUsersInOrganizationAsync(string id)
        {
            var results = await _client.GetUsersInOrganizationAsync(id);
            Assert.NotEmpty(results);
        }
    }
}
