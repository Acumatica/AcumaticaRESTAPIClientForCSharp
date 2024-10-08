using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;
using Acumatica.RESTClient.Api;
using RESTClientTests.Mocks;
using Acumatica.RESTClient.Client;
using System.Net.Http;
using System.Net;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using System.Collections.Generic;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;
using System.Runtime.Serialization;

namespace RESTClientTests
{
    public partial class ErrorMessagesTests
    {
        [Fact]
        public void DetailLevelErrorsAreReported()
        {
            var client = new ApiClient("http://localhost/23r211/",
                new HttpClientHandlerMock(request=>
                {
                    return new HttpResponseMessage()
                    { 
                        StatusCode= System.Net.HttpStatusCode.UnprocessableEntity, 
                        Content = new StringContent(
                      @"{""id"": ""b6410d82-9476-ef11-8c65-ac198e472cfe"", ""rowNumber"": 1,""error"": ""Inserting  'AP Transactions' record raised at least one error. Please review the errors."", ""Amount"": {""value"": 201.73}, ""Details"": [{""id"": ""b8410d82-9476-ef11-8c65-ac198e472cfe"", ""rowNumber"": 1, ""note"": { ""value"": """"},   ""Amount"": { ""value"": 201.73 }, ""InventoryID"": {}, ""Project"": { ""value"": ""TES2323T"",  ""error"": ""Project 'TES2323T  ' cannot be found in the system."" }, ""_links"": { ""files:put"": ""/23r211/entity/Default/20.200.001/files/PX.Objects.AP.APInvoiceEntry/Transactions/b8410d82-9476-ef11-8c65-ac198e472cfe/{filename}"" } } ], ""ReferenceNbr"": { ""value"": ""<NEW>"" }, ""_links"": { ""self"": ""/23r211/entity/Default/20.200.001/Bill/b6410d82-9476-ef11-8c65-ac198e472cfe"", ""files:put"": ""/23r211/entity/Default/20.200.001/files/PX.Objects.AP.APInvoiceEntry/Document/b6410d82-9476-ef11-8c65-ac198e472cfe/{filename}""}}") };



                }));
                Assert.Contains("Project 'TES2323T  ' cannot be found in the system.", 
                    Assert.Throws<ApiException>(()=>
                client.Put(new Bill())).MessageText);
        }

        [DataContract]
        public class Bill : Entity, ITopLevelEntity
        {
            public virtual string GetEndpointPath()
            {
                return "entity/Default/20.200.001";
            }
            [DataMember(Name = "ReferenceNbr", EmitDefaultValue = false)]
            public StringValue? ReferenceNbr { get; set; }
            [DataMember(Name = "Details", EmitDefaultValue = false)]
            public List<BillDetail>? Details { get; set; }
        }
        public class BillDetail : Entity
        {
         
            [DataMember(Name = "InventoryID", EmitDefaultValue = false)]
            public StringValue? InventoryID { get; set; }
            [DataMember(Name = "Amount", EmitDefaultValue = false)]
            public DecimalValue? Amount { get; set; }

            [DataMember(Name = "Project", EmitDefaultValue = false)]
            public StringValue? Project { get; set; }
        }
    }
}

