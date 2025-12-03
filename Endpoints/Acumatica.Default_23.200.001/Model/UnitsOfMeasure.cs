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
	/// Corresponds to the screen <c>CS203100</c> in the Acumatica ERP
	/// <para>Key Fields: FromUOM, ToUOM</para>
	/// </summary>
	[DataContract]
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: UnitRate</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Conversion Factor</para>
		/// </summary>
		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue? ConversionFactor { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FromUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: From Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue? FromUOM { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitMultDiv</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: Multiply/Divide</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue? MultiplyOrDivide { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToUnit</para>
		/// <para>DAC: PX.Objects.IN.INUnit</para>
		/// <para>Display Name: To Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue? ToUOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}