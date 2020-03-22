using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ShopForRates : Entity
	{

		[DataMember(Name="IsManualPackage", EmitDefaultValue=false)]
		public BooleanValue IsManualPackage { get; set; }

		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue OrderWeight { get; set; }

		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue PackageWeight { get; set; }

	}
}