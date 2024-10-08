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
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: AssemblyValid 
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Assembly Allowed 
		/// </summary>
		[DataMember(Name="AssemblyAllowed", EmitDefaultValue=false)]
		public BooleanValue? AssemblyAllowed { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INSite 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Location ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Pick Priority 
		/// </summary>
		[DataMember(Name="PickPriority", EmitDefaultValue=false)]
		public ShortValue? PickPriority { get; set; }

		/// <summary>
		/// DAC Field Name: ReceiptsValid 
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Receipts Allowed 
		/// </summary>
		[DataMember(Name="ReceiptsAllowed", EmitDefaultValue=false)]
		public BooleanValue? ReceiptsAllowed { get; set; }

		/// <summary>
		/// DAC Field Name: SalesValid 
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Sales Allowed 
		/// </summary>
		[DataMember(Name="SalesAllowed", EmitDefaultValue=false)]
		public BooleanValue? SalesAllowed { get; set; }

		/// <summary>
		/// DAC Field Name: TransfersValid 
		/// DAC: PX.Objects.IN.INLocation 
		/// Display Name: Transfers Allowed 
		/// </summary>
		[DataMember(Name="TransfersAllowed", EmitDefaultValue=false)]
		public BooleanValue? TransfersAllowed { get; set; }

	}
}