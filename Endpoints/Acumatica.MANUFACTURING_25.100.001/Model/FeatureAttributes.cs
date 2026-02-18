using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class FeatureAttributes : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Value</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Default Value</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? DefaultValue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>Display Name: Is Formula</para>
		/// </summary>
		public BooleanValue? IsFormula { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Variable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureAttribute</para>
		/// </summary>
		public BooleanValue? Visible { get; set; }

	}
}