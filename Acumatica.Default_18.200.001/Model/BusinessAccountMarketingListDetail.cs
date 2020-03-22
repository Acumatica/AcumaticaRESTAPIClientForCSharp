using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class BusinessAccountMarketingListDetail : Entity
	{

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="DynamicList", EmitDefaultValue=false)]
		public BooleanValue DynamicList { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue Format { get; set; }

		[DataMember(Name="ListName", EmitDefaultValue=false)]
		public StringValue ListName { get; set; }

		[DataMember(Name="MarketingListID", EmitDefaultValue=false)]
		public IntValue MarketingListID { get; set; }

		[DataMember(Name="MemberName", EmitDefaultValue=false)]
		public StringValue MemberName { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

		[DataMember(Name="Subscribed", EmitDefaultValue=false)]
		public BooleanValue Subscribed { get; set; }

	}
}