using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN305000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	public class PhysicalInventoryReview : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: PIID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountDate</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Freeze Date</para>
		/// </summary>
		public DateTimeValue? FreezeDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Physical Qty.</para>
		/// </summary>
		public DecimalValue? TotalPhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Qty.</para>
		/// </summary>
		public DecimalValue? TotalVarianceQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Cost</para>
		/// </summary>
		public DecimalValue? TotalVarianceCost { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public StringValue? TypeID { get; set; }

		#endregion

		#region Details
		public List<PhysicalInventoryReviewDetail>? Details { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(PhysicalInventoryReview)} - \"{ReferenceNbr}\"";
		}

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
			public const string Translations = "Translations";
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}