using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EarningCodeProjectSettings : Entity
	{

		/// <summary>
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Billable 
		/// </summary>
		[DataMember(Name="BillableProject", EmitDefaultValue=false)]
		public BooleanValue? BillableProject { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Default Project 
		/// </summary>
		[DataMember(Name="DefaultProjectCode", EmitDefaultValue=false)]
		public StringValue? DefaultProjectCode { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Default Project Task 
		/// </summary>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

	}
}