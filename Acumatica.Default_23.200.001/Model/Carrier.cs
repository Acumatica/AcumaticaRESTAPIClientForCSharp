using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207700 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Carrier : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CarrierPluginID 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnitType 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarrierUnits", EmitDefaultValue=false)]
		public StringValue? CarrierUnits { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerAccounts", EmitDefaultValue=false)]
		public List<CarrierCustomerAccount>? CustomerAccounts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PlugInParameters", EmitDefaultValue=false)]
		public List<CarrierPluginParameter>? PlugInParameters { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PluginTypeName 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PlugInType", EmitDefaultValue=false)]
		public StringValue? PlugInType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CentimeterUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Centimeter", EmitDefaultValue=false)]
		public StringValue? Centimeter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InchUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Inch", EmitDefaultValue=false)]
		public StringValue? Inch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: KilogramUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Kilogram", EmitDefaultValue=false)]
		public StringValue? Kilogram { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PoundUOM 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Pound", EmitDefaultValue=false)]
		public StringValue? Pound { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.CS.CarrierPlugin 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}