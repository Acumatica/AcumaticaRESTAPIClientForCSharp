using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateReceipt : EntityAction<SalesOrder>
	{
		public SalesOrderCreateReceipt(SalesOrder entity) : base(entity)
		{ }
		public SalesOrderCreateReceipt() : base()
		{ }
	}
}
