using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM209900 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LaborCostRate : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EffectiveDate 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<LaborRate>? Results { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}