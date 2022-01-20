using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderSubmit : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderSubmit(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderSubmit() : base()
		{ }
	}
}
