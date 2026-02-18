using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ChangeProjectID : EntityActionWithParameters<Project, ChangeProjectIDParameters>
	{
		public ChangeProjectID(Project entity, ChangeProjectIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? ProjectID
		{
			get { return Parameters.ProjectID; }
			set { Parameters.ProjectID = value; }
		}
	}
}