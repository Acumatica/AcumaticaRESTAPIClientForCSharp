using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class VoidCardPayment : EntityActionWithParameters<Payment, VoidCardPaymentParameters>
	{
		public VoidCardPayment(Payment entity, VoidCardPaymentParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? TranType
		{
			get { return Parameters.TranType; }
			set { Parameters.TranType = value; }
		}
		public StringValue? TranNbr
		{
			get { return Parameters.TranNbr; }
			set { Parameters.TranNbr = value; }
		}
		public StringValue? ExtProfileId
		{
			get { return Parameters.ExtProfileId; }
			set { Parameters.ExtProfileId = value; }
		}
		public DateTimeValue? TranDate
		{
			get { return Parameters.TranDate; }
			set { Parameters.TranDate = value; }
		}
		public BooleanValue? NeedValidation
		{
			get { return Parameters.NeedValidation; }
			set { Parameters.NeedValidation = value; }
		}
		public StringValue? OrigTranNbr
		{
			get { return Parameters.OrigTranNbr; }
			set { Parameters.OrigTranNbr = value; }
		}
	}
}