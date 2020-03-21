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
        
        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns></returns>
        public string InvokeAction(T entity, EntityAction<T> action)
        {
            action.Entity = entity;
            var result = InvokeActionWithHttpInfo(action);
            return result.Headers["Location"];
        }
    }
}
