using Newtonsoft.Json;

namespace GitLabApiClient.Models.Releases.Responses
{
    public sealed class Link
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }
    }
}
