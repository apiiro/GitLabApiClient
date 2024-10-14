using Newtonsoft.Json;

namespace GitLabApiClient.Models.Runners.Responses
{
    public sealed class RunnerToken
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
