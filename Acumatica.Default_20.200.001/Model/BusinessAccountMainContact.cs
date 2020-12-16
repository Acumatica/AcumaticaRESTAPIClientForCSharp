using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class BusinessAccountMainContact : Entity_v4
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue Fax { get; set; }

		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue JobTitle { get; set; }

		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue LanguageOrLocale { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue Phone2 { get; set; }

		[DataMember(Name="Web", EmitDefaultValue=false)]
		public StringValue Web { get; set; }

	}
}