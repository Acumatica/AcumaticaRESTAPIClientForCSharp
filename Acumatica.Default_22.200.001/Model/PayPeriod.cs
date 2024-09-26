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
	/// Corresponds to the screen PR201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NumberofPeriods", EmitDefaultValue=false)]
		public ShortValue? NumberofPeriods { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideFinPeriods 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="PaymentPeriods", EmitDefaultValue=false)]
		public List<PaymentPeriod>? PaymentPeriods { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Year 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Year", EmitDefaultValue=false)]
		public StringValue? Year { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}