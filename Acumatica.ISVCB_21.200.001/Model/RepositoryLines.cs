using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class RepositoryLines : Entity_v4
	{

		[DataMember(Name="AcumaticaBuild", EmitDefaultValue=false)]
		public StringValue AcumaticaBuild { get; set; }

		[DataMember(Name="Certified", EmitDefaultValue=false)]
		public BooleanValue Certified { get; set; }

		[DataMember(Name="ISVVersion", EmitDefaultValue=false)]
		public StringValue ISVVersion { get; set; }

	}
}