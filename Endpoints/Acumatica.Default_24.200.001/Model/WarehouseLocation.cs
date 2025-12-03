using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class WarehouseLocation : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssemblyValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Assembly Allowed</para>
		/// </summary>
		[DataMember(Name="AssemblyAllowed", EmitDefaultValue=false)]
		public BooleanValue? AssemblyAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Location ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Pick Priority</para>
		/// </summary>
		[DataMember(Name="PickPriority", EmitDefaultValue=false)]
		public ShortValue? PickPriority { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptsValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Receipts Allowed</para>
		/// </summary>
		[DataMember(Name="ReceiptsAllowed", EmitDefaultValue=false)]
		public BooleanValue? ReceiptsAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Sales Allowed</para>
		/// </summary>
		[DataMember(Name="SalesAllowed", EmitDefaultValue=false)]
		public BooleanValue? SalesAllowed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TransfersValid</para>
		/// <para>DAC: PX.Objects.IN.INLocation</para>
		/// <para>Display Name: Transfers Allowed</para>
		/// </summary>
		[DataMember(Name="TransfersAllowed", EmitDefaultValue=false)]
		public BooleanValue? TransfersAllowed { get; set; }

	}
}