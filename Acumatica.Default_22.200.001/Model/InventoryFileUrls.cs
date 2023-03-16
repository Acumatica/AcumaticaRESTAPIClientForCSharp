using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryFileUrls : Entity
	{

		[DataMember(Name="FileType", EmitDefaultValue=false)]
		public StringValue FileType { get; set; }

		[DataMember(Name="FileURL", EmitDefaultValue=false)]
		public StringValue FileURL { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

	}
}