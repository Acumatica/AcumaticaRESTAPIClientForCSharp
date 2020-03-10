using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class AttributeDefinitionValueApi : EntityAPI<AttributeDefinitionValue>
	{
		public AttributeDefinitionValueApi(Configuration configuration) : base(configuration)
		{ }
	}
}