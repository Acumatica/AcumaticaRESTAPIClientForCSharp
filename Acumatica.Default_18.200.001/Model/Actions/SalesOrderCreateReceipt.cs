using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateReceipt : EntityActionWithParameters<SalesOrder, SalesOrderCreateReceiptParameters>
	{
		public SalesOrderCreateReceipt() : base()
		{ }
		public SalesOrderCreateReceipt(SalesOrder entity, SalesOrderCreateReceiptParameters parameters) : base(entity, parameters)
		{ }
	}
}