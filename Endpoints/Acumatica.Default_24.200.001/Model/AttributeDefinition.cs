using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS205000</c> in the Acumatica ERP
	/// <para>Key Fields: AttributeID</para>
	/// </summary>
	public class AttributeDefinition : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Control Type</para>
		/// </summary>
		public StringValue? ControlType { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Entry Mask</para>
		/// <para>SQL Type: varchar(60)</para>
		/// </summary>
		public StringValue? EntryMask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsInternal</para>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Reg. Exp.</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? RegExp { get; set; }

		public List<AttributeDefinitionValue>? Values { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Values = "Values";
			public const string Values_Files = "Values/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Values,Values/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}