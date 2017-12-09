﻿using System;

namespace SmartGrid_ServerApp
{
    public class PendingTransaction
    {
        public string Id { get; set; }
        public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string PowerAmount { get; set; }
    }
}