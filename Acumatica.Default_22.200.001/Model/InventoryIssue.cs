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
	/// Corresponds to the screen IN302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryIssue : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlAmount 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlAmount", EmitDefaultValue=false)]
		public DecimalValue? ControlAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlQty 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

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
		public List<InventoryIssueDetail>? Details { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

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
		/// DAC Field Name: TotalAmount 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

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
			return "entity/Default/22.200.001";
		}
	}
}