using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadOrders : EntityActionWithParameters<Payment, PaymentLoadOrdersParameters>
	{
		public PaymentLoadOrders() : base()
		{ }
		public PaymentLoadOrders(Payment entity, PaymentLoadOrdersParameters parameters) : base(entity, parameters)
		{ }

		public StringValue EndOrderNbr
		{
			get { return Parameters.EndOrderNbr; }
			set { Parameters.EndOrderNbr = value; }
		}
		public DateTimeValue FromDate
		{
			get { return Parameters.FromDate; }
			set { Parameters.FromDate = value; }
		}
		public IntValue MaxDocs
		{
			get { return Parameters.MaxDocs; }
			set { Parameters.MaxDocs = value; }
		}
		public StringValue SOOrderBy
		{
			get { return Parameters.SOOrderBy; }
			set { Parameters.SOOrderBy = value; }
		}
		public StringValue StartOrderNbr
		{
			get { return Parameters.StartOrderNbr; }
			set { Parameters.StartOrderNbr = value; }
		}
		public DateTimeValue TillDate
		{
			get { return Parameters.TillDate; }
			set { Parameters.TillDate = value; }
		}
	}
}