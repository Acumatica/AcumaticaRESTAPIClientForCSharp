using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class StorageDetail : Entity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="SiteAvailable", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailable { get; set; }

		[DataMember(Name="SiteAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforIssue { get; set; }

		[DataMember(Name="SiteAvailableforShipping", EmitDefaultValue=false)]
		public DecimalValue? SiteAvailableforShipping { get; set; }

		[DataMember(Name="SiteID", EmitDefaultValue=false)]
		public StringValue? SiteID { get; set; }

		[DataMember(Name="SiteLastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? SiteLastModifiedDate { get; set; }

		[DataMember(Name="SiteOnHand", EmitDefaultValue=false)]
		public DecimalValue? SiteOnHand { get; set; }

	}
}