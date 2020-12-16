using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class DiscountCode : Entity_v4
	{

		[DataMember(Name="ApplicableTo", EmitDefaultValue=false)]
		public StringValue ApplicableTo { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountCodeID", EmitDefaultValue=false)]
		public StringValue DiscountCodeID { get; set; }

		[DataMember(Name="DiscountType", EmitDefaultValue=false)]
		public StringValue DiscountType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

	}
}