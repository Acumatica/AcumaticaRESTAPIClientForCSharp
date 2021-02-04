using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class ReleaseMoveEntry : EntityAction<MoveEntry>
	{
		public ReleaseMoveEntry(MoveEntry entity) : base(entity)
		{ }
		public ReleaseMoveEntry() : base()
		{ }
	}
}
