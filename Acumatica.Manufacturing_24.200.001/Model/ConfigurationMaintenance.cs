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
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: BOM Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// DAC Field Name: IsCompletionRequired 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Completion Required Before Production 
		/// </summary>
		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		[DataMember(Name="ConfigAttributes", EmitDefaultValue=false)]
		public List<ConfigurationMaintAttribute>? ConfigAttributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Configuration ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationMaintenanceFeature>? Features { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Keys", EmitDefaultValue=false)]
		public ConfigurationMaintKey? Keys { get; set; }

		[DataMember(Name="Price", EmitDefaultValue=false)]
		public ConfigurationMaintPrice? Price { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfiguration 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}