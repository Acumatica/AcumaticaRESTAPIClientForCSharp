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
	/// Corresponds to the screen IN302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryIssue : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Control Amount 
		/// </summary>
		[DataMember(Name="ControlAmount", EmitDefaultValue=false)]
		public DecimalValue? ControlAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Control Qty. 
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.IN.INRegister 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.IN.INRegister 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<InventoryIssueDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: External Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Total Amount 
		/// </summary>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Total Qty. 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}