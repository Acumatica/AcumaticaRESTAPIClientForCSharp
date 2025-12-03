using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM507000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EmailProcessing : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public IntValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Account_description</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="AccountEmailAccountID", EmitDefaultValue=false)]
		public StringValue? AccountEmailAccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="AssignedToMe", EmitDefaultValue=false)]
		public BooleanValue? AssignedToMe { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="AssignedToOwner", EmitDefaultValue=false)]
		public StringValue? AssignedToOwner { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="IncludeFailed", EmitDefaultValue=false)]
		public BooleanValue? IncludeFailed { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<EmailProcessingRow>? Result { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Result = "Result";
			public const string Result_Files = "Result/Files";

			//Intentionally excluded
			//public const string All = "Files,Result,Result/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}