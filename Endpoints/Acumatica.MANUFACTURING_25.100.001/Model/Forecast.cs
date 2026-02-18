using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM202000</c> in the Acumatica ERP
	/// <para>Key Fields: ForecastID</para>
	/// </summary>
	public class Forecast : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>Display Name: Begin Date</para>
		/// </summary>
		public DateTimeValue? BeginDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID_description</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public BooleanValue? Dependent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_description</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>Display Name: Forecast ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ForecastID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Interval { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMForecast</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}