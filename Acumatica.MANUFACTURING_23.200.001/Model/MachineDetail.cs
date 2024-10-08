using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class MachineDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: MachAcctID 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Machine Account 
		/// </summary>
		[DataMember(Name="MachineAccount", EmitDefaultValue=false)]
		public StringValue? MachineAccount { get; set; }

		/// <summary>
		/// DAC Field Name: MachID 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Machine ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// Indicates if the machine record will be used (false value) or should the workcenter machine record be used as overriding values (true value)
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Machine Override 
		/// </summary>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// DAC Field Name: MachSubID 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Machine Subaccount 
		/// </summary>
		[DataMember(Name="MachineSubaccount", EmitDefaultValue=false)]
		public StringValue? MachineSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMWCMach 
		/// Display Name: Standard Cost 
		/// </summary>
		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

	}
}