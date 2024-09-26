using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM207500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfigurationMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsCompletionRequired 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		[DataMember(Name="ConfigAttributes", EmitDefaultValue=false)]
		public List<ConfigurationMaintAttribute>? ConfigAttributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigurationID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationMaintenanceFeature>? Features { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Keys", EmitDefaultValue=false)]
		public ConfigurationMaintKey? Keys { get; set; }

		[DataMember(Name="Price", EmitDefaultValue=false)]
		public ConfigurationMaintPrice? Price { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Revision 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}