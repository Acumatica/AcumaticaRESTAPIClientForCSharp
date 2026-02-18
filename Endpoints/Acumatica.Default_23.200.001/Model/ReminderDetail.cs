using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ReminderDetail : Entity
	{

		public BooleanValue? IsActive { get; set; }

		public DateTimeValue? RemindAtDate { get; set; }

		public DateTimeValue? RemindAtTime { get; set; }

	}
}