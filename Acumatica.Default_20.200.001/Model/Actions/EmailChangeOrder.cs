using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EmailChangeOrder : EntityAction<ChangeOrder>
	{
		public EmailChangeOrder(ChangeOrder entity) : base(entity)
		{ }
		public EmailChangeOrder() : base()
		{ }
	}
}
