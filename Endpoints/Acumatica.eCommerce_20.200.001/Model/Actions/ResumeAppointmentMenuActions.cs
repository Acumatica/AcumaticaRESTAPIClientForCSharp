using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ResumeAppointmentMenuActions : EntityAction<Appointment>
	{
		public ResumeAppointmentMenuActions(Appointment entity) : base(entity)
		{ }
	}
}
