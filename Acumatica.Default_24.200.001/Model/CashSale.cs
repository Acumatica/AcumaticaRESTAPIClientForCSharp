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
	/// Corresponds to the screen AR304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CashSale : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Payment Amount 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.EP.EPApproval 
		/// Display Name: Assignment Date 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CashSaleDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.Standalone.ARCashSale 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}