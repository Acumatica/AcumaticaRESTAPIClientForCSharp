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
	/// Corresponds to the screen AP302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Check : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CheckDetail>? Details { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public List<CheckHistoryDetail>? History { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AP.APPayment 
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
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryUnappliedBal 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnappliedBalance", EmitDefaultValue=false)]
		public DecimalValue? UnappliedBalance { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}