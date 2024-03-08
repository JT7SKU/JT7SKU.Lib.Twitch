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
        public string BroadcasterId { get; set; }
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
        public string LastUpdated { get; set; }
        public bool Is_Charitable { get; set; }
    }
    public record CheermotesTiers
    {
        public int MinBits { get; set; }
        public string Id { get; set; } // tiers showing they level
        public string Color { get; set; }
        public Dictionary<int,string> Images { get; set; }
        public bool CanCheer { get; set; }
        public bool ShowInBitsCard { get; set; }
    }
    public enum CheeremoteTypes
    {
        GlobalFirstParty,
        GlobalThirdParty,
        ChannelCustom,
        DisplayOnly,
        Sponsored
    }
}
