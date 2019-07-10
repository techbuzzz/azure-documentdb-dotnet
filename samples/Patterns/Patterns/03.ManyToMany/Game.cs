using Newtonsoft.Json;
using System;

namespace Patterns.ManyToMany
{
    class Game
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("playerId")]
        public String PlayerId { get; set; }

        [JsonProperty("gameId")]
        public String GameId { get; set; }

        [JsonProperty("score")]
        public Double Score { get; set; }

        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("_etag")]
        public String ETag { get; set; }
    }
}
