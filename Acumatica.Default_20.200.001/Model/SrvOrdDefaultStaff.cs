using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdDefaultStaff : Entity_v4
	{

		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue Comment { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="ServiceLineRef", EmitDefaultValue=false)]
		public StringValue ServiceLineRef { get; set; }

		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue ServiceOrderNbr { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="StaffMemberID", EmitDefaultValue=false)]
		public StringValue StaffMemberID { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}