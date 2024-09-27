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
		/// DAC Field Name: MachAcctID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMach 
		/// Display Name: Asset ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="AssetID", EmitDefaultValue=false)]
		public StringValue? AssetID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMach 
		/// Display Name: Calendar ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMMach 
		/// SQL Type: nvarchar(120) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DownFlg 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		[DataMember(Name="Down", EmitDefaultValue=false)]
		public BooleanValue? Down { get; set; }

		/// <summary>
		/// DAC Field Name: MachEff 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// DAC Field Name: MachID 
		/// DAC: PX.Objects.AM.AMMach 
		/// Display Name: Machine ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMMachCurySettings 
		/// Display Name: Standard Cost 
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

		/// <summary>
		/// DAC Field Name: MachSubID 
		/// DAC: PX.Objects.AM.AMMach 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}