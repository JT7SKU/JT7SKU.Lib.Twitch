using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class CreateExtensionSecret
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/jwt/secrets";
        public CreateExtensionSecretRequestQuery RequestQuery { get; set; }
        public CreateExtensionSecretResponseBody ResponseBody { get; set; }
        public CreateExtensionSecretResponseCodes ResponseCodes { get; set; }
    }
    public record CreateExtensionSecretRequestQuery
    {
        [Required]
        public string ExtensionId { get; set; }
        public int Delay {  get; set; }
    }
    public record CreateExtensionSecretResponseBody
    {
        public CreateExtensionSecretData Data { get; set; }
    }
    public enum CreateExtensionSecretResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record CreateExtensionSecretData
    {
        public int FormatVersion { get; set; }
        public List<ExtensionSecret> Secrets { get; set; }
    }
}
