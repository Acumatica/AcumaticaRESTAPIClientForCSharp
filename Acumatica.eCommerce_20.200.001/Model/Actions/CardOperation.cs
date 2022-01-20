using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class CardOperation : EntityActionWithParameters<Payment, CardOperationParameters>
	{
		public CardOperation() : base()
		{ }
		public CardOperation(Payment entity, CardOperationParameters parameters) : base(entity, parameters)
		{ }

		public StringValue TranType
		{
			get { return Parameters.TranType; }
			set { Parameters.TranType = value; }
		}
		public StringValue TranNbr
		{
			get { return Parameters.TranNbr; }
			set { Parameters.TranNbr = value; }
		}
		public StringValue AuthNumber
		{
			get { return Parameters.AuthNumber; }
			set { Parameters.AuthNumber = value; }
		}
		public StringValue ExtProfileId
		{
			get { return Parameters.ExtProfileId; }
			set { Parameters.ExtProfileId = value; }
		}
		public DateTimeValue TranDate
		{
			get { return Parameters.TranDate; }
			set { Parameters.TranDate = value; }
		}
		public StringValue OrigTranNbr
		{
			get { return Parameters.OrigTranNbr; }
			set { Parameters.OrigTranNbr = value; }
		}
		public DecimalValue Amount
		{
			get { return Parameters.Amount; }
			set { Parameters.Amount = value; }
		}
	}
}