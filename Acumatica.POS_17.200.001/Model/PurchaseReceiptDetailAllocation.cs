using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class PurchaseReceiptDetailAllocation : Entity
	{

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue ReceiptNbr { get; set; }

		[DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
		public IntValue SplitLineNbr { get; set; }

	}
}