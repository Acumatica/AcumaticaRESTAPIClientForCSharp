using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class LaborCostRate : Entity, ITopLevelEntity
	{

		[DataMember(Name="AnnualRate", EmitDefaultValue=false)]
		public DecimalValue? AnnualRate { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="HourlyRate", EmitDefaultValue=false)]
		public DecimalValue? HourlyRate { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		[DataMember(Name="RegularHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? RegularHoursPerWeek { get; set; }

		[DataMember(Name="TypeOfEmployment", EmitDefaultValue=false)]
		public StringValue? TypeOfEmployment { get; set; }

		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue? UnionLocalID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}