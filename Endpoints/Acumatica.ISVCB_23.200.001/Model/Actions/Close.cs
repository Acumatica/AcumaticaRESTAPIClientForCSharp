using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
	[DataContract]
	public class Close : EntityActionWithParameters<Case, CloseParameters>
	{
		public Close(Case entity, CloseParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? Reason
		{
			get { return Parameters.Reason; }
			set { Parameters.Reason = value; }
		}
	}
}