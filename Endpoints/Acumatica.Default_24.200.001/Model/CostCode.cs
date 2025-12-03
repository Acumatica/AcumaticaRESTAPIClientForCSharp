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
	/// Corresponds to the screen <c>PM209500</c> in the Acumatica ERP
	/// <para>Key Fields: CostCodeID</para>
	/// </summary>
	[DataContract]
	public class CostCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Get or sets unique identifier.This is a segmented key and format is configured under segmented key maintenance screen in CS module.
		/// <para>DAC Field Name: CostCodeCD</para>
		/// <para>DAC: PX.Objects.PM.PMCostCode</para>
		/// <para>Display Name: Cost Code</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CostCodeID", EmitDefaultValue=false)]
		public StringValue? CostCodeID { get; set; }

		/// <summary>
		/// Gets or sets description
		/// <para>DAC: PX.Objects.PM.PMCostCode</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}