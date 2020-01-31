using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class EmailApi : EntityAPI<Email>
    {
        public EmailApi() : base()
        {
        }
        public EmailApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeArchiveEmailAction(Email email)
        {
            return InvokeAction(new ArchiveEmail(email));
        }
    }
}
