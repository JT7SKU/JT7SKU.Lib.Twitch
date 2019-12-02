using System;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Queue;
using Twitch_Api.Utils;

namespace Twitch_Api.Functions
{
    public static class ChannelOfflineDetectionFunctions
    {
        [FunctionName(nameof(QueueTrigger))]
        public static async Task QueueTrigger([QueueTrigger("channel-messages", Connection = "AzureWebStorage")]CloudQueueMessage message, [DurableClient] IDurableEntityClient durableEntityClient, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {message.AsString}");

            var entity = new EntityId(nameof(ChannelEntity), message.AsString);
            await durableEntityClient.SignalEntityAsync(entity, nameof(ChannelEntity.MessageReceived));
        }

        [FunctionName(nameof(HandleOfflineMessage))]
        public static async Task HandleOfflineMessage([DurableClient]IDurableEntityClient durableEntityClient, [QueueTrigger("timeoutQueue", Connection = "AzureWebJobsStorage")]CloudQueueMessage message, ILogger log)
        {
            var channelId = message.AsString;

            var entity = new EntityId(nameof(ChannelEntity), channelId);
            await durableEntityClient.SignalEntityAsync(entity, nameof(ChannelEntity.ChannelTimeout));

            log.LogInformation($"Device ${channelId} if now offline");
            log.LogMetric("offline", 1);
        }

        [FunctionName(nameof(GetStatus))]
        public static async Task<IActionResult> GetStatus([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpTriggerArgs args, [DurableClient] IDurableEntityClient durableEntityClient)
        {
            var entity = new EntityId(nameof(ChannelEntity), args.ChannelID);
            var device = await durableEntityClient.ReadEntityStateAsync<ChannelEntity>(entity);
            return new OkObjectResult(device);
        }
    }
}
