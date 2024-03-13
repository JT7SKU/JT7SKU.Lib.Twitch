using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class SetExtensionConfigurationSegment
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/configurations";
        public SetExtensionConfigurationSegmentRequestQuery RequestQuery { get; set; }
        public SetExtensionConfigurationSegmentResponseCodes ResponseCodes { get; set; }
    }
    public record SetExtensionConfigurationSegmentRequestQuery
    {
        [Required]
        public string ExtensionId { get; set; }
        [Required]
        public ExtensionSegment Segment {  get; set; }
        public string BroadcasterId { get; set; }
        public string Content { get; set; }
        public string Version { get; set; }
    }
    
    public enum SetExtensionConfigurationSegmentResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401
    }
   
}
