using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class RegisterAuthTran : EntityActionWithParameters<Payment, RegisterAuthTranParameters>
	{
		public RegisterAuthTran() : base()
		{ }
		public RegisterAuthTran(Payment entity, RegisterAuthTranParameters parameters) : base(entity, parameters)
		{ }

		public StringValue PaymentGatewayCreateProfile
		{
			get { return Parameters.PaymentGatewayCreateProfile; }
			set { Parameters.PaymentGatewayCreateProfile = value; }
		}
		public StringValue PaymentGatewayTranID
		{
			get { return Parameters.PaymentGatewayTranID; }
			set { Parameters.PaymentGatewayTranID = value; }
		}
	}
}