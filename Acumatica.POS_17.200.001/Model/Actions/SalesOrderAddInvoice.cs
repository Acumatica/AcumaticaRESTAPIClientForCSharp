using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesOrderAddInvoice : EntityActionWithParameters<SalesOrder, SalesOrderAddInvoiceParameters>
	{
		public SalesOrderAddInvoice() : base()
		{ }
		public SalesOrderAddInvoice(SalesOrder entity, SalesOrderAddInvoiceParameters parameters) : base(entity, parameters)
		{ }

		public StringValue DocumentType
		{
			get { return Parameters.DocumentType; }
			set { Parameters.DocumentType = value; }
		}
		public StringValue ReferenceNbr
		{
			get { return Parameters.ReferenceNbr; }
			set { Parameters.ReferenceNbr = value; }
		}
	}
}