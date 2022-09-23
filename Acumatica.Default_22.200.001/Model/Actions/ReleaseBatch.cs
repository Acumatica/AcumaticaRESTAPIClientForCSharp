using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReleaseBatch : EntityAction<PayrollBatch>
	{
		public ReleaseBatch(PayrollBatch entity) : base(entity)
		{ }
		public ReleaseBatch() : base()
		{ }
	}
}
