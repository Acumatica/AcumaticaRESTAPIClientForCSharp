using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShippingBox : Entity_v4
	{

		[DataMember(Name="ActiveByDefault", EmitDefaultValue=false)]
		public BooleanValue ActiveByDefault { get; set; }

		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue BoxID { get; set; }

		[DataMember(Name="BoxWeight", EmitDefaultValue=false)]
		public DecimalValue BoxWeight { get; set; }

		[DataMember(Name="CarriersPackage", EmitDefaultValue=false)]
		public StringValue CarriersPackage { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Height", EmitDefaultValue=false)]
		public IntValue Height { get; set; }

		[DataMember(Name="Length", EmitDefaultValue=false)]
		public IntValue Length { get; set; }

		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue MaxVolume { get; set; }

		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue MaxWeight { get; set; }

		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue VolumeUOM { get; set; }

		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue WeightUOM { get; set; }

		[DataMember(Name="Width", EmitDefaultValue=false)]
		public IntValue Width { get; set; }

	}
}