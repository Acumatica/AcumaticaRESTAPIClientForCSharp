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
	public class UnionEarningRateDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PM.PMUnion 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Wage Rate 
		/// </summary>
		[DataMember(Name="WageRate", EmitDefaultValue=false)]
		public DecimalValue? WageRate { get; set; }

	}
}