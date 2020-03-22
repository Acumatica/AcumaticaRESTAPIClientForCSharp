using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ReverseInvoice : EntityAction<Invoice>
	{
		public ReverseInvoice(Invoice entity) : base(entity)
		{ }
		public ReverseInvoice() : base()
		{ }
	}
}
