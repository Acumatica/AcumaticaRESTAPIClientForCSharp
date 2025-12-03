using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL203000</c> in the Acumatica ERP
	/// <para>Key Fields: SubaccountCD</para>
	/// </summary>
	[DataContract]
	public class Subaccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Indicates whether the Subaccount is active.Inactive subaccounts do not appear in the lists of available subaccounts andthus can't be selected for documents, transactions and other entities.
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the Subaccount.
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// </summary>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly segmented key of the Subaccount.
		/// <para>DAC Field Name: SubCD</para>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>Display Name: Subaccount</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue? SubaccountCD { get; set; }

		/// <summary>
		/// Database identity.Unique identifier of the Subaccount.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.GL.Sub</para>
		/// <para>Display Name: Sub. ID</para>
		/// </summary>
		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue? SubaccountID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}