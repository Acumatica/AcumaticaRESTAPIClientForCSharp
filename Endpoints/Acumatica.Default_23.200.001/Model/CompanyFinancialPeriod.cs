using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen GL201100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CompanyFinancialPeriod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: OrganizationID 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// Key Field
		/// </summary>
		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		/// <summary>
		/// Key field.The financial year.
		/// DAC Field Name: Year 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// Display Name: Financial Year 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// The number of periods in the year.
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// Display Name: Number of Periods 
		/// </summary>
		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		/// <summary>
		/// The start date of the year.
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}