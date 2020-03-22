using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesOrderAddStockItem : EntityActionWithParameters<SalesOrder, SalesOrderAddStockItemParameters>
	{
		public SalesOrderAddStockItem() : base()
		{ }
		public SalesOrderAddStockItem(SalesOrder entity, SalesOrderAddStockItemParameters parameters) : base(entity, parameters)
		{ }
	}
}