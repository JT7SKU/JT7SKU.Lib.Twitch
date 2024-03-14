using JT7SKU.Lib.Twitch.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream.Komponent.Utility.Extension.Twitch
{
    partial class VideoOverlay : ComponentBase
    {
        [Parameter]
        public ExtensionVideoOverlay ExtensionVideoOverlay { get; set; }
    }
}
