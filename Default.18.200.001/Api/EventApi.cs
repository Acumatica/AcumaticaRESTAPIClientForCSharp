using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class EventApi : EntityAPI<Event>
    {
        public EventApi() : base()
        {
        }
        public EventApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeAcceptInvitationEventAction(Event eventEntity)
        {
            return InvokeAction(new AcceptInvitationEvent(eventEntity));
        }
        public string InvokeCancelActivityEventAction(Event eventEntity)
        {
            return InvokeAction(new CancelActivityEvent(eventEntity));
        }
    }
}
