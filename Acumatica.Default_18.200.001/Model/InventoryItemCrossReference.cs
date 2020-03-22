using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class InventoryItemCrossReference : Entity
	{

		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue AlternateID { get; set; }

		[DataMember(Name="AlternateType", EmitDefaultValue=false)]
		public StringValue AlternateType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue VendorOrCustomer { get; set; }

	}
}