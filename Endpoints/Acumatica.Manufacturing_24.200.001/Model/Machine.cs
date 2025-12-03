using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM204500</c> in the Acumatica ERP
	/// <para>Key Fields: MachineID</para>
	/// </summary>
	[DataContract]
	public class Machine : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: MachAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Asset ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="AssetID", EmitDefaultValue=false)]
		public StringValue? AssetID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>SQL Type: nvarchar(120)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DownFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		[DataMember(Name="Down", EmitDefaultValue=false)]
		public BooleanValue? Down { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachEff</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// <para>Display Name: Machine ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMMachCurySettings</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachSubID</para>
		/// <para>DAC: PX.Objects.AM.AMMach</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}