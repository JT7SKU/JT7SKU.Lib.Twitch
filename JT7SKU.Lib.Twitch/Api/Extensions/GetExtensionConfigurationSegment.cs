using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class GetExtensionConfigurationSegment
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/configurations";
        public GetExtensionConfigurationSegmentRequestQuery RequestQuery { get; set; }
        public GetExtensionConfigurationSegmentResponseBody ResponseBody { get; set; }
        public GetExtensionConfigurationSegmentResponseCodes ResponseCodes { get; set; }
    }
    public record GetExtensionConfigurationSegmentRequestQuery
    {
        public string BroadcasterId { get; set; } // only required if set segment broadcaster or developer and not when set Global
        [Required]
        public string ExtensionId { get; set; }
        [Required]
        public ExtensionSegment Segment { get; set; }

    }
    public record GetExtensionConfigurationSegmentResponseBody
    {
        public GetExtensionConfigurationSegmentData Data { get; set; }
    }
    public enum GetExtensionConfigurationSegmentResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        TooManyRequests = 429
    }
    public record GetExtensionConfigurationSegmentData
    {
        public ExtensionSegment Segment {  set; get; }
        public string BroadcasterId {  set; get; }
        public string Content {  set; get; } // The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        public string Version { set; get; }
    }
}
