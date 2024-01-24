using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class TransferOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TransferOrderDetail>? Details { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="FromWarehouseID", EmitDefaultValue=false)]
		public StringValue? FromWarehouseID { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue? ToWarehouseID { get; set; }

		[DataMember(Name="TransferType", EmitDefaultValue=false)]
		public StringValue? TransferType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}