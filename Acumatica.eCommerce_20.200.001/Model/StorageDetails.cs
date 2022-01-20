using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class StorageDetails : Entity_v4
	{

		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<StorageDetailsResult> Results { get; set; }

		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue SplitByLocation { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}