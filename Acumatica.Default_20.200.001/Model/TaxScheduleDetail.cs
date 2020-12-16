using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class TaxScheduleDetail : Entity_v4
	{

		[DataMember(Name="DeductibleTaxRate", EmitDefaultValue=false)]
		public DecimalValue DeductibleTaxRate { get; set; }

		[DataMember(Name="MaxTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue MaxTaxableAmount { get; set; }

		[DataMember(Name="MinTaxableAmount", EmitDefaultValue=false)]
		public DecimalValue MinTaxableAmount { get; set; }

		[DataMember(Name="ReportingGroup", EmitDefaultValue=false)]
		public StringValue ReportingGroup { get; set; }

		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public IntValue RevisionID { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue TaxRate { get; set; }

	}
}