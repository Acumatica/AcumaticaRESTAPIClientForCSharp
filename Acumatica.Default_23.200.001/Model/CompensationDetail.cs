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
	public class CompensationDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: TypeCD 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EarningCode", EmitDefaultValue=false)]
		public StringValue? EarningCode { get; set; }

		/// <summary>
		/// DAC Field Name: TypeCD_Description 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// </summary>
		[DataMember(Name="EarningDescription", EmitDefaultValue=false)]
		public StringValue? EarningDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public StringValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: Pay Rate 
		/// </summary>
		[DataMember(Name="PayRate", EmitDefaultValue=false)]
		public DecimalValue? PayRate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC Field Name: UnitType 
		/// DAC: PX.Objects.PR.PREmployeeEarning 
		/// Display Name: Unit of Pay 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="UnitOfPay", EmitDefaultValue=false)]
		public StringValue? UnitOfPay { get; set; }

	}
}