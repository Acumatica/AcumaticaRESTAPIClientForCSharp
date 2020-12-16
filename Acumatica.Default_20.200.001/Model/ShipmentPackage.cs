using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipmentPackage : Entity_v4
	{

		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue BoxID { get; set; }

		[DataMember(Name="CODAmount", EmitDefaultValue=false)]
		public DecimalValue CODAmount { get; set; }

		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue Confirmed { get; set; }

		[DataMember(Name="CustomRefNbr1", EmitDefaultValue=false)]
		public StringValue CustomRefNbr1 { get; set; }

		[DataMember(Name="CustomRefNbr2", EmitDefaultValue=false)]
		public StringValue CustomRefNbr2 { get; set; }

		[DataMember(Name="DeclaredValue", EmitDefaultValue=false)]
		public DecimalValue DeclaredValue { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="TrackingNbr", EmitDefaultValue=false)]
		public StringValue TrackingNbr { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue Weight { get; set; }

		[DataMember(Name="PackageContents", EmitDefaultValue=false)]
		public List<ShipmentPackageDetail> PackageContents { get; set; }

	}
}