using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CapableToPromiseProcess : EntityAction<CapableToPromise>
	{
		public CapableToPromiseProcess(CapableToPromise entity) : base(entity)
		{ }
		public CapableToPromiseProcess() : base()
		{ }
	}
}
