using EHRNurse.Api.Dto;
using EHRNurse.Api.Interfaces;
using EHRNurse.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EHRNurse.Api.Services
{
    public class BarcodeService : IBarcodeService
    {
        private readonly AppDbContext _context;
        private const string PatientPrefix = "PAT";
        private const string MedicationPrefix = "MED";

        public BarcodeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BarcodeResponse> ProcessBarcodeAsync(string barcodeData)
        {
            try
            {
                if (barcodeData.StartsWith(PatientPrefix))
                {
                    var patient = await GetPatientFromBarcodeAsync(barcodeData);
                    return patient == null
                        ? new BarcodeResponse { Success = false, Type = "patient", Message = "Patient not found" }
                        : new BarcodeResponse { Success = true, Type = "patient", Data = patient, Message = "Patient found" };
                }
                else if (barcodeData.StartsWith(MedicationPrefix))
                {
                    var medication = await GetMedicationFromBarcodeAsync(barcodeData);
                    return medication == null
                        ? new BarcodeResponse { Success = false, Type = "medication", Message = "Medication not found" }
                        : new BarcodeResponse { Success = true, Type = "medication", Data = medication, Message = "Medication found" };
                }

                return new BarcodeResponse { Success = false, Type = "unknown", Message = "Unknown barcode format" };
            }
            catch (Exception ex)
            {
                return new BarcodeResponse { Success = false, Type = "error", Message = ex.Message };
            }
        }

        private async Task<Patient?> GetPatientFromBarcodeAsync(string barcode)
        {
            if (long.TryParse(barcode.Replace(PatientPrefix, ""), out var patientId))
                return await _context.Patients.FirstOrDefaultAsync(p => p.Id == patientId);

            return null;
        }

        private async Task<MedicationDatum?> GetMedicationFromBarcodeAsync(string barcode)
        {
            if (int.TryParse(barcode.Replace(MedicationPrefix, ""), out var medicationId))
            {
                return await _context.MedicationData
                    .FirstOrDefaultAsync(m => m.Id == medicationId);
            }

            return null;
        }
    }
}
