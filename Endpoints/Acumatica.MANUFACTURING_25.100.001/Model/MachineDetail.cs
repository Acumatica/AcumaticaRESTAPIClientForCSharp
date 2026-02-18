using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class MachineDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: MachAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Account</para>
		/// </summary>
		public StringValue? MachineAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? MachineID { get; set; }

		/// <summary>
		/// Indicates if the machine record will be used (false value) or should the workcenter machine record be used as overriding values (true value)
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Override</para>
		/// </summary>
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachSubID</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Machine Subaccount</para>
		/// </summary>
		public StringValue? MachineSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMWCMach</para>
		/// <para>Display Name: Standard Cost</para>
		/// </summary>
		public DecimalValue? StandardCost { get; set; }

	}
}