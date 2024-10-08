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
	public class RecalculatePricesDiscounts : EntityActionWithParameters<SalesOrder, RecalculatePricesDiscountsParameters>
	{
		public RecalculatePricesDiscounts(SalesOrder entity, RecalculatePricesDiscountsParameters parameters) : base(entity, parameters)
		{ }

		public BooleanValue? OverrideManualDiscounts
		{
			get { return Parameters.OverrideManualDiscounts; }
			set { Parameters.OverrideManualDiscounts = value; }
		}
		public BooleanValue? OverrideManualDocGroupDiscounts
		{
			get { return Parameters.OverrideManualDocGroupDiscounts; }
			set { Parameters.OverrideManualDocGroupDiscounts = value; }
		}
		public BooleanValue? OverrideManualPrices
		{
			get { return Parameters.OverrideManualPrices; }
			set { Parameters.OverrideManualPrices = value; }
		}
		public BooleanValue? RecalcDiscounts
		{
			get { return Parameters.RecalcDiscounts; }
			set { Parameters.RecalcDiscounts = value; }
		}
		public BooleanValue? RecalcUnitPrices
		{
			get { return Parameters.RecalcUnitPrices; }
			set { Parameters.RecalcUnitPrices = value; }
		}
	}
}