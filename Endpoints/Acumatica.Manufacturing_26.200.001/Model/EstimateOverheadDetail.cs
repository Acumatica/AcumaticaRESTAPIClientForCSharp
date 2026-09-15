using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class EstimateOverheadDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Operation Desc</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OFactor</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// </summary>
		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: Overhead Cost Rate</para>
		/// </summary>
		[DataMember(Name="OverheadCostRate", EmitDefaultValue=false)]
		public DecimalValue? OverheadCostRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// AMOverhead type
		/// <para>DAC Field Name: OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOvhd</para>
		/// <para>Display Name: WC Flag</para>
		/// </summary>
		[DataMember(Name="WCFlag", EmitDefaultValue=false)]
		public BooleanValue? WCFlag { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}