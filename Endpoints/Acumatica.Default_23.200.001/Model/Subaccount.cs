using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL203000</c> in the Acumatica ERP
	/// <para>Key Fields: SubaccountCD</para>
	/// </summary>
	public class Subaccount : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// Key field.Unique user-friendly segmented key of the Subaccount.
		/// <para>DAC Field Name: SubCD</para>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>Display Name: Subaccount</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? SubaccountCD { get; set; }

		/// <summary>
		/// Database identity.Unique identifier of the Subaccount.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>Display Name: Sub. ID</para>
		/// </summary>
		public IntValue? SubaccountID { get; set; }

		/// <summary>
		/// Indicates whether the Subaccount is <c>active</c>.Inactive subaccounts do not appear in the lists of available subaccounts andthus can't be selected for documents, transactions and other entities.
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the Subaccount.
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// </summary>
		public BooleanValue? Secured { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Subaccount)} - \"{SubaccountCD}\"";
		}

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}