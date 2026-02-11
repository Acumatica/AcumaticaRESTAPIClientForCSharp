using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.FileApi.Model;

using RESTClientTests.Mocks;

using Xunit;

using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace RESTClientTests
{
    public class SerializationTests
	{
        const string billJson = "[{\"id\":\"d11d2e19-7c07-f111-8cb1-ac198e472cfe\",\"rowNumber\":1,\"note\":{\"value\":\"\"},\"Amount\":{\"value\":0.0000},\"ApprovedForPayment\":{\"value\":false},\"Balance\":{\"value\":0.0000},\"BranchID\":{\"value\":\"PRODWHOLE\"},\"CashAccount\":{\"value\":\"10200\"},\"CurrencyID\":{\"value\":\"USD\"},\"Date\":{\"value\":\"2026-02-11T00:00:00-05:00\"},\"Description\":{\"value\":\"Updated description 11/02/2026 14:15:12\"},\"DueDate\":{\"value\":\"2026-03-13T00:00:00-04:00\"},\"Hold\":{\"value\":false},\"IsTaxValid\":{},\"LastModifiedDateTime\":{\"value\":\"2026-02-11T14:15:14.04-05:00\"},\"LocationID\":{\"value\":\"MAIN\"},\"PostPeriod\":{\"value\":\"022026\"},\"Project\":{\"value\":\"X\"},\"ReferenceNbr\":{\"value\":\"005933\"},\"Status\":{\"value\":\"Balanced\"},\"TaxTotal\":{\"value\":0.0000},\"Terms\":{\"value\":\"30D\"},\"Type\":{\"value\":\"Bill\"},\"Vendor\":{\"value\":\"ADPSERVICE\"},\"VendorRef\":{\"value\":\"fg\"},\"custom\":{},\"_links\":{\"self\":\"/25r2/entity/Default/24.200.001/Bill/d11d2e19-7c07-f111-8cb1-ac198e472cfe\",\"files:put\":\"/25r2/entity/Default/24.200.001/files/PX.Objects.AP.APInvoiceEntry/Document/d11d2e19-7c07-f111-8cb1-ac198e472cfe/{filename}\"},\"files\":[{\"id\":\"2a2343db-f343-431b-b177-6fc2bab921cd\",\"filename\":\"Bills and Adjustments (INV 005933)\\\\AcumaticaERP_Arena_PLM_Integration.pdf\",\"href\":\"/25r2/entity/Default/24.200.001/files/2a2343db-f343-431b-b177-6fc2bab921cd\"}]}]";

        [Fact]
		public void LinksSection_Deserializes()
        {
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent(billJson) };
                }));
            var record = client.GetList<Bill>(expand: "Files").First();
            Assert.NotNull(record.Links);
            Assert.NotNull(record.Links.Self);
            Assert.NotNull(record.Links.FileUploadLink);

		}

		[Fact]
		public void FilesSection_Deserializes()
		{
			var client = new ApiClient(
			   new HttpClientMock(async (request, ct) =>
			   {
				   return new HttpResponseMessage(HttpStatusCode.OK)
				   { Content = new StringContent(billJson) };
			   }));
			var record = client.GetList<Bill>(expand: "Files").First();
			Assert.NotNull(record.Files);
            Assert.True(record.Files.Count > 0);
		}

		[Fact]
		public void FilesSection_IsNotSerialized()
		{
			var bill =  new Bill
			{
				 ReferenceNbr = "123", 
				 Files = new List<FileLink>
				 {
					 new FileLink { Id = new System.Guid(), Filename = "file1.txt" }
				 }
			};

			new ApiClient(
			   new HttpClientMock(async (request, ct) =>
			   {
				   string? content = await request?.Content?.ReadAsStringAsync();
				   Assert.DoesNotContain("files", content);
				   Assert.Contains(nameof(Bill.ReferenceNbr), content);
				   return new HttpResponseMessage(HttpStatusCode.OK);
			   })).Put(bill);
		}

		[Fact]
		public void LinksSection_IsNotSerialized()
		{
			var bill = new Bill
			{
				ReferenceNbr = "123",
				Links = new  Acumatica.RESTClient.ContractBasedApi.FileApi.Model.Links
				{
					Self = "/entity/Default/20.200.001/Bill/123",
					FileUploadLink = "/entity/Default/20.200.001/files/PX.Objects.AP.APInvoiceEntry/Document/123/{filename}"
				}
			};

			new ApiClient(
			   new HttpClientMock(async (request, ct) =>
			   {
				   string? content = await request?.Content?.ReadAsStringAsync();
				   Assert.DoesNotContain("links", content);
				   Assert.Contains(nameof(Bill.ReferenceNbr), content);
				   return new HttpResponseMessage(HttpStatusCode.OK);
			   })).Put(bill);
		}
	}
}
