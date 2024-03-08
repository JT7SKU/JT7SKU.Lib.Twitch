using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Bits
{
    public class GetBitsLeaderboard
    {
        public string BitsLearboardsScope { get; set; } = "bits:read";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/bits/leaderboard";
    }
    public record BitsLeaderBoardRequestBody
    {
        public int Count { get; set; }
        public string Period { get; set; } // time period
        public string StartedAt { get; set; }
        public string UserId { get; set; }
    }
    public record BitsLeaderBoardResponseBody
    {
        public BitsLeaderBoardData Data { get; set; }
        public BitsLeaderBoardDataRange DataRange { get; set; }
        public int Total { get; set; }
    }
    public record BitsLeaderBoardData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public int Rank { get; set; }
        public int Score { get; set; }
    }
    public record BitsLeaderBoardDataRange
    {
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
    }
}
