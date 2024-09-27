using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen GL201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class FinancialPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		/// <summary>
		/// Key field.The financial year.
		/// DAC Field Name: Year 
		/// DAC: PX.Objects.GL.FinPeriods.MasterFinYear 
		/// Display Name: Financial Year 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The number of periods in the year.
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.GL.FinPeriods.MasterFinYear 
		/// Display Name: Number of Periods 
		/// </summary>
		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		/// <summary>
		/// The start date of the year.
		/// DAC: PX.Objects.GL.FinPeriods.MasterFinYear 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// Indicates whether the periods of the year can be modified by user.
		/// DAC Field Name: CustomPeriods 
		/// DAC: PX.Objects.GL.FinPeriods.MasterFinYear 
		/// Display Name: User-Defined Periods 
		/// </summary>
		[DataMember(Name="UserDefinedPeriods", EmitDefaultValue=false)]
		public BooleanValue? UserDefinedPeriods { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}