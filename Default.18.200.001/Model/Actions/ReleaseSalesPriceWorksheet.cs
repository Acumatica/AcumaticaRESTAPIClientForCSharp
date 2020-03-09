
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseSalesPriceWorksheet : EntityAction<SalesPriceWorksheet>
    {
 public ReleaseSalesPriceWorksheet(SalesPriceWorksheet entity) : base(entity)
        { }
 public ReleaseSalesPriceWorksheet() : base()
        { }
  }
}
