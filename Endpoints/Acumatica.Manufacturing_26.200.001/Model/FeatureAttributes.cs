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
	public class FeatureAttributes : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Value</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Default Value</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="DefaultValue", EmitDefaultValue=false)]
		public StringValue? DefaultValue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FeatureID", EmitDefaultValue=false)]
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Is Formula</para>
		/// </summary>
		[DataMember(Name="IsFormula", EmitDefaultValue=false)]
		public BooleanValue? IsFormula { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Variable", EmitDefaultValue=false)]
		public StringValue? Variable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		[DataMember(Name="Visible", EmitDefaultValue=false)]
		public BooleanValue? Visible { get; set; }

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