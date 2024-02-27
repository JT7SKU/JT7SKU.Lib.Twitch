using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask;
using Microsoft.DurableTask.Client;
using Microsoft.Extensions.Logging;

namespace Twitch_Api.Functions
{
    public static class GetCheers
    {
        [Function("GetCheers")]
        public static async Task<List<string>> RunOrchestrator(
            [OrchestrationTrigger] TaskOrchestrationContext context)
        {
            var outputs = new List<string>();

            // Replace "hello" with the name of your Durable Activity Function.
            outputs.Add(await context.CallActivityAsync<string>("GetCheers_Hello", "Tokyo"));
            outputs.Add(await context.CallActivityAsync<string>("GetCheers_Hello", "Seattle"));
            outputs.Add(await context.CallActivityAsync<string>("GetCheers_Hello", "London"));

            // returns ["Hello Tokyo!", "Hello Seattle!", "Hello London!"]
            return outputs;
        }

        [Function("GetCheers_Hello")]
        public static string SayHello([ActivityTrigger] string name, ILogger log)
        {
            log.LogInformation($"Saying hello to {name}.");
            return $"Hello {name}!";
        }

        [Function("GetCheers_HttpStart")]
        public static async Task HttpStart(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")]string instanceId,
            [DurableClient] DurableTaskClient starter,
            ILogger log)
        {
            // Function input comes from the request content.
            await starter.RaiseEventAsync(instanceId,"GetCheers", null);

            log.LogInformation($"Started orchestration with ID = '{instanceId}'.");

        }
    }
}