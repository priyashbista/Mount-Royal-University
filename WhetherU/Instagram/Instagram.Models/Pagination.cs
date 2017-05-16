﻿using Newtonsoft.Json;

namespace Instagram.Models {
    public class Pagination {
        [JsonProperty("next_url")]
        public string NextUrl { get; set; }
        [JsonProperty("next_max_id")]
        public string NextMaxId { get; set; }
        [JsonProperty("next_min_id")]
        public string NextMinId { get; set; }
    }
}
