using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Bits
{
    public class GetExtensionTransactions
    {
        
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/transactions";
        public ExtensionTransactionsRequestBody TransactionsRequestBody { get; set; }
        public ExtensionTransactionResponseBody TransactionResponseBody { get; set; }
    }
    public record ExtensionTransactionsRequestBody
    {
        [Required]
        public string Extension_Id { get; set; }
        public string Id { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record ExtensionTransactionResponseBody
    {
        public ExtensionTransasctionData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record ExtensionTransasctionData
    {
        public string Id { get; set; }
        public string Timestamp { get; set; }
        public string Broadcast_Id { get; set; }
        public string Broadcaster_Login { get; set; }
        public string Broadcaster_Name { get; set; }
        public string User_Id { get; set; }
        public string User_Login { get; set; }
        public string User_Name { get; set; }
        public string Product_Type { get; set; }
        public ExtensionProductData Product_Data { get; set; }
    }
    public record ExtensionProductData
    {
        public string SKU { get; set; }
        public string Domain { get; set; }
        public ProductCost Cost { get; set; }
        public bool IsDevelopment { get; set; }
        public string DisplayName { get; set; }
        public string Expiration { get; set; }
        public bool Broadcast { get; set; }
    }
    public record ProductCost
    {
        public int Amount { get; set; }
        public string Type { get; set; }
    }
}

