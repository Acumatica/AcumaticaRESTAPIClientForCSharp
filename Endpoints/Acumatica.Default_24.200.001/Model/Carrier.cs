using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS207700</c> in the Acumatica ERP
	/// <para>Key Fields: CarrierID</para>
	/// </summary>
	public class Carrier : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: CarrierPluginID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Carrier ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitType</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Carrier Units</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CarrierUnits { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public List<CarrierCustomerAccount>? CustomerAccounts { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public List<CarrierPluginParameter>? PlugInParameters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PluginTypeName</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Plug-In</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? PlugInType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CentimeterUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? Centimeter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InchUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? Inch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KilogramUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? Kilogram { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PoundUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? Pound { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string CustomerAccounts = "CustomerAccounts";
			public const string CustomerAccounts_Files = "CustomerAccounts/Files";
			public const string PlugInParameters = "PlugInParameters";
			public const string PlugInParameters_Files = "PlugInParameters/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,CustomerAccounts,CustomerAccounts/Files,PlugInParameters,PlugInParameters/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}