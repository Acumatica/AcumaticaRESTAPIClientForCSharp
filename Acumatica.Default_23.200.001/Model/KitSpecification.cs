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
	/// Corresponds to the screen IN209500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class KitSpecification : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsNonStock 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsNonStock", EmitDefaultValue=false)]
		public BooleanValue? IsNonStock { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: KitInventoryID 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
		public StringValue? KitInventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
		public List<KitNonStockComponent>? NonStockComponents { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.IN.INKitSpecHdr 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisionID", EmitDefaultValue=false)]
		public StringValue? RevisionID { get; set; }

		[DataMember(Name="StockComponents", EmitDefaultValue=false)]
		public List<KitStockComponent>? StockComponents { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}