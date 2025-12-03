using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ShipmentPackage : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COD</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: C.O.D. Amount</para>
		/// </summary>
		[DataMember(Name="CODAmount", EmitDefaultValue=false)]
		public DecimalValue? CODAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Custom Ref. Nbr. 1</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="CustomRefNbr1", EmitDefaultValue=false)]
		public StringValue? CustomRefNbr1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Custom Ref. Nbr. 2</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="CustomRefNbr2", EmitDefaultValue=false)]
		public StringValue? CustomRefNbr2 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Declared Value</para>
		/// </summary>
		[DataMember(Name="DeclaredValue", EmitDefaultValue=false)]
		public DecimalValue? DeclaredValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TrackNumber</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Tracking Number</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="TrackingNbr", EmitDefaultValue=false)]
		public StringValue? TrackingNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PackageType</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WeightUOM</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Gross (Brutto) Weight. Weight of a box with contents. (includes weight of the box itself).
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		[DataMember(Name="Length", EmitDefaultValue=false)]
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		[DataMember(Name="Width", EmitDefaultValue=false)]
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
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