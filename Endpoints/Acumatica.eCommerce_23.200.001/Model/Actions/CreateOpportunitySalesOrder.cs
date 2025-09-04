using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class CreateOpportunitySalesOrder : EntityActionWithParameters<Opportunity, CreateOpportunitySalesOrderParameters>
	{
		public CreateOpportunitySalesOrder(Opportunity entity, CreateOpportunitySalesOrderParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? OrderType
		{
			get { return Parameters.OrderType; }
			set { Parameters.OrderType = value; }
		}
		public BooleanValue? RecalculatePricesandDiscounts
		{
			get { return Parameters.RecalculatePricesandDiscounts; }
			set { Parameters.RecalculatePricesandDiscounts = value; }
		}
	}
}