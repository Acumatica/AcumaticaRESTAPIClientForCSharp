using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class PaymentLoadDocuments : EntityActionWithParameters<Payment, PaymentLoadDocumentsParameters>
	{
		public PaymentLoadDocuments() : base()
		{ }
		public PaymentLoadDocuments(Payment entity, PaymentLoadDocumentsParameters parameters) : base(entity, parameters)
		{ }

		public StringValue EndRefNbr
		{
			get { return Parameters.EndRefNbr; }
			set { Parameters.EndRefNbr = value; }
		}
		public DateTimeValue FromDate
		{
			get { return Parameters.FromDate; }
			set { Parameters.FromDate = value; }
		}
		public StringValue LoadChildDocuments
		{
			get { return Parameters.LoadChildDocuments; }
			set { Parameters.LoadChildDocuments = value; }
		}
		public IntValue MaxDocs
		{
			get { return Parameters.MaxDocs; }
			set { Parameters.MaxDocs = value; }
		}
		public StringValue OrderBy
		{
			get { return Parameters.OrderBy; }
			set { Parameters.OrderBy = value; }
		}
		public StringValue StartRefNbr
		{
			get { return Parameters.StartRefNbr; }
			set { Parameters.StartRefNbr = value; }
		}
		public DateTimeValue TillDate
		{
			get { return Parameters.TillDate; }
			set { Parameters.TillDate = value; }
		}
	}
}