using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	[DataContract]
	public class GetReportPath : EntityActionWithParameters<PrintJobs, GetReportPathParameters>
	{
		public GetReportPath(PrintJobs entity, GetReportPathParameters parameters) : base(entity, parameters)
		{ }

		public IntValue? JobID
		{
			get { return Parameters.JobID; }
			set { Parameters.JobID = value; }
		}
	}
}