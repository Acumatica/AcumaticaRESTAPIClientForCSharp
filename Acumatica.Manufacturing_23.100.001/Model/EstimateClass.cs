using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EstimateClass : Entity, ITopLevelEntity
	{

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue Engineer { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="LaborMarkupPct", EmitDefaultValue=false)]
		public DecimalValue LaborMarkupPct { get; set; }

		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue LeadTimeDays { get; set; }

		[DataMember(Name="MachineMarkupPct", EmitDefaultValue=false)]
		public DecimalValue MachineMarkupPct { get; set; }

		[DataMember(Name="MaterialMarkupPct", EmitDefaultValue=false)]
		public DecimalValue MaterialMarkupPct { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue OrderQty { get; set; }

		[DataMember(Name="OverheadMarkupPct", EmitDefaultValue=false)]
		public DecimalValue OverheadMarkupPct { get; set; }

		[DataMember(Name="SubcontractMarkupPct", EmitDefaultValue=false)]
		public DecimalValue SubcontractMarkupPct { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="ToolMarkupPct", EmitDefaultValue=false)]
		public DecimalValue ToolMarkupPct { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}