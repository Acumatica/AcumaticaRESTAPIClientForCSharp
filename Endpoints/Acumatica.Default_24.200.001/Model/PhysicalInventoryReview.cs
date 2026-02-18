using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN305000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	public class PhysicalInventoryReview : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<PhysicalInventoryReviewDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountDate</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Freeze Date</para>
		/// </summary>
		public DateTimeValue? FreezeDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PIID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Physical Qty.</para>
		/// </summary>
		public DecimalValue? TotalPhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Cost</para>
		/// </summary>
		public DecimalValue? TotalVarianceCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Qty.</para>
		/// </summary>
		public DecimalValue? TotalVarianceQty { get; set; }

		public StringValue? TypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}