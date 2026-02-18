using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CompensationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EarningCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD_Description</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		public StringValue? EarningDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		public StringValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Pay Rate</para>
		/// </summary>
		public DecimalValue? PayRate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Unit of Pay</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? UnitOfPay { get; set; }

	}
}