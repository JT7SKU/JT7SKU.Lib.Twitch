using System;
using System.Threading.Tasks;
using DurableTask.Core.Entities;
using JT7SKU.Lib.Twitch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Client.Entities;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Twitch_Api.Utils;

namespace Twitch_Api.Functions
{
    public static class ChannelOfflineDetectionFunctions
    {
        [Function(nameof(QueueTrigger))]
        public static async Task QueueTrigger([QueueTrigger("channel-messages", Connection = "AzureWebStorage")]string message, [DurableClient] DurableEntityClient durableEntityClient, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {message}");

            var entity = new EntityInstanceId(nameof(ChannelEntity), message);
            await durableEntityClient.SignalEntityAsync(entity, nameof(ChannelEntity.MessageReceived));
        }

        [Function(nameof(HandleOfflineMessage))]
        public static async Task HandleOfflineMessage([DurableClient]DurableEntityClient durableEntityClient, [QueueTrigger("timeoutQueue", Connection = "AzureWebJobsStorage")]string message, ILogger log)
        {
            var channelId = message;

            var entity = new EntityInstanceId(nameof(ChannelEntity), channelId);
            await durableEntityClient.SignalEntityAsync(entity, nameof(ChannelEntity.ChannelTimeout));

            log.LogInformation($"Device ${channelId} if now offline");
            log.LogMetric("offline", 1);
        }

        [Function(nameof(GetStatus))]
        public static async Task<IActionResult> GetStatus([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpTriggerArgs args, [DurableClient] DurableEntityClient durableEntityClient)
        {
            var entity = new EntityInstanceId(nameof(ChannelEntity), args.ChannelID);
            var device = await durableEntityClient.GetEntityAsync<ChannelEntity>(entity);
            return new OkObjectResult(device);
        }
    }
}
