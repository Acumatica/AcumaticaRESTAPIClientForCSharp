using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CustomerPaymentMethodDetail : Entity
	{

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}