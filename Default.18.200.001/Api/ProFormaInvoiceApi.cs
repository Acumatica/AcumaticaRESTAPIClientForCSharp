using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class ProFormaInvoiceApi : EntityAPI<ProFormaInvoice>
    {
        public ProFormaInvoiceApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeApproveProFormaInvoiceAction(ProFormaInvoice proFormaInvoice)
        {
            return InvokeAction(new ApproveProFormaInvoice(proFormaInvoice));
        }
    }
}
