using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

namespace SOAPLikeWrapperForREST
{
    public class SOAPLikeEntityAPI<T> : EntityAPI<T>
        where T : Entity
    {
        public SOAPLikeEntityAPI(Configuration configuration) : base(configuration)
        { }
    }
}
