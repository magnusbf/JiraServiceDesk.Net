using System.Threading.Tasks;
using Xunit;

namespace JiraServiceDesk.Net.Tests
{
    public partial class JiraServiceDeskClientShould
    {
        [Theory]
        [InlineData("CSM")]
        public async Task GetQueueSettingsAsync(string projectKey)
        {
            var result = await _client.GetQueueSettingsAsync(projectKey);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("CSM")]
        public async Task UseCachedQueueCount(string projectKey)
        {
            await _client.UseCachedQueueCountAsync(true, projectKey);
            var settings = await _client.GetQueueSettingsAsync(projectKey);
            Assert.True(settings.QueueCount.UseCachedQueueCount);
        }
    }
}
