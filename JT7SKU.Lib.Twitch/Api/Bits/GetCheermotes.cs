using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Bits
{
    public class GetCheermotes
    {
       
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/bits/cheermotes";
        public CheermotesRequestBody CheermotesRequestBody { get; set; }
        public CheermotesResponseBody CheermotesResponseBody { get; set; }
    }
    public record CheermotesRequestBody
    {
        public string Broadcaster_Id { get; set; }
    }
    public record CheermotesResponseBody
    {
        public CheermotesData Data { get; set; }
    }
    public record CheermotesData
    {
        public string Prefix { get; set; }
        public CheermotesTiers Tiers { get; set; }
        public CheeremoteTypes Type { get; set; }
        public int Order { get; set; }
        public string Last_updated { get; set; }
        public bool Is_Charitable { get; set; }
    }
    public record CheermotesTiers
    {
        public int Min_Bits { get; set; }
        public string Id { get; set; } // tiers showing they level
        public string Color { get; set; }
        public Dictionary<int,string> Images { get; set; }
        public bool Can_Cheer { get; set; }
        public bool Show_in_bits_card { get; set; }
    }
    public enum CheeremoteTypes
    {
        global_first_party,
        global_third_party,
        channel_custom,
        display_only,
        sponsored
    }
}
