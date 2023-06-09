using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EngineeringChangeRequest : Entity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestAttribute> Attributes { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue BOMRevision { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue ECOID { get; set; }

		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue ECRID { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestOperation> Operations { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public IntValue Priority { get; set; }

		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue RequestDate { get; set; }

		[DataMember(Name="Requestor", EmitDefaultValue=false)]
		public StringValue Requestor { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}