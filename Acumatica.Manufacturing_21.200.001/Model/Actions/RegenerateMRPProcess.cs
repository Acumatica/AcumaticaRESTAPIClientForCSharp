using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RegenerateMRPProcess : EntityAction<RegenerateMRP>
	{
		public RegenerateMRPProcess(RegenerateMRP entity) : base(entity)
		{ }
		public RegenerateMRPProcess() : base()
		{ }
	}
}
