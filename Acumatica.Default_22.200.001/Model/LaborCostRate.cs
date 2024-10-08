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
	/// Corresponds to the screen PM209900 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LaborCostRate : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="LaborRateType", EmitDefaultValue=false)]
		public StringValue? LaborRateType { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter 
		/// </summary>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<LaborRate>? Results { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}