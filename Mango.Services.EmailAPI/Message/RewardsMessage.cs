﻿namespace Mango.Services.EmailAPI.Message
{
    public class RewardsMessage
    {
        public string UserId { get; set; } = string.Empty;
        public int RewardsActivity { get; set; }
        public int OrderId { get; set; }
    }
}
