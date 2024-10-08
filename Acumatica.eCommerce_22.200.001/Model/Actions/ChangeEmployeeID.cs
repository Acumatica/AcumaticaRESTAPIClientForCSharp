using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ChangeEmployeeID : EntityActionWithParameters<Employee, ChangeEmployeeIDParameters>
	{
		public ChangeEmployeeID(Employee entity, ChangeEmployeeIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? EmployeeID
		{
			get { return Parameters.EmployeeID; }
			set { Parameters.EmployeeID = value; }
		}
	}
}