using System.Threading.Tasks;
using Xunit;

namespace JiraServiceDesk.Net.Tests
{
    public partial class JiraServiceDeskClientShould
    {
        [Fact]
        public async Task GetServiceDesksAsync()
        {
            var results = await _client.GetServiceDesksAsync();
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetServiceDeskByIdAsync(string serviceDeskId)
        {
            var result = await _client.GetServiceDeskByIdAsync(serviceDeskId);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetServiceDeskOrganizationsAsync(string serviceDeskId)
        {
            var results = await _client.GetServiceDeskOrganizationsAsync(serviceDeskId);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetServiceDeskQueuesAsync(string serviceDeskId)
        {
            var results = await _client.GetServiceDeskQueuesAsync(serviceDeskId);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("1", "57")]
        public async Task GetServiceDeskQueueIssuesAsync(string serviceDeskId, string queueId)
        {
            var results = await _client.GetServiceDeskQueueIssuesAsync(serviceDeskId, queueId);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetServiceDeskRequestTypesAsync(string serviceDeskId)
        {
            var results = await _client.GetServiceDeskRequestTypesAsync(serviceDeskId);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("1", "4")]
        public async Task GetServiceDeskRequestTypeByIdAsync(string serviceDeskId, string requestTypeId)
        {
            var result = await _client.GetServiceDeskRequestTypeByIdAsync(serviceDeskId, requestTypeId);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("1", "4")]
        public async Task GetServiceDeskRequestTypeFieldsAsync(string serviceDeskId, string requestTypeId)
        {
            var result = await _client.GetServiceDeskRequestTypeFieldsAsync(serviceDeskId, requestTypeId);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("1")]
        public async Task GetServiceDeskRequestTypeGroupsAsync(string serviceDeskId)
        {
            var results = await _client.GetServiceDeskRequestTypeGroupsAsync(serviceDeskId);
            Assert.NotEmpty(results);
        }
    }
}
