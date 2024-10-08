using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ShipmentPackage : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: Box ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// DAC Field Name: COD 
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: C.O.D. Amount 
		/// </summary>
		[DataMember(Name="CODAmount", EmitDefaultValue=false)]
		public DecimalValue? CODAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: Custom Ref. Nbr. 1 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="CustomRefNbr1", EmitDefaultValue=false)]
		public StringValue? CustomRefNbr1 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: Custom Ref. Nbr. 2 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="CustomRefNbr2", EmitDefaultValue=false)]
		public StringValue? CustomRefNbr2 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: Declared Value 
		/// </summary>
		[DataMember(Name="DeclaredValue", EmitDefaultValue=false)]
		public DecimalValue? DeclaredValue { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: TrackNumber 
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// Display Name: Tracking Number 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="TrackingNbr", EmitDefaultValue=false)]
		public StringValue? TrackingNbr { get; set; }

		/// <summary>
		/// DAC Field Name: PackageType 
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: WeightUOM 
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Gross (Brutto) Weight. Weight of a box with contents. (includes weight of the box itself).
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// </summary>
		[DataMember(Name="Length", EmitDefaultValue=false)]
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// </summary>
		[DataMember(Name="Width", EmitDefaultValue=false)]
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOPackageDetailEx 
		/// </summary>
		[DataMember(Name="Height", EmitDefaultValue=false)]
		public DecimalValue? Height { get; set; }

		[DataMember(Name="PackageContents", EmitDefaultValue=false)]
		public List<ShipmentPackageDetail>? PackageContents { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

	}
}