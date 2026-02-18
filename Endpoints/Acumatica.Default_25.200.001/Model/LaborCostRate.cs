using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209900</c> in the Acumatica ERP
	/// </summary>
	public class LaborCostRate : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? Employee { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? LaborRateType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.LaborCostRateMaint+PMLaborCostRateFilter</para>
		/// </summary>
		public StringValue? UnionLocal { get; set; }

		public List<LaborRate>? Results { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}