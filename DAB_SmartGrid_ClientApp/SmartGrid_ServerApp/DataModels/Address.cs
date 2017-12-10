﻿namespace SmartGrid_ServerApp
{
    using Newtonsoft.Json;

    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}