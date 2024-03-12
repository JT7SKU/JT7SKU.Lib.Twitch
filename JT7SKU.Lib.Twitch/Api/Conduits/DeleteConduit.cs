using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class DeleteConduit
    {
        // Requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits";
        public DeleteConduitRequestQuery RequestQuery { get; set; }
        public DeleteConduitResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteConduitRequestBody
    {
        [Required]
        public string Id { get; set; } // ConduitId
    }
    public enum DeleteConduitResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthenticated = 401,
        NotFound = 404
    }
}
