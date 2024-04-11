using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class Choices
    {
        public string Id { get; set; }
        public required string Title { get; set; }
        public int BitVotes { get; set; } = 0;
        public int ChannelPointsVotes { get; set; }
        public int Votes { get; set; }
        [SetsRequiredMembers]
        public Choices (string Title ) => (this.Title)= (Title);
    }
}
