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
	/// Corresponds to the screen GL201100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CompanyFinancialPeriod : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrganizationID 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Company", EmitDefaultValue=false)]
		public StringValue? Company { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialPeriodDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Year 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NbrOfPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfPeriods { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.GL.FinPeriods.OrganizationFinYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}