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
	/// Corresponds to the screen PR201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// Display Name: Number of Periods 
		/// </summary>
		[DataMember(Name="NumberofPeriods", EmitDefaultValue=false)]
		public ShortValue? NumberofPeriods { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideFinPeriods 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// Display Name: Pay Group 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="PaymentPeriods", EmitDefaultValue=false)]
		public List<PaymentPeriod>? PaymentPeriods { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRPayGroupYear 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Year", EmitDefaultValue=false)]
		public StringValue? Year { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}