using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR303010</c> in the Acumatica ERP
	/// <para>Key Fields: CustomerID, InstanceID</para>
	/// </summary>
	public class CustomerPaymentMethod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Indicates (if set to true) that the customerpayment method is available for recording payments.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the payment method.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Card/Account Nbr.</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CardAccountNbr { get; set; }

		/// <summary>
		/// The identifier of the cash accountassociated with the customer payment method.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of customer towhich the payment method belongs. This field is a partof the compound key of the record.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Customer</para>
		/// Key Field
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The identifier of the customer profile associated with the customeraccount in Acumatica ERP and Authorize.Net. The main purpose ofthe identifier is to link multiple bank cards to a single customerentity and to synchronize record details between systems.
		/// <para>DAC Field Name: CustomerCCPID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Customer Profile ID</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? CustomerProfileID { get; set; }

		public List<CustomerPaymentMethodDetail>? Details { get; set; }

		/// <summary>
		/// The unique identifier of the customer payment method.This field is part of the compound key of the record.
		/// <para>DAC Field Name: PMInstanceID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Card Number</para>
		/// Key Field
		/// </summary>
		public IntValue? InstanceID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the payment methodassociated with the customer payment method. The settings of this paymentmethod are used as a template for the customer payment method.
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// The identifier of the credit card processing center.
		/// <para>DAC Field Name: CCProcessingCenterID</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Proc. Center ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ProcCenterID { get; set; }

		/// <summary>
		/// Specifies display card type value.This is a virtual field and it has no representation in the database.
		/// <para>DAC Field Name: DisplayCardType</para>
		/// <para>DAC: PX.Objects.AR.CustomerPaymentMethod</para>
		/// <para>Display Name: Card/Account Type</para>
		/// <para>SQL Type: nchar(20)</para>
		/// </summary>
		public StringValue? CardType { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}