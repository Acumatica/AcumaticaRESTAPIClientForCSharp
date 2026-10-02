using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class MaterialListTotals : Entity
	{

		#region Fields
		public DecimalValue? EstimatedTotalCost { get; set; }

		public DecimalValue? EstimatedVariance { get; set; }

		public GuidValue? NoteID { get; set; }

		public DecimalValue? RequiredQty { get; set; }

		public DecimalValue? TotalBudgetedAmount { get; set; }

		#endregion

	}
}