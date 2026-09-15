using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class CompensationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="EarningCode", EmitDefaultValue=false)]
		public StringValue? EarningCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD_Description</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// </summary>
		[DataMember(Name="EarningDescription", EmitDefaultValue=false)]
		public StringValue? EarningDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Pay Rate</para>
		/// </summary>
		[DataMember(Name="PayRate", EmitDefaultValue=false)]
		public DecimalValue? PayRate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeEarning</para>
		/// <para>Display Name: Unit of Pay</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="UnitOfPay", EmitDefaultValue=false)]
		public StringValue? UnitOfPay { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}