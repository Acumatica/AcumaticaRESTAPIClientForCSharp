using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningIncreasingApplWageDetail : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EarningTypeCategory", EmitDefaultValue=false)]
		public StringValue EarningTypeCategory { get; set; }

		[DataMember(Name="EarningTypeCode", EmitDefaultValue=false)]
		public StringValue EarningTypeCode { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

	}
}