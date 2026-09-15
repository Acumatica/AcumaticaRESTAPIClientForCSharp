using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class CheckInFile : EntityActionWithParameters<UploadedFiles, CheckInFileParameters>
	{
		public CheckInFile(UploadedFiles entity, CheckInFileParameters parameters) : base(entity, parameters)
		{ }

		public GuidValue? FileID
		{
			get { return Parameters.FileID; }
			set { Parameters.FileID = value; }
		}
	}
}