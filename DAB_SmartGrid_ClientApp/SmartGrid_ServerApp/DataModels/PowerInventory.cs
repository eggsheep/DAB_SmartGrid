﻿using System;

namespace SmartGrid_ServerApp
{
    using Newtonsoft.Json;

    public class PowerInventory
    {
        [JsonProperty(PropertyName = "id")]

        public string Id { get; set; }
        public string SellerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
    }
}