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
	/// Corresponds to the screen AR303010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerPaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Indicates (if set to true) that the customerpayment method is available for recording payments.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the payment method.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Card/Account Nbr. 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public StringValue? CardAccountNbr { get; set; }

		/// <summary>
		/// The identifier of the cash accountassociated with the customer payment method.
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of customer towhich the payment method belongs. This field is a partof the compound key of the record.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Customer 
		/// Key Field
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The identifier of the customer profile associated with the customeraccount in Acumatica ERP and Authorize.Net. The main purpose ofthe identifier is to link multiple bank cards to a single customerentity and to synchronize record details between systems.
		/// DAC Field Name: CustomerCCPID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Customer Profile ID 
		/// SQL Type: nvarchar(1024) 
		/// </summary>
		[DataMember(Name="CustomerProfileID", EmitDefaultValue=false)]
		public StringValue? CustomerProfileID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CustomerPaymentMethodDetail>? Details { get; set; }

		/// <summary>
		/// The unique identifier of the customer payment method.This field is part of the compound key of the record.
		/// DAC Field Name: PMInstanceID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Card Number 
		/// Key Field
		/// </summary>
		[DataMember(Name="InstanceID", EmitDefaultValue=false)]
		public IntValue? InstanceID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the payment methodassociated with the customer payment method. The settings of this paymentmethod are used as a template for the customer payment method.
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// The identifier of the credit card processing center.
		/// DAC Field Name: CCProcessingCenterID 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Proc. Center ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
		public StringValue? ProcCenterID { get; set; }

		/// <summary>
		/// Specifies display card type value.This is a virtual field and it has no representation in the database.
		/// DAC Field Name: DisplayCardType 
		/// DAC: PX.Objects.AR.CustomerPaymentMethod 
		/// Display Name: Card/Account Type 
		/// SQL Type: nchar(20) 
		/// </summary>
		[DataMember(Name="CardType", EmitDefaultValue=false)]
		public StringValue? CardType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}