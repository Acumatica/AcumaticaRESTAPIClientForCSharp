using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AppAttributes : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AttributeID</para>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Attribute { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSApptLineSplit</para>
		/// <para>Display Name: Related Document</para>
		/// </summary>
		public GuidValue? RefNoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: isRequired</para>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// </summary>
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Value { get; set; }

	}
}