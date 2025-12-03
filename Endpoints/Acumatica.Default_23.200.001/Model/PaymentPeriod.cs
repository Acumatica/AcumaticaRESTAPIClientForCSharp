using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class PaymentPeriod : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDateUI</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Financial Year</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="FinYear", EmitDefaultValue=false)]
		public StringValue? FinYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Pay Period ID</para>
		/// <para>SQL Type: char(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PayPeriodID", EmitDefaultValue=false)]
		public StringValue? PayPeriodID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Period Nbr.</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue? PeriodNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupPeriod</para>
		/// <para>Display Name: Transaction Date</para>
		/// </summary>
		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue? TransactionDate { get; set; }

	}
}