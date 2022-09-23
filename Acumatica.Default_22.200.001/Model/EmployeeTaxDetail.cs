using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeTaxDetail : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue TaxCode { get; set; }

		[DataMember(Name="TaxCodeSettings", EmitDefaultValue=false)]
		public List<TaxCodeSetting> TaxCodeSettings { get; set; }

		[DataMember(Name="TaxDescription", EmitDefaultValue=false)]
		public StringValue TaxDescription { get; set; }

	}
}