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
	public class FinancialYearPeriodDetail : Entity
	{

		/// <summary>
		/// The description of the period.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.GL.FinPeriodSetup 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The field used to display and edit the EndDate of the period (inclusive) in the UI.
		/// DAC Field Name: EndDateUI 
		/// DAC: PX.Objects.GL.FinPeriodSetup 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// The number of the period in a year.
		/// DAC: PX.Objects.GL.FinPeriodSetup 
		/// Display Name: Period Nbr. 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue? PeriodNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

	}
}