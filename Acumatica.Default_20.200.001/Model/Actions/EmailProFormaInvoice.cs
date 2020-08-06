using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EmailProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public EmailProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
		public EmailProFormaInvoice() : base()
		{ }
	}
}
