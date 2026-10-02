using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	public class GetReportPath : EntityActionWithParameters<PrintJobs, GetReportPathParameters>
	{
		public GetReportPath(PrintJobs entity, GetReportPathParameters parameters) : base(entity, parameters)
		{ }
	}
}