using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM206500</c> in the Acumatica ERP
	/// <para>Key Fields: LaborCode</para>
	/// </summary>
	[DataContract]
	public class LaborCodes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborAccountID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Account</para>
		/// </summary>
		[DataMember(Name="LaborAccount", EmitDefaultValue=false)]
		public StringValue? LaborAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborSubID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Labor Sub</para>
		/// </summary>
		[DataMember(Name="LaborSub", EmitDefaultValue=false)]
		public StringValue? LaborSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverheadAccountID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Overhead Account</para>
		/// </summary>
		[DataMember(Name="OverheadAccount", EmitDefaultValue=false)]
		public StringValue? OverheadAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverheadSubID</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>Display Name: Overhead Sub</para>
		/// </summary>
		[DataMember(Name="OverheadSub", EmitDefaultValue=false)]
		public StringValue? OverheadSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborType</para>
		/// <para>DAC: PX.Objects.AM.AMLaborCode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}