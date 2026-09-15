using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class MaterialListTotals : Entity
	{

		[DataMember(Name="EstimatedTotalCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotalCost { get; set; }

		[DataMember(Name="EstimatedVariance", EmitDefaultValue=false)]
		public DecimalValue? EstimatedVariance { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="RequiredQty", EmitDefaultValue=false)]
		public DecimalValue? RequiredQty { get; set; }

		[DataMember(Name="TotalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalBudgetedAmount { get; set; }

	}
}