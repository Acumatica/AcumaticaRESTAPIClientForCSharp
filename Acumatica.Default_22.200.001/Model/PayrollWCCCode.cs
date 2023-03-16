using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PayrollWCCCode : Entity
	{

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue Country { get; set; }

		[DataMember(Name="WCCCodes", EmitDefaultValue=false)]
		public List<WCCCode> WCCCodes { get; set; }

	}
}