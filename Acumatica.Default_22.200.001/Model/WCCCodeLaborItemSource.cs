using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WCCCodeLaborItemSource : Entity
	{

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="WorkCodeID", EmitDefaultValue=false)]
		public StringValue WorkCodeID { get; set; }

	}
}