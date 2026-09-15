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
	public class UnlinkFile : EntityActionWithParameters<UploadedFiles, UnlinkFileParameters>
	{
		public UnlinkFile(UploadedFiles entity, UnlinkFileParameters parameters) : base(entity, parameters)
		{ }

		public GuidValue? Document
		{
			get { return Parameters.Document; }
			set { Parameters.Document = value; }
		}
		public StringValue? DocumentNumber
		{
			get { return Parameters.DocumentNumber; }
			set { Parameters.DocumentNumber = value; }
		}
		public GuidValue? FileID
		{
			get { return Parameters.FileID; }
			set { Parameters.FileID = value; }
		}
		public StringValue? ProjectID
		{
			get { return Parameters.ProjectID; }
			set { Parameters.ProjectID = value; }
		}
		public StringSingleSelectValue? RecordType
		{
			get { return Parameters.RecordType; }
			set { Parameters.RecordType = value; }
		}
	}
}