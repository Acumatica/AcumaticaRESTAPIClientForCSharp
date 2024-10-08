using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207700 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Carrier : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: CarrierPluginID 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// Display Name: Carrier ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// DAC Field Name: UnitType 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// Display Name: Carrier Units 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CarrierUnits", EmitDefaultValue=false)]
		public StringValue? CarrierUnits { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
		public List<CarrierCustomerAccount>? CustomerAccounts { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
		public List<CarrierPluginParameter>? PlugInParameters { get; set; }

		/// <summary>
		/// DAC Field Name: PluginTypeName 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// Display Name: Plug-In 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="PlugInType", EmitDefaultValue=false)]
		public StringValue? PlugInType { get; set; }

		/// <summary>
		/// DAC Field Name: CentimeterUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="Centimeter", EmitDefaultValue=false)]
		public StringValue? Centimeter { get; set; }

		/// <summary>
		/// DAC Field Name: InchUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="Inch", EmitDefaultValue=false)]
		public StringValue? Inch { get; set; }

		/// <summary>
		/// DAC Field Name: KilogramUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="Kilogram", EmitDefaultValue=false)]
		public StringValue? Kilogram { get; set; }

		/// <summary>
		/// DAC Field Name: PoundUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="Pound", EmitDefaultValue=false)]
		public StringValue? Pound { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}