using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class ReleaseSalesInvoice : EntityAction<SalesInvoice>
	{
		public ReleaseSalesInvoice(SalesInvoice entity) : base(entity)
		{ }
		public ReleaseSalesInvoice() : base()
		{ }
	}
}
