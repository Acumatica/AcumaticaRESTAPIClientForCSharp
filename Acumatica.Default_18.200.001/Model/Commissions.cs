using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class Commissions : Entity
	{

		[DataMember(Name="DefaultSalesperson", EmitDefaultValue=false)]
		public StringValue DefaultSalesperson { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesPersonDetail> SalesPersons { get; set; }

	}
}