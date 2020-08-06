using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeCostCodeID : EntityActionWithParameters<CostCode, ChangeCostCodeIDParameters>
	{
		public ChangeCostCodeID() : base()
		{ }
		public ChangeCostCodeID(CostCode entity, ChangeCostCodeIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue CostCodeID
		{
			get { return Parameters.CostCodeID; }
			set { Parameters.CostCodeID = value; }
		}
	}
}