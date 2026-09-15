using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	[DataContract]
	public class CheckOutFile : EntityActionWithParameters<UploadedFiles, CheckOutFileParameters>
	{
		public CheckOutFile(UploadedFiles entity, CheckOutFileParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? Comment
		{
			get { return Parameters.Comment; }
			set { Parameters.Comment = value; }
		}
		public GuidValue? FileID
		{
			get { return Parameters.FileID; }
			set { Parameters.FileID = value; }
		}
	}
}