﻿using Newtonsoft.Json;

namespace log4net.ElasticSearchAppender.ElasticClient
{
    internal sealed class PartialElasticResponse
    {
        [JsonProperty("errors")]
        public bool Errors { get; set; }
    }
}
