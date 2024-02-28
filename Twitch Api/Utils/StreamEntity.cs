using JT7SKU.Lib.Twitch.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Api.Utils
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ChannelEntity
    {
       [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public TimeSpan? OfflineAfter { get; set; }
        [JsonProperty]
        public DateTime? LastCommunicationDateTime { get; set; }
        [JsonProperty]
        public string TimeoutQueueMessageId { get; set; }
        [JsonProperty]
        public string TimeoutQueueMessagePopReceipt { get; set; }

        private readonly ILogger<ChannelEntity> logger;
        private readonly Channel timeoutQueue;
        private readonly IEnumerable<SignalRMessageAction> signalRMessages;

        public ChannelEntity(string Id,ILogger<ChannelEntity> logger, Channel timeoutQueue, IEnumerable<SignalRMessageAction> signalRMessages)
        {
            this.Id = Id;
            this.logger = logger;
            this.timeoutQueue = timeoutQueue;
            this.signalRMessages = signalRMessages;

            if (!OfflineAfter.HasValue)
            {
                OfflineAfter = TimeSpan.FromSeconds(30);
            }
        }

        //[Function(nameof(ChannelEntity))]
        //public static async Task HandleEntityOperation([EntityTrigger]TaskEntityDispatcher dispatcher, [SignalROutput(HubName ="channelstatus")]IEnumerable<SignalRMessageAction> signalRMessages, [QueueO:utput("timeoutQueue", Connection="AzureWebJobs")]Channel timeoutQueue, ILogger<ChannelEntity> logger)
        //{
        //    if (!dispatcher.HasState)
        //    {
        //        context.SetState(new ChannelEntity(context.EntityKey, logger, timeoutQueue, signalRMessages));
        //    }
        //    await dispatcher.DispatchAsync<ChannelEntity>( );
        //}

        //public async Task MessageReceived()
        //{
        ////this.LastCommunicationDateTime = DateTime.UtcNow;

        ////bool addTimeoutMessage = true;
        ////if (this.TimeoutQueueMessageId != null)
        ////{
        ////    try
        ////    {
        ////        // reset the timeout

        ////        var message = new CloudQueueMessage(this.TimeoutQueueMessageId, this.TimeoutQueueMessagePopReceipt);
        ////        await this.timeoutQueue.UpdateMessageAsync(message, this.OfflineAfter.Value, MessageUpdateFields.Visibility);
        ////        this.TimeoutQueueMessagePopReceipt = message.PopReceipt;
        ////        addTimeoutMessage = false;
        ////    }
        ////    catch (StorageException)
        ////    {
        ////        // once... there was a message, not any more
        ////        addTimeoutMessage = true;
        ////    }
        ////}
        ////if (addTimeoutMessage)
        ////{
        ////    // start timeout 

        ////    var message = new Queue(this.Id);
        ////    await timeoutQueue.AddMessageAsync(message, null, this.OfflineAfter, null, null);
        ////    this.TimeoutQueueMessageId = message.Id;
        ////    this.TimeoutQueueMessagePopReceipt = message.PopReceipt;

        ////    await this.ReportState("online");
        ////    this.logger.LogInformation($"Channel ${this.Id} if now online");
        ////    this.logger.LogMetric("online", 1);
        ////}
        //await Task.CompletedTask;
        //}
        //private async Task ReportState(string state)
        //{
        ////try
        ////{
        ////    await this.signalRMessages.AddAsync(new SignalRMessage
        ////    {
        ////        Target = "statusChanged",
        ////        Arguments = new[] { new { channelId = this.Id, status = state } }
        ////    });
        ////}
        ////catch (Exception)
        ////{

        ////    throw;
        ////}
        //await Task.CompletedTask;
        //}

        //public async Task ChannelTimeout()
        //{
        ////this.TimeoutQueueMessageId = null;
        ////this.TimeoutQueueMessagePopReceipt = null;

        ////await this.ReportState("offline");
        //await Task.CompletedTask;
        //}
    }
}
