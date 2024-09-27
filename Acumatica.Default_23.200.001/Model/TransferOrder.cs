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
	/// Corresponds to the screen IN304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TransferOrder : Entity, ITopLevelEntity
	{

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
		public List<TransferOrderDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: External Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Warehouse ID 
		/// </summary>
		[DataMember(Name="FromWarehouseID", EmitDefaultValue=false)]
		public StringValue? FromWarehouseID { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

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
		/// Display Name: Total Qty. 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// DAC Field Name: ToSiteID 
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: To Warehouse ID 
		/// </summary>
		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INRegister 
		/// Display Name: Transfer Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TransferType", EmitDefaultValue=false)]
		public StringValue? TransferType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}