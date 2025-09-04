using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class ReleaseRetainage : EntityActionWithParameters<Bill, ReleaseRetainageParameters>
	{
		public ReleaseRetainage(Bill entity, ReleaseRetainageParameters parameters) : base(entity, parameters)
		{ }

		public DecimalValue? AmtToRelease
		{
			get { return Parameters.AmtToRelease; }
			set { Parameters.AmtToRelease = value; }
		}
		public DateTimeValue? Date
		{
			get { return Parameters.Date; }
			set { Parameters.Date = value; }
		}
		public StringValue? PostPeriod
		{
			get { return Parameters.PostPeriod; }
			set { Parameters.PostPeriod = value; }
		}
	}
}