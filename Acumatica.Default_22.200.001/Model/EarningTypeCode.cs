using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningTypeCode : Entity
	{

		[DataMember(Name="AccrueTimeOff", EmitDefaultValue=false)]
		public BooleanValue AccrueTimeOff { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue Category { get; set; }

		[DataMember(Name="ContributestoWCCCalculation", EmitDefaultValue=false)]
		public BooleanValue ContributestoWCCCalculation { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EarningTypeCodeID", EmitDefaultValue=false)]
		public StringValue EarningTypeCodeID { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public EarningCodeGLAccounts GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue Multiplier { get; set; }

		[DataMember(Name="ProjectSettings", EmitDefaultValue=false)]
		public EarningCodeProjectSettings ProjectSettings { get; set; }

		[DataMember(Name="PublicHoliday", EmitDefaultValue=false)]
		public BooleanValue PublicHoliday { get; set; }

		[DataMember(Name="RegularTimeTypeCode", EmitDefaultValue=false)]
		public StringValue RegularTimeTypeCode { get; set; }

		[DataMember(Name="TaxAndReportingCA", EmitDefaultValue=false)]
		public TaxAndReportingCA TaxAndReportingCA { get; set; }

		[DataMember(Name="TaxAndReportingUS", EmitDefaultValue=false)]
		public TaxAndReportingUS TaxAndReportingUS { get; set; }

	}
}