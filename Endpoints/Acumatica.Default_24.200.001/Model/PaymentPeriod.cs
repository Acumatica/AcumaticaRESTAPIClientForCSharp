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
	public class PaymentPeriod : Entity
	{

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: EndDateUI 
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// Display Name: Financial Year 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="FinYear", EmitDefaultValue=false)]
		public StringValue? FinYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// Display Name: Pay Period ID 
		/// SQL Type: char(6) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PayPeriodID", EmitDefaultValue=false)]
		public StringValue? PayPeriodID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// Display Name: Period Nbr. 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue? PeriodNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupPeriod 
		/// Display Name: Transaction Date 
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

	}
}