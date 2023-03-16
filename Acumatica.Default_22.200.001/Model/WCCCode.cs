using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WCCCode : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="wcccode", EmitDefaultValue=false)]
		public StringValue wcccode { get; set; }

		[DataMember(Name="WCCCodeCostCodeSources", EmitDefaultValue=false)]
		public List<WCCCodeCostCodeSource> WCCCodeCostCodeSources { get; set; }

		[DataMember(Name="WCCCodeLaborItemSources", EmitDefaultValue=false)]
		public List<WCCCodeLaborItemSource> WCCCodeLaborItemSources { get; set; }

		[DataMember(Name="WCCCodeMaxInsurableWages", EmitDefaultValue=false)]
		public List<WCCCodeMaxInsurableWage> WCCCodeMaxInsurableWages { get; set; }

		[DataMember(Name="WCCCodeProjectSources", EmitDefaultValue=false)]
		public List<WCCCodeProjectSource> WCCCodeProjectSources { get; set; }

		[DataMember(Name="WCCCodeRates", EmitDefaultValue=false)]
		public List<WCCCodeRate> WCCCodeRates { get; set; }

	}
}