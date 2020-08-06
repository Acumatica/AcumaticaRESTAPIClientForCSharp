using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ApproveProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public ApproveProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
		public ApproveProFormaInvoice() : base()
		{ }
	}
}
