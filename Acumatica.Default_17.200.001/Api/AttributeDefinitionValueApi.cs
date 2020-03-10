using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_17_200_001.Model;

namespace Acumatica.Default_17_200_001.Api
{
	public partial class AttributeDefinitionValueApi : EntityAPI<AttributeDefinitionValue>
	{
		public AttributeDefinitionValueApi(Configuration configuration) : base(configuration)
		{ }
	}
}