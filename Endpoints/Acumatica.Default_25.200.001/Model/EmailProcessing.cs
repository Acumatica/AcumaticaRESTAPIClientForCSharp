using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM507000</c> in the Acumatica ERP
	/// </summary>
	public class EmailProcessing : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public IntValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Account_description</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public StringValue? AccountEmailAccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public BooleanValue? AssignedToMe { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public StringValue? AssignedToOwner { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public BooleanValue? IncludeFailed { get; set; }

		public List<EmailProcessingRow>? Result { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.EmailProcessingMaint+EmailProcessingFilter</para>
		/// </summary>
		public StringValue? Type { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Result = "Result";
			public const string Result_Files = "Result/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Result,Result/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}