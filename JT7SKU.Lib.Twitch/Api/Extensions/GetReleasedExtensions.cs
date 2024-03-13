using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class GetReleasedExtensions
    {
        // Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/released";
        public GetReleasedExtensionsRequestQuery RequestQuery { get; set; }
        public GetReleasedExtensionsResponseBody ResponseBody { get; set; }
        public GetReleasedExtensionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetReleasedExtensionsRequestQuery
    {
        [Required]
        public string ExtensionId { get; set; }
        public string ExtensionVersion { get; set; }
    }
    public record GetReleasedExtensionsResponseBody
    {

    }
    public enum GetReleasedExtensionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record GetReleasedExtensionData
    {
        public string AuthorName { get; set; }
        public bool BitsEnabled { get; set; }
        public bool CanInstall { get; set; }
        public ExtensionConfigurationLocation ConfigurationLocation { get; set; }
        public string Description { get; set; }
        public string EulaTosUrl { get; set; }
        public bool HasChatSupport { get; set; }
        public string IconUrl { get; set; }
        public Image IconUrls { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrivacyPolicyUrl { get; set; }
        public bool RequestIdentityLink { get; set; }
        public string[] ScreenShotUrls { get; set; }
        public ExtensionState State { get; set; }
        public SubscriptionSupportLevel SubscriptionSupportLevel { get; set; }
        public string Summary { get; set; }
        public string SupportEmail { get; set; }
        public string Version { get; set; }
        public string ViewerSummary { get; set; }
        public ExtensionViews ExtensionViews { get; set; }
        public string[] AllowlistedConfigUrls { get; set; }
        public string[] AllowlistedPanelUrls { get; set; }
    }
}
