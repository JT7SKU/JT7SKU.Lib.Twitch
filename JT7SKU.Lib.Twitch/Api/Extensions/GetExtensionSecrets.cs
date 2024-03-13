using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class GetExtensionSecrets
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/jwt/secrets";
        public GetExtensionSecretsRequestQuery RequestQuery { get; set; }
        public GetExtensionSecretsResponseBody ResponseBody { get; set; }
        public GetExtensionSecretsResponseCodes ResponseCodes { get; set; }
    }
    public record GetExtensionSecretsRequestQuery
    {
        [Required]
        public string ExtensionId { get; set; }
    }
    public record GetExtensionSecretsResponseBody
    {
        public GetExtensionSecretsData Data { get; set; }
    }
    public enum GetExtensionSecretsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetExtensionSecretsData
    {
        public int FormatVersion { get; set; }
        public List<ExtensionSecret> Secrets { get; set; }
}
