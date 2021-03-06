﻿using Newtonsoft.Json;
using System;

namespace Instagram.Models {
    public class Comment {
        //[JsonProperty("created_time"), JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedTime { get; set; }
        public string Text { get; set; }
        public UserInfo From { get; set; }
        public string Id { get; set; }
    }
}
