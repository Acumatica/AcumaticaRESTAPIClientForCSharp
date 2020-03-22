using Acumatica.RESTClient.Model;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class SalesOrderAddInvoiceParameters
	{
		public SalesOrderAddInvoiceParameters() { }

		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}