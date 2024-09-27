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
	/// Corresponds to the screen IN209500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class KitSpecification : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// Display Name: Non-Stock 
		/// </summary>
		[DataMember(Name="IsNonStock", EmitDefaultValue=false)]
		public BooleanValue? IsNonStock { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// Display Name: Kit Inventory ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
		public StringValue? KitInventoryID { get; set; }

		[DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
		public List<KitNonStockComponent>? NonStockComponents { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// Display Name: Revision 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionID { get; set; }

		[DataMember(Name="StockComponents", EmitDefaultValue=false)]
		public List<KitStockComponent>? StockComponents { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}