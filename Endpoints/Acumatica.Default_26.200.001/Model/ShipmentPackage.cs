using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ShipmentPackage : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Box ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BoxID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PackageType</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		public DecimalValue? Length { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		public DecimalValue? Width { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		public DecimalValue? Height { get; set; }

		/// <summary>
		/// Gross (Brutto) Weight. Weight of a box with contents. (includes weight of the box itself).
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// </summary>
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WeightUOM</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Declared Value</para>
		/// </summary>
		public DecimalValue? DeclaredValue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COD</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: C.O.D. Amount</para>
		/// </summary>
		public DecimalValue? CODAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TrackNumber</para>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Tracking Number</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? TrackingNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Custom Ref. Nbr. 1</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CustomRefNbr1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOPackageDetailEx</para>
		/// <para>Display Name: Custom Ref. Nbr. 2</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? CustomRefNbr2 { get; set; }

		public IntValue? LineNbr { get; set; }

		public GuidValue? NoteID { get; set; }

		#endregion

		#region Details
		public List<ShipmentPackageDetail>? PackageContents { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string PackageContents = "PackageContents";

			//Intentionally excluded
			//public const string All = "Files,PackageContents";
		}
	}
}