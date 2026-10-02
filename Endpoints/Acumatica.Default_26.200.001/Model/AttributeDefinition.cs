using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS205000</c> in the Acumatica ERP
	/// <para>Key Fields: AttributeID</para>
	/// </summary>
	public class AttributeDefinition : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Control Type</para>
		/// </summary>
		public IntSingleSelectValue? ControlType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsInternal</para>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Entry Mask</para>
		/// <para>SQL Type: varchar(60)</para>
		/// </summary>
		public StringValue? EntryMask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>Display Name: Reg. Exp.</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? RegExp { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region Details
		public List<AttributeDefinitionValue>? Values { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(AttributeDefinition)} - \"{AttributeID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Values = "Values";

			//Intentionally excluded
			//public const string All = "Files,Translations,Values";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}