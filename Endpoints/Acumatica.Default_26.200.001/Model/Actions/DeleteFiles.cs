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
	public class DeleteFiles : EntityActionWithParameters<UploadedFiles, DeleteFilesParameters>
	{
		public DeleteFiles(UploadedFiles entity, DeleteFilesParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? FileIDs
		{
			get { return Parameters.FileIDs; }
			set { Parameters.FileIDs = value; }
		}
	}
}