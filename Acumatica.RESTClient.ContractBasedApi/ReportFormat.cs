using Acumatica.RESTClient.Api;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public enum ReportFormat
    {
        PDF = HeaderContentType.PDF,
        HTML = HeaderContentType.HTML,
        Excel = HeaderContentType.Excel,
    }
}
