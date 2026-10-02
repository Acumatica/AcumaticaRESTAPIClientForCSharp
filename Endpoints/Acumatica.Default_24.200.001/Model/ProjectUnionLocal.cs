using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectUnionLocal : Entity
	{

		#region Fields
		/// <summary>
		/// The identifier of the union local that is linked to the project.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.PMProjectUnion</para>
		/// <para>Display Name: Union Local</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? UnionLocalID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID_Description</para>
		/// <para>DAC: PX.Objects.PM.PMProjectUnion</para>
		/// </summary>
		public StringValue? Description { get; set; }

		#endregion

	}
}