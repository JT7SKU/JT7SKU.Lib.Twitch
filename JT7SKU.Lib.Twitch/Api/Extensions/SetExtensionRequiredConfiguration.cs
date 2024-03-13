using Orleans.Streams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class SetExtensionRequiredConfiguration
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external and 'userId field that user who owns the extension
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/required_configuration";
        public SetExtensionRequiredConfigurationRequestQuery RequestQuery { get; set; }
        public SetExtensionRequiredConfigurationRequestBody RequestBody { get; set; }
        public SetExtensionRequiredConfigurationResponseCodes ResponseCodes { get; set; }
    }
    public record SetExtensionRequiredConfigurationRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record SetExtensionRequiredConfigurationRequestBody
    {
        [Required]
        public string ExtensionId { get; set; }
        [Required]
        public string ExtensionVersion { get; set; }
        [Required]
        public string RequiredConfiguration {  get; set; }
    }
    public enum SetExtensionRequiredConfigurationResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401
    }
}
