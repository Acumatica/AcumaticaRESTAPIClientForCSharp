using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class CashTransaction : Entity, ITopLevelEntity
	{

		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		[DataMember(Name="CashAccountCD", EmitDefaultValue=false)]
		public StringValue? CashAccountCD { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CashTransactionDetail>? Details { get; set; }

		[DataMember(Name="EntryTypeCD", EmitDefaultValue=false)]
		public StringValue? EntryTypeCD { get; set; }

		[DataMember(Name="ExternalReferenceNumber", EmitDefaultValue=false)]
		public StringValue? ExternalReferenceNumber { get; set; }

		[DataMember(Name="PostedDate", EmitDefaultValue=false)]
		public DateTimeValue? PostedDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}