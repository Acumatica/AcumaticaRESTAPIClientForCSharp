using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS207700</c> in the Acumatica ERP
	/// <para>Key Fields: CarrierID</para>
	/// </summary>
	[DataContract]
	public class Carrier : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: CarrierPluginID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Carrier ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitType</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Carrier Units</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CarrierUnits", EmitDefaultValue=false)]
		public StringValue? CarrierUnits { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
		public List<CarrierCustomerAccount>? CustomerAccounts { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
		public List<CarrierPluginParameter>? PlugInParameters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PluginTypeName</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Plug-In</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		[DataMember(Name="PlugInType", EmitDefaultValue=false)]
		public StringValue? PlugInType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CentimeterUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="Centimeter", EmitDefaultValue=false)]
		public StringValue? Centimeter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InchUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="Inch", EmitDefaultValue=false)]
		public StringValue? Inch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KilogramUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="Kilogram", EmitDefaultValue=false)]
		public StringValue? Kilogram { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PoundUOM</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="Pound", EmitDefaultValue=false)]
		public StringValue? Pound { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPlugin</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

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
			public const string CustomerAccounts = "CustomerAccounts";
			public const string PlugInParameters = "PlugInParameters";

			//Intentionally excluded
			//public const string All = "Files,Translations,CustomerAccounts,PlugInParameters";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}