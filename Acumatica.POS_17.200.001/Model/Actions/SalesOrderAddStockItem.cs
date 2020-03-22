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

		public StringValue BarCode
		{
			get { return Parameters.BarCode; }
			set { Parameters.BarCode = value; }
		}
		public StringValue Inventory
		{
			get { return Parameters.Inventory; }
			set { Parameters.Inventory = value; }
		}
		public StringValue WarehouseID
		{
			get { return Parameters.WarehouseID; }
			set { Parameters.WarehouseID = value; }
		}
	}
}