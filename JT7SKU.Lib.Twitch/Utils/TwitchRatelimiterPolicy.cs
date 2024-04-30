
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Utils
{
    public class TwitchRatelimiterPolicy : IRateLimiterPolicy<string>
    {
        private Func<OnRejectedContext, CancellationToken, ValueTask>? _onRejected;
        private readonly TwitchRatelimitOptions _options;
        public TwitchRatelimiterPolicy(ILogger<TwitchRatelimiterPolicy> logger, IOptions<TwitchRatelimitOptions> options)
        {
            _onRejected = (ctx, token) =>
            {
                ctx.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                logger.LogWarning($"Request rejected by {nameof(TwitchRatelimiterPolicy)}");
                return ValueTask.CompletedTask;
            };
            _options = options.Value;
        }

        public Func<OnRejectedContext, CancellationToken, ValueTask>? OnRejected => _onRejected;

        public RateLimitPartition<string> GetPartition(HttpContext httpContext)
        {
            return RateLimitPartition.GetSlidingWindowLimiter(string.Empty,
                _ => new SlidingWindowRateLimiterOptions
                {
                    PermitLimit = _options.PermitLimit,
                    QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                    QueueLimit = _options.QueueLimit,
                    Window = TimeSpan.FromSeconds(_options.Window),
                    SegmentsPerWindow = _options.SegmentsPerWindow
                });
        }
    }
}
