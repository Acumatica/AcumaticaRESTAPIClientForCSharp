using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UpdateDiscounts : EntityActionWithParameters<Discount, UpdateDiscountsParameters>
	{
		public UpdateDiscounts(Discount entity, UpdateDiscountsParameters parameters) : base(entity, parameters)
		{ }

		public DateTimeValue? Date
		{
			get { return Parameters.Date; }
			set { Parameters.Date = value; }
		}
	}
}