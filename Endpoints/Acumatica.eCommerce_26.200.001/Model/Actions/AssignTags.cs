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
	public class AssignTags : EntityActionWithParameters<UploadedFiles, AssignTagsParameters>
	{
		public AssignTags(UploadedFiles entity, AssignTagsParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? FileIDs
		{
			get { return Parameters.FileIDs; }
			set { Parameters.FileIDs = value; }
		}
		public StringValue? Tags
		{
			get { return Parameters.Tags; }
			set { Parameters.Tags = value; }
		}
	}
}