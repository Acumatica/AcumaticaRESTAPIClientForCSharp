using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class MarkLeadAsValidated : EntityAction<Lead>
	{
		public MarkLeadAsValidated(Lead entity) : base(entity)
		{ }
		public MarkLeadAsValidated() : base()
		{ }
	}
}
