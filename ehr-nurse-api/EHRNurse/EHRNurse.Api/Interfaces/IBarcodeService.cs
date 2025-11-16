using EHRNurse.Api.Dto;

namespace EHRNurse.Api.Interfaces
{
    public interface IBarcodeService
    {
        Task<BarcodeResponse> ProcessBarcodeAsync(string barcodeData);
    }
}
