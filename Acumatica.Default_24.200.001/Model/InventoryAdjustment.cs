using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryAdjustment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<InventoryAdjustmentDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalCost 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalQty 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}