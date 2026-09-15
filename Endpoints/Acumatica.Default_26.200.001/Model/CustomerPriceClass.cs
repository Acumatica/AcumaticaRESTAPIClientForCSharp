using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR208000</c> in the Acumatica ERP
	/// <para>Key Fields: PriceClassID</para>
	/// </summary>
	[DataContract]
	public class CustomerPriceClass : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the customer price class.
		/// <para>DAC: PX.Objects.AR.ARPriceClass</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the customer price class.This field is the key field.
		/// <para>DAC: PX.Objects.AR.ARPriceClass</para>
		/// <para>Display Name: Price Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}