using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM204500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Machine : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachAcctID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AssetID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AssetID", EmitDefaultValue=false)]
		public StringValue? AssetID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DownFlg 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Down", EmitDefaultValue=false)]
		public BooleanValue? Down { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachEff 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMMachCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachSubID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}