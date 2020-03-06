using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    
    public class SOAPLikeEntityAPI<T> : EntityAPI<T>
        where T : Entity
    {
        public SOAPLikeEntityAPI(Configuration configuration) : base(configuration)
        { }
    }
}
