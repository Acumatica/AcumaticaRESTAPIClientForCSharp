using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CapableToPromiseProcessAll : EntityAction<CapableToPromise>
	{
		public CapableToPromiseProcessAll(CapableToPromise entity) : base(entity)
		{ }
		public CapableToPromiseProcessAll() : base()
		{ }
	}
}
