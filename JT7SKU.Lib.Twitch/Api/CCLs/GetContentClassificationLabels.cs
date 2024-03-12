using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.CCLs
{
    public class GetContentClassificationLabels
    {
       //requires an App Access Token or User Access Token
       public string ClientUrl { get; set; }
        public string PathUrl { get; set; } = "/content_classification_labels";
        public GetContentClassificationLabelsRequestQuery RequestQuery { get; set; }
        public GetContentClassificationLabelsResponseBody ResponseBody { get; set; }
    }
    public record GetContentClassificationLabelsRequestQuery
    {
        public string Locale { get; set; }
    }
    public record GetContentClassificationLabelsResponseBody
    {
        public GetContentClassificationLabelsData Data { get; set; }
    }
    public record GetContentClassificationLabelsData
    {
        public ContentClassificationLabel Labels { get; set; }
    }
}
