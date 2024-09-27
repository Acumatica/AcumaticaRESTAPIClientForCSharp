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
	public class EmploymentDates : Entity
	{

		/// <summary>
		/// Hire date.
		/// DAC: PX.Objects.PR.EmploymentHistory 
		/// Display Name: Hire Date 
		/// </summary>
		[DataMember(Name="HireDate", EmitDefaultValue=false)]
		public DateTimeValue? HireDate { get; set; }

		/// <summary>
		/// Termination date.
		/// DAC: PX.Objects.PR.EmploymentHistory 
		/// Display Name: Termination Date 
		/// </summary>
		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue? TerminationDate { get; set; }

	}
}