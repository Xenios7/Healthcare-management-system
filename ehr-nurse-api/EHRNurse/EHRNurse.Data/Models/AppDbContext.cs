using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EHRNurse.Data.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<AccommodationBed> AccommodationBeds { get; set; }

    public virtual DbSet<AccommodationBuilding> AccommodationBuildings { get; set; }

    public virtual DbSet<AccommodationDataHistory> AccommodationDataHistories { get; set; }

    public virtual DbSet<AccommodationDataHistoryItem> AccommodationDataHistoryItems { get; set; }

    public virtual DbSet<AccommodationDatum> AccommodationData { get; set; }

    public virtual DbSet<AccommodationFloor> AccommodationFloors { get; set; }

    public virtual DbSet<AccommodationRoom> AccommodationRooms { get; set; }

    public virtual DbSet<AccommodationWard> AccommodationWards { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressDatum> AddressData { get; set; }

    public virtual DbSet<AdmissionReason> AdmissionReasons { get; set; }

    public virtual DbSet<AllergyCategory> AllergyCategories { get; set; }

    public virtual DbSet<AllergyDatum> AllergyData { get; set; }

    public virtual DbSet<AllergyReaction> AllergyReactions { get; set; }

    public virtual DbSet<AllergyUnknownDatum> AllergyUnknownData { get; set; }

    public virtual DbSet<Answer> Answers { get; set; }

    public virtual DbSet<AnswerQuestionnaire> AnswerQuestionnaires { get; set; }

    public virtual DbSet<AppointmentDatum> AppointmentData { get; set; }

    public virtual DbSet<AppointmentParticipantActorDatum> AppointmentParticipantActorData { get; set; }

    public virtual DbSet<AppointmentParticipantDatum> AppointmentParticipantData { get; set; }

    public virtual DbSet<AppointmentPatientDatum> AppointmentPatientData { get; set; }

    public virtual DbSet<AppointmentRecurrentType> AppointmentRecurrentTypes { get; set; }

    public virtual DbSet<AppointmentSlotDatum> AppointmentSlotData { get; set; }

    public virtual DbSet<AppointmentStatus> AppointmentStatuses { get; set; }

    public virtual DbSet<AppointmentStatusType> AppointmentStatusTypes { get; set; }

    public virtual DbSet<ArterialBloodGasDatum> ArterialBloodGasData { get; set; }

    public virtual DbSet<CapnographyDatum> CapnographyData { get; set; }

    public virtual DbSet<CarePlanDatum> CarePlanData { get; set; }

    public virtual DbSet<ComorbidityDatum> ComorbidityData { get; set; }

    public virtual DbSet<Complication> Complications { get; set; }

    public virtual DbSet<ComplicationDatum> ComplicationData { get; set; }

    public virtual DbSet<Definition> Definitions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DietType> DietTypes { get; set; }

    public virtual DbSet<DietaryHabitsDatum> DietaryHabitsData { get; set; }

    public virtual DbSet<DischargeDatum> DischargeData { get; set; }

    public virtual DbSet<DischargeSituation> DischargeSituations { get; set; }

    public virtual DbSet<DischargeType> DischargeTypes { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<EhdsiAbsentOrUnknownAllergy> EhdsiAbsentOrUnknownAllergies { get; set; }

    public virtual DbSet<EhdsiAbsentOrUnknownDevice> EhdsiAbsentOrUnknownDevices { get; set; }

    public virtual DbSet<EhdsiAbsentOrUnknownMedication> EhdsiAbsentOrUnknownMedications { get; set; }

    public virtual DbSet<EhdsiAbsentOrUnknownProblem> EhdsiAbsentOrUnknownProblems { get; set; }

    public virtual DbSet<EhdsiAbsentOrUnknownProcedure> EhdsiAbsentOrUnknownProcedures { get; set; }

    public virtual DbSet<EhdsiActiveIngredient> EhdsiActiveIngredients { get; set; }

    public virtual DbSet<EhdsiAdministrativeGender> EhdsiAdministrativeGenders { get; set; }

    public virtual DbSet<EhdsiAdverseEventType> EhdsiAdverseEventTypes { get; set; }

    public virtual DbSet<EhdsiAllergenNoDrug> EhdsiAllergenNoDrugs { get; set; }

    public virtual DbSet<EhdsiAllergiesCustom> EhdsiAllergiesCustoms { get; set; }

    public virtual DbSet<EhdsiAllergyCertainty> EhdsiAllergyCertainties { get; set; }

    public virtual DbSet<EhdsiAllergyStatus> EhdsiAllergyStatuses { get; set; }

    public virtual DbSet<EhdsiBloodGroup> EhdsiBloodGroups { get; set; }

    public virtual DbSet<EhdsiBloodPressure> EhdsiBloodPressures { get; set; }

    public virtual DbSet<EhdsiCertainty> EhdsiCertainties { get; set; }

    public virtual DbSet<EhdsiCodeProb> EhdsiCodeProbs { get; set; }

    public virtual DbSet<EhdsiConfidentiality> EhdsiConfidentialities { get; set; }

    public virtual DbSet<EhdsiCountry> EhdsiCountries { get; set; }

    public virtual DbSet<EhdsiCriticality> EhdsiCriticalities { get; set; }

    public virtual DbSet<EhdsiCurrentPregnancyStatus> EhdsiCurrentPregnancyStatuses { get; set; }

    public virtual DbSet<EhdsiDisplayLabel> EhdsiDisplayLabels { get; set; }

    public virtual DbSet<EhdsiDocumentCode> EhdsiDocumentCodes { get; set; }

    public virtual DbSet<EhdsiDoseForm> EhdsiDoseForms { get; set; }

    public virtual DbSet<EhdsiHealthcareProfessionalRole> EhdsiHealthcareProfessionalRoles { get; set; }

    public virtual DbSet<EhdsiHospitalDischargeReportType> EhdsiHospitalDischargeReportTypes { get; set; }

    public virtual DbSet<EhdsiIllnessandDisorder> EhdsiIllnessandDisorders { get; set; }

    public virtual DbSet<EhdsiLaboratoryReportType> EhdsiLaboratoryReportTypes { get; set; }

    public virtual DbSet<EhdsiLanguage> EhdsiLanguages { get; set; }

    public virtual DbSet<EhdsiMedicalDevice> EhdsiMedicalDevices { get; set; }

    public virtual DbSet<EhdsiMedicalImagesType> EhdsiMedicalImagesTypes { get; set; }

    public virtual DbSet<EhdsiMedicalImagingReportType> EhdsiMedicalImagingReportTypes { get; set; }

    public virtual DbSet<EhdsiNullFlavor> EhdsiNullFlavors { get; set; }

    public virtual DbSet<EhdsiOutcomeOfPregnancy> EhdsiOutcomeOfPregnancies { get; set; }

    public virtual DbSet<EhdsiPackage> EhdsiPackages { get; set; }

    public virtual DbSet<EhdsiPersonalRelationship> EhdsiPersonalRelationships { get; set; }

    public virtual DbSet<EhdsiPregnancyInformation> EhdsiPregnancyInformations { get; set; }

    public virtual DbSet<EhdsiProcedure> EhdsiProcedures { get; set; }

    public virtual DbSet<EhdsiQuantityUnit> EhdsiQuantityUnits { get; set; }

    public virtual DbSet<EhdsiRareDisease> EhdsiRareDiseases { get; set; }

    public virtual DbSet<EhdsiReactionAllergy> EhdsiReactionAllergies { get; set; }

    public virtual DbSet<EhdsiResolutionOutcome> EhdsiResolutionOutcomes { get; set; }

    public virtual DbSet<EhdsiRoleClass> EhdsiRoleClasses { get; set; }

    public virtual DbSet<EhdsiRouteofAdministration> EhdsiRouteofAdministrations { get; set; }

    public virtual DbSet<EhdsiSection> EhdsiSections { get; set; }

    public virtual DbSet<EhdsiSeverity> EhdsiSeverities { get; set; }

    public virtual DbSet<EhdsiSocialHistory> EhdsiSocialHistories { get; set; }

    public virtual DbSet<EhdsiStatusCode> EhdsiStatusCodes { get; set; }

    public virtual DbSet<EhdsiSubstance> EhdsiSubstances { get; set; }

    public virtual DbSet<EhdsiSubstitutionCode> EhdsiSubstitutionCodes { get; set; }

    public virtual DbSet<EhdsiTelecomAddress> EhdsiTelecomAddresses { get; set; }

    public virtual DbSet<EhdsiTimingEvent> EhdsiTimingEvents { get; set; }

    public virtual DbSet<EhdsiUnit> EhdsiUnits { get; set; }

    public virtual DbSet<EhdsiVaccine> EhdsiVaccines { get; set; }

    public virtual DbSet<EpisodeCare> EpisodeCares { get; set; }

    public virtual DbSet<Etiology> Etiologies { get; set; }

    public virtual DbSet<EtiologyDatum> EtiologyData { get; set; }

    public virtual DbSet<ExternalDoctor> ExternalDoctors { get; set; }

    public virtual DbSet<ExternalDoctorSpecialty> ExternalDoctorSpecialties { get; set; }

    public virtual DbSet<ExternalDoctorsCyma> ExternalDoctorsCymas { get; set; }

    public virtual DbSet<FoodDatum> FoodData { get; set; }

    public virtual DbSet<FoodType> FoodTypes { get; set; }

    public virtual DbSet<GlasgowDatum> GlasgowData { get; set; }

    public virtual DbSet<GlasgowEyeOpening> GlasgowEyeOpenings { get; set; }

    public virtual DbSet<GlasgowMotorResponse> GlasgowMotorResponses { get; set; }

    public virtual DbSet<GlasgowVerbalResponse> GlasgowVerbalResponses { get; set; }

    public virtual DbSet<GlucoseDatum> GlucoseData { get; set; }

    public virtual DbSet<HysteroscopyAnatomicalPosition> HysteroscopyAnatomicalPositions { get; set; }

    public virtual DbSet<HysteroscopyAnatomicalSubPosition> HysteroscopyAnatomicalSubPositions { get; set; }

    public virtual DbSet<HysteroscopyFileDatum> HysteroscopyFileData { get; set; }

    public virtual DbSet<ImagingDatum> ImagingData { get; set; }

    public virtual DbSet<ImagingFilePath> ImagingFilePaths { get; set; }

    public virtual DbSet<ImagingPredictionDatum> ImagingPredictionData { get; set; }

    public virtual DbSet<IpsCdaDatum> IpsCdaData { get; set; }

    public virtual DbSet<Laboratory> Laboratories { get; set; }

    public virtual DbSet<LaboratoryDataItem> LaboratoryDataItems { get; set; }

    public virtual DbSet<LaboratoryDatum> LaboratoryData { get; set; }

    public virtual DbSet<LaboratoryFilesDatum> LaboratoryFilesData { get; set; }

    public virtual DbSet<LaboratoryGroup> LaboratoryGroups { get; set; }

    public virtual DbSet<LaboratoryGroupLaboratory> LaboratoryGroupLaboratories { get; set; }

    public virtual DbSet<Locale> Locales { get; set; }

    public virtual DbSet<MasterCategory> MasterCategories { get; set; }

    public virtual DbSet<MasterCategoryModality> MasterCategoryModalities { get; set; }

    public virtual DbSet<MasterExamTitle> MasterExamTitles { get; set; }

    public virtual DbSet<MasterTimingUnit> MasterTimingUnits { get; set; }

    public virtual DbSet<MedicalAlertDatum> MedicalAlertData { get; set; }

    public virtual DbSet<MedicalDeviceAction> MedicalDeviceActions { get; set; }

    public virtual DbSet<MedicalDeviceUnknownDatum> MedicalDeviceUnknownData { get; set; }

    public virtual DbSet<MedicalDevicesDatum> MedicalDevicesData { get; set; }

    public virtual DbSet<MedicalHistoryDatum> MedicalHistoryData { get; set; }

    public virtual DbSet<MedicationDatum> MedicationData { get; set; }

    public virtual DbSet<MedicationUnknownDatum> MedicationUnknownData { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModuleRelationship> ModuleRelationships { get; set; }

    public virtual DbSet<NeckSizeDatum> NeckSizeData { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientClosestRelative> PatientClosestRelatives { get; set; }

    public virtual DbSet<PatientDoctor> PatientDoctors { get; set; }

    public virtual DbSet<PatientDocumentsDatum> PatientDocumentsData { get; set; }

    public virtual DbSet<PatientEducationLevel> PatientEducationLevels { get; set; }

    public virtual DbSet<PatientEmergencyContactsDatum> PatientEmergencyContactsData { get; set; }

    public virtual DbSet<PatientFamilyStatus> PatientFamilyStatuses { get; set; }

    public virtual DbSet<PatientFileType> PatientFileTypes { get; set; }

    public virtual DbSet<PatientFilesDatum> PatientFilesData { get; set; }

    public virtual DbSet<PatientImmobilityStatus> PatientImmobilityStatuses { get; set; }

    public virtual DbSet<PatientInsurance> PatientInsurances { get; set; }

    public virtual DbSet<PatientRegistrationHistoryDatum> PatientRegistrationHistoryData { get; set; }

    public virtual DbSet<PatientRegistrationStatus> PatientRegistrationStatuses { get; set; }

    public virtual DbSet<PatientRejectionReason> PatientRejectionReasons { get; set; }

    public virtual DbSet<PatientReligion> PatientReligions { get; set; }

    public virtual DbSet<PatientSourceOfIncome> PatientSourceOfIncomes { get; set; }

    public virtual DbSet<Pdqv3patient> Pdqv3patients { get; set; }

    public virtual DbSet<Pdqv3patientIdentifier> Pdqv3patientIdentifiers { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PharmActivesubstance> PharmActivesubstances { get; set; }

    public virtual DbSet<PharmActivesubstancelist> PharmActivesubstancelists { get; set; }

    public virtual DbSet<PharmAtc> PharmAtcs { get; set; }

    public virtual DbSet<PharmAtclist> PharmAtclists { get; set; }

    public virtual DbSet<PharmDoseFormMapping> PharmDoseFormMappings { get; set; }

    public virtual DbSet<PharmForm> PharmForms { get; set; }

    public virtual DbSet<PharmFormlist> PharmFormlists { get; set; }

    public virtual DbSet<PharmPackagesizeunit> PharmPackagesizeunits { get; set; }

    public virtual DbSet<PharmPackagesizeunitlist> PharmPackagesizeunitlists { get; set; }

    public virtual DbSet<PharmProduct> PharmProducts { get; set; }

    public virtual DbSet<PharmQuantityunit> PharmQuantityunits { get; set; }

    public virtual DbSet<PharmRoute> PharmRoutes { get; set; }

    public virtual DbSet<PharmRoutelist> PharmRoutelists { get; set; }

    public virtual DbSet<PregnancyHistoryDatum> PregnancyHistoryData { get; set; }

    public virtual DbSet<PregnancyOutcomeDatum> PregnancyOutcomeData { get; set; }

    public virtual DbSet<PregnancyStatusDatum> PregnancyStatusData { get; set; }

    public virtual DbSet<ProblemDatum> ProblemData { get; set; }

    public virtual DbSet<ProblemUnknownDatum> ProblemUnknownData { get; set; }

    public virtual DbSet<ProcedureDatum> ProcedureData { get; set; }

    public virtual DbSet<ProcedureUnknownDatum> ProcedureUnknownData { get; set; }

    public virtual DbSet<QuestionPage> QuestionPages { get; set; }

    public virtual DbSet<QuestionTemplate> QuestionTemplates { get; set; }

    public virtual DbSet<QuestionTemplateValue> QuestionTemplateValues { get; set; }

    public virtual DbSet<QuestionType> QuestionTypes { get; set; }

    public virtual DbSet<QuestionnaireDatum> QuestionnaireData { get; set; }

    public virtual DbSet<QuestionnaireTemplate> QuestionnaireTemplates { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RespiratoryClinicalExamination> RespiratoryClinicalExaminations { get; set; }

    public virtual DbSet<RespiratoryClinicalExaminationDatum> RespiratoryClinicalExaminationData { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SelfReportBodyPart> SelfReportBodyParts { get; set; }

    public virtual DbSet<SelfReportDatum> SelfReportData { get; set; }

    public virtual DbSet<SelfReportMedicationFrequency> SelfReportMedicationFrequencies { get; set; }

    public virtual DbSet<SelfReportPainLevel> SelfReportPainLevels { get; set; }

    public virtual DbSet<SelfReportSymptom> SelfReportSymptoms { get; set; }

    public virtual DbSet<SelfReportSymptomLookup> SelfReportSymptomLookups { get; set; }

    public virtual DbSet<SelfReportTimeOfDay> SelfReportTimeOfDays { get; set; }

    public virtual DbSet<SelfReportTimeOfDayLookup> SelfReportTimeOfDayLookups { get; set; }

    public virtual DbSet<SmartHealthLink> SmartHealthLinks { get; set; }

    public virtual DbSet<SocialHistoryDatum> SocialHistoryData { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TenantSetting> TenantSettings { get; set; }

    public virtual DbSet<TracheostomyConsistencyOfTube> TracheostomyConsistencyOfTubes { get; set; }

    public virtual DbSet<TracheostomyCtParametersDatum> TracheostomyCtParametersData { get; set; }

    public virtual DbSet<TracheostomyCuffDiameter> TracheostomyCuffDiameters { get; set; }

    public virtual DbSet<TracheostomyInnerDiameter> TracheostomyInnerDiameters { get; set; }

    public virtual DbSet<TracheostomyOuterDiameter> TracheostomyOuterDiameters { get; set; }

    public virtual DbSet<TracheostomyTubeCharacteristicsDatum> TracheostomyTubeCharacteristicsData { get; set; }

    public virtual DbSet<TracheostomyTubeInspection> TracheostomyTubeInspections { get; set; }

    public virtual DbSet<TracheostomyTubeInspectionDatum> TracheostomyTubeInspectionData { get; set; }

    public virtual DbSet<TracheostomyTubeLength> TracheostomyTubeLengths { get; set; }

    public virtual DbSet<TracheostomyTubeType> TracheostomyTubeTypes { get; set; }

    public virtual DbSet<Translation> Translations { get; set; }

    public virtual DbSet<Translation1> Translations1 { get; set; }

    public virtual DbSet<TravelHistoryDatum> TravelHistoryData { get; set; }

    public virtual DbSet<User> Users { get; set; }
    public DbSet<Shift> Shifts { get; set; } 
    public virtual DbSet<VaccinationDatum> VaccinationData { get; set; }

    public virtual DbSet<ValueSet> ValueSets { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<VitalSignDatum> VitalSignData { get; set; }

    public virtual DbSet<WeightDatum> WeightData { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         optionsBuilder.UseNpgsql("Server=5.75.181.25;Port=30722;Database=ehr;User Id=ehr-user;Password=_Pz&AbdBK6>,5$uX");
    //     }
    // }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         // Fallback only; normally Program.cs provides the connection.
    //         optionsBuilder.UseNpgsql(
    //             "Host=localhost;Port=5432;Database=ehrnurse_local;Username=postgres;Password=postgres");
    //     }
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("pg_stat_statements");

        modelBuilder.Entity<AccommodationBed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_beds");

            entity.ToTable("accommodation_beds");

            entity.HasIndex(e => e.RoomId, "ix_accommodation_beds_room_id");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_beds_tenant_id");

            entity.HasIndex(e => e.TranslationId, "ix_accommodation_beds_translation_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_beds_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.IsAvailable).HasColumnName("is_available");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.OrderBy).HasColumnName("order_by");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Room).WithMany(p => p.AccommodationBeds)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("fk_accommodation_beds_accommodation_rooms_room_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationBeds)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_beds_tenant_tenant_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AccommodationBeds)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_accommodation_beds_translations_translation_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationBeds)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_beds_users_user_id");
        });

        modelBuilder.Entity<AccommodationBuilding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_buildings");

            entity.ToTable("accommodation_buildings");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_buildings_tenant_id");

            entity.HasIndex(e => e.TranslationId, "ix_accommodation_buildings_translation_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_buildings_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationBuildings)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_buildings_tenant_tenant_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AccommodationBuildings)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_accommodation_buildings_translations_translation_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationBuildings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_buildings_users_user_id");
        });

        modelBuilder.Entity<AccommodationDataHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_data_history");

            entity.ToTable("accommodation_data_history");

            entity.HasIndex(e => e.AccommodationDataId, "ix_accommodation_data_history_accommodation_data_id");

            entity.HasIndex(e => e.PatientId, "ix_accommodation_data_history_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_data_history_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_data_history_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccommodationDataId).HasColumnName("accommodation_data_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.IsHistorical).HasColumnName("is_historical");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AccommodationData).WithMany(p => p.AccommodationDataHistories)
                .HasForeignKey(d => d.AccommodationDataId)
                .HasConstraintName("fk_accommodation_data_history_accommodation_data_accommodation");

            entity.HasOne(d => d.Patient).WithMany(p => p.AccommodationDataHistories)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_accommodation_data_history_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationDataHistories)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_data_history_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationDataHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_data_history_users_user_id");
        });

        modelBuilder.Entity<AccommodationDataHistoryItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_data_history_items");

            entity.ToTable("accommodation_data_history_items");

            entity.HasIndex(e => e.AccommodationDataHistoryId, "ix_accommodation_data_history_items_accommodation_data_history");

            entity.HasIndex(e => e.RegistrationStatusId, "ix_accommodation_data_history_items_registration_status_id");

            entity.HasIndex(e => e.RejectionReasonId, "ix_accommodation_data_history_items_rejection_reason_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_data_history_items_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccommodationDataHistoryId).HasColumnName("accommodation_data_history_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RegistrationStatusId).HasColumnName("registration_status_id");
            entity.Property(e => e.RejectionReasonId).HasColumnName("rejection_reason_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AccommodationDataHistory).WithMany(p => p.AccommodationDataHistoryItems)
                .HasForeignKey(d => d.AccommodationDataHistoryId)
                .HasConstraintName("fk_accommodation_data_history_items_accommodation_data_history");

            entity.HasOne(d => d.RegistrationStatus).WithMany(p => p.AccommodationDataHistoryItems)
                .HasForeignKey(d => d.RegistrationStatusId)
                .HasConstraintName("fk_accommodation_data_history_items_patient_registration_statu");

            entity.HasOne(d => d.RejectionReason).WithMany(p => p.AccommodationDataHistoryItems)
                .HasForeignKey(d => d.RejectionReasonId)
                .HasConstraintName("fk_accommodation_data_history_items_patient_rejection_reasons_");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationDataHistoryItems)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_data_history_items_users_user_id");
        });

        modelBuilder.Entity<AccommodationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_data");

            entity.ToTable("accommodation_data");

            entity.HasIndex(e => e.AdmissionReasonId, "ix_accommodation_data_admission_reason_id");

            entity.HasIndex(e => e.BedId, "ix_accommodation_data_bed_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_accommodation_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_accommodation_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdmissionNotes).HasColumnName("admission_notes");
            entity.Property(e => e.AdmissionReasonId).HasColumnName("admission_reason_id");
            entity.Property(e => e.BedId).HasColumnName("bed_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DischargeDate).HasColumnName("discharge_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(false)
                .HasColumnName("is_active");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MoveBedNotes).HasColumnName("move_bed_notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AdmissionReason).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.AdmissionReasonId)
                .HasConstraintName("fk_accommodation_data_admission_reasons_admission_reason_id");

            entity.HasOne(d => d.Bed).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.BedId)
                .HasConstraintName("fk_accommodation_data_accommodation_beds_bed_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_accommodation_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_accommodation_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_data_users_user_id");
        });

        modelBuilder.Entity<AccommodationFloor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_floors");

            entity.ToTable("accommodation_floors");

            entity.HasIndex(e => e.BuildingId, "ix_accommodation_floors_building_id");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_floors_tenant_id");

            entity.HasIndex(e => e.TranslationId, "ix_accommodation_floors_translation_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_floors_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuildingId).HasColumnName("building_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Building).WithMany(p => p.AccommodationFloors)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("fk_accommodation_floors_accommodation_buildings_building_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationFloors)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_floors_tenant_tenant_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AccommodationFloors)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_accommodation_floors_translations_translation_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationFloors)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_floors_users_user_id");
        });

        modelBuilder.Entity<AccommodationRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_rooms");

            entity.ToTable("accommodation_rooms");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_rooms_tenant_id");

            entity.HasIndex(e => e.TranslationId, "ix_accommodation_rooms_translation_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_rooms_user_id");

            entity.HasIndex(e => e.WardId, "ix_accommodation_rooms_ward_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.WardId).HasColumnName("ward_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationRooms)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_rooms_tenant_tenant_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AccommodationRooms)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_accommodation_rooms_translations_translation_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationRooms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_rooms_users_user_id");

            entity.HasOne(d => d.Ward).WithMany(p => p.AccommodationRooms)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("fk_accommodation_rooms_accommodation_wards_ward_id");
        });

        modelBuilder.Entity<AccommodationWard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_accommodation_wards");

            entity.ToTable("accommodation_wards");

            entity.HasIndex(e => e.FloorId, "ix_accommodation_wards_floor_id");

            entity.HasIndex(e => e.TenantId, "ix_accommodation_wards_tenant_id");

            entity.HasIndex(e => e.TranslationId, "ix_accommodation_wards_translation_id");

            entity.HasIndex(e => e.UserId, "ix_accommodation_wards_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.FloorId).HasColumnName("floor_id");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Floor).WithMany(p => p.AccommodationWards)
                .HasForeignKey(d => d.FloorId)
                .HasConstraintName("fk_accommodation_wards_accommodation_floors_floor_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccommodationWards)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_accommodation_wards_tenant_tenant_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AccommodationWards)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_accommodation_wards_translations_translation_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccommodationWards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_accommodation_wards_users_user_id");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_addresses");

            entity.ToTable("addresses");

            entity.HasIndex(e => e.CountryId, "ix_addresses_country_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.District).HasColumnName("district");
            entity.Property(e => e.PostCode).HasColumnName("post_code");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.Town).HasColumnName("town");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_addresses_ehdsi_country_country_id");
        });

        modelBuilder.Entity<AddressDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_address_data");

            entity.ToTable("address_data");

            entity.HasIndex(e => e.CountryId, "ix_address_data_country_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(50)
                .HasColumnName("apartment_number");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.District)
                .HasMaxLength(50)
                .HasColumnName("district");
            entity.Property(e => e.PostCode)
                .HasMaxLength(50)
                .HasColumnName("post_code");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.StreetNumber)
                .HasMaxLength(50)
                .HasColumnName("street_number");
            entity.Property(e => e.Town)
                .HasMaxLength(50)
                .HasColumnName("town");

            entity.HasOne(d => d.Country).WithMany(p => p.AddressData)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_address_data_ehdsi_country_country_id");
        });

        modelBuilder.Entity<AdmissionReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_admission_reasons");

            entity.ToTable("admission_reasons");

            entity.HasIndex(e => e.TranslationId, "ix_admission_reasons_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.AdmissionReasons)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_admission_reasons_translations_translation_id");

            entity.HasMany(d => d.Tenants).WithMany(p => p.AdmissionReasons)
                .UsingEntity<Dictionary<string, object>>(
                    "AdmissionReasonTenant",
                    r => r.HasOne<Tenant>().WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_admission_reason_tenants_tenant_tenant_id"),
                    l => l.HasOne<AdmissionReason>().WithMany()
                        .HasForeignKey("AdmissionReasonId")
                        .HasConstraintName("fk_admission_reason_tenants_admission_reasons_admission_reason"),
                    j =>
                    {
                        j.HasKey("AdmissionReasonId", "TenantId").HasName("pk_admission_reason_tenants");
                        j.ToTable("admission_reason_tenants");
                        j.HasIndex(new[] { "TenantId" }, "ix_admission_reason_tenants_tenant_id");
                        j.IndexerProperty<int>("AdmissionReasonId").HasColumnName("admission_reason_id");
                        j.IndexerProperty<int>("TenantId").HasColumnName("tenant_id");
                    });
        });

        modelBuilder.Entity<AllergyCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_allergy_categories");

            entity.ToTable("allergy_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Table).HasColumnName("table");
        });

        modelBuilder.Entity<AllergyDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_allergy_data");

            entity.ToTable("allergy_data");

            entity.HasIndex(e => e.AllergyCategoryId, "ix_allergy_data_allergy_category_id");

            entity.HasIndex(e => e.AllergyId, "ix_allergy_data_allergy_id");

            entity.HasIndex(e => e.AllergyStatusId, "ix_allergy_data_allergy_status_id");

            entity.HasIndex(e => e.CriticalityId, "ix_allergy_data_criticality_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_allergy_data_episode_care_id");

            entity.HasIndex(e => e.EventTypeId, "ix_allergy_data_event_type_id");

            entity.HasIndex(e => e.PatientId, "ix_allergy_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_allergy_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_allergy_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_allergy_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllergyCategoryId).HasColumnName("allergy_category_id");
            entity.Property(e => e.AllergyId).HasColumnName("allergy_id");
            entity.Property(e => e.AllergyStatusId).HasColumnName("allergy_status_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.CriticalityId).HasColumnName("criticality_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.EventTypeId).HasColumnName("event_type_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ResolutionDate).HasColumnName("resolution_date");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.AllergyCategory).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.AllergyCategoryId)
                .HasConstraintName("fk_allergy_data_allergy_categories_allergy_category_id");

            entity.HasOne(d => d.Allergy).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.AllergyId)
                .HasConstraintName("fk_allergy_data_ehdsi_allergies_custom_allergy_id");

            entity.HasOne(d => d.AllergyStatus).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.AllergyStatusId)
                .HasConstraintName("fk_allergy_data_ehdsi_allergy_status_allergy_status_id");

            entity.HasOne(d => d.Criticality).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.CriticalityId)
                .HasConstraintName("fk_allergy_data_ehdsi_criticality_criticality_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_allergy_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.EventType).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.EventTypeId)
                .HasConstraintName("fk_allergy_data_ehdsi_adverse_event_type_event_type_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_allergy_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_allergy_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_allergy_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.AllergyData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_allergy_data_visits_visit_id");
        });

        modelBuilder.Entity<AllergyReaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_allergy_reactions");

            entity.ToTable("allergy_reactions");

            entity.HasIndex(e => e.AllergyId, "ix_allergy_reactions_allergy_id");

            entity.HasIndex(e => e.CertaintyId, "ix_allergy_reactions_certainty_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_allergy_reactions_episode_care_id");

            entity.HasIndex(e => e.ManifestationId, "ix_allergy_reactions_manifestation_id");

            entity.HasIndex(e => e.SeverityId, "ix_allergy_reactions_severity_id");

            entity.HasIndex(e => e.VisitId, "ix_allergy_reactions_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllergyId).HasColumnName("allergy_id");
            entity.Property(e => e.CertaintyId).HasColumnName("certainty_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.ManifestationId).HasColumnName("manifestation_id");
            entity.Property(e => e.OnSetDate).HasColumnName("on_set_date");
            entity.Property(e => e.SeverityId).HasColumnName("severity_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Allergy).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.AllergyId)
                .HasConstraintName("fk_allergy_reactions_allergy_data_allergy_id");

            entity.HasOne(d => d.Certainty).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.CertaintyId)
                .HasConstraintName("fk_allergy_reactions_ehdsi_allergy_certainty_certainty_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_allergy_reactions_episode_cares_episode_care_id");

            entity.HasOne(d => d.Manifestation).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.ManifestationId)
                .HasConstraintName("fk_allergy_reactions_ehdsi_reaction_allergy_manifestation_id");

            entity.HasOne(d => d.Severity).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.SeverityId)
                .HasConstraintName("fk_allergy_reactions_ehdsi_severity_severity_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.AllergyReactions)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_allergy_reactions_visits_visit_id");
        });

        modelBuilder.Entity<AllergyUnknownDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_allergy_unknown_data");

            entity.ToTable("allergy_unknown_data");

            entity.HasIndex(e => e.AllergyId, "ix_allergy_unknown_data_allergy_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_allergy_unknown_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_allergy_unknown_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_allergy_unknown_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_allergy_unknown_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_allergy_unknown_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllergyId).HasColumnName("allergy_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Allergy).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.AllergyId)
                .HasConstraintName("fk_allergy_unknown_data_ehdsi_absent_or_unknown_allergy_allerg");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_allergy_unknown_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_allergy_unknown_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_allergy_unknown_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_allergy_unknown_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.AllergyUnknownData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_allergy_unknown_data_visits_visit_id");
        });

        modelBuilder.Entity<Answer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_answer");

            entity.ToTable("answer", "quest");

            entity.HasIndex(e => e.AnswerQuestionnaireId, "ix_answer_answer_questionnaire_id");

            entity.HasIndex(e => e.QuestionTemplateId, "ix_answer_question_template_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerQuestionnaireId).HasColumnName("answer_questionnaire_id");
            entity.Property(e => e.QuestionTemplateId).HasColumnName("question_template_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.AnswerQuestionnaire).WithMany(p => p.Answers)
                .HasForeignKey(d => d.AnswerQuestionnaireId)
                .HasConstraintName("fk_answer_answer_questionnaires_answer_questionnaire_id");

            entity.HasOne(d => d.QuestionTemplate).WithMany(p => p.Answers)
                .HasForeignKey(d => d.QuestionTemplateId)
                .HasConstraintName("fk_answer_question_templates_question_template_id");
        });

        modelBuilder.Entity<AnswerQuestionnaire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_answer_questionnaires");

            entity.ToTable("answer_questionnaires", "quest");

            entity.HasIndex(e => e.QuestionnaireTemplateId, "ix_answer_questionnaires_questionnaire_template_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDateUtc).HasColumnName("created_date_utc");
            entity.Property(e => e.QuestionnaireTemplateId).HasColumnName("questionnaire_template_id");
            entity.Property(e => e.UpdatedTimeUtc).HasColumnName("updated_time_utc");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.QuestionnaireTemplate).WithMany(p => p.AnswerQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireTemplateId)
                .HasConstraintName("fk_answer_questionnaires_questionnaire_templates_questionnaire");
        });

        modelBuilder.Entity<AppointmentDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_data");

            entity.ToTable("appointment_data");

            entity.HasIndex(e => e.AppointmentStatusId, "ix_appointment_data_appointment_status_id");

            entity.HasIndex(e => e.RecurrentTypeId, "ix_appointment_data_recurrent_type_id");

            entity.HasIndex(e => e.TenantId, "ix_appointment_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_appointment_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentStatusId).HasColumnName("appointment_status_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.RecurrenceOccurrences).HasColumnName("recurrence_occurrences");
            entity.Property(e => e.RecurrentTypeId).HasColumnName("recurrent_type_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AppointmentStatus).WithMany(p => p.AppointmentData)
                .HasForeignKey(d => d.AppointmentStatusId)
                .HasConstraintName("fk_appointment_data_appointment_status_appointment_status_id");

            entity.HasOne(d => d.RecurrentType).WithMany(p => p.AppointmentData)
                .HasForeignKey(d => d.RecurrentTypeId)
                .HasConstraintName("fk_appointment_data_appointment_recurrent_type_recurrent_type_");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AppointmentData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_appointment_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AppointmentData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_appointment_data_users_user_id");
        });

        modelBuilder.Entity<AppointmentParticipantActorDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_participant_actor_data");

            entity.ToTable("appointment_participant_actor_data");

            entity.HasIndex(e => e.PatientId, "ix_appointment_participant_actor_data_patient_id");

            entity.HasIndex(e => e.UserId, "ix_appointment_participant_actor_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.AppointmentParticipantActorData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_appointment_participant_actor_data_patients_patient_id");

            entity.HasOne(d => d.User).WithMany(p => p.AppointmentParticipantActorData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_appointment_participant_actor_data_users_user_id");
        });

        modelBuilder.Entity<AppointmentParticipantDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_participant_data");

            entity.ToTable("appointment_participant_data");

            entity.HasIndex(e => e.ActorId, "ix_appointment_participant_data_actor_id");

            entity.HasIndex(e => e.AppointmentDataId, "ix_appointment_participant_data_appointment_data_id");

            entity.HasIndex(e => e.ParticipantStatusId, "ix_appointment_participant_data_participant_status_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActorId).HasColumnName("actor_id");
            entity.Property(e => e.AppointmentDataId).HasColumnName("appointment_data_id");
            entity.Property(e => e.ParticipantStatusId).HasColumnName("participant_status_id");
            entity.Property(e => e.Required).HasColumnName("required");

            entity.HasOne(d => d.Actor).WithMany(p => p.AppointmentParticipantData)
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("fk_appointment_participant_data_appointment_participant_actor_");

            entity.HasOne(d => d.AppointmentData).WithMany(p => p.AppointmentParticipantData)
                .HasForeignKey(d => d.AppointmentDataId)
                .HasConstraintName("fk_appointment_participant_data_appointment_data_appointment_d");

            entity.HasOne(d => d.ParticipantStatus).WithMany(p => p.AppointmentParticipantData)
                .HasForeignKey(d => d.ParticipantStatusId)
                .HasConstraintName("fk_appointment_participant_data_appointment_status_participant");
        });

        modelBuilder.Entity<AppointmentPatientDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_patient_data");

            entity.ToTable("appointment_patient_data");

            entity.HasIndex(e => e.AppointmentStatusId, "ix_appointment_patient_data_appointment_status_id");

            entity.HasIndex(e => e.DoctorId, "ix_appointment_patient_data_doctor_id");

            entity.HasIndex(e => e.PatientId, "ix_appointment_patient_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_appointment_patient_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_appointment_patient_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentStatusId).HasColumnName("appointment_status_id");
            entity.Property(e => e.Comments)
                .HasMaxLength(300)
                .HasColumnName("comments");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.IsRejected).HasColumnName("is_rejected");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AppointmentStatus).WithMany(p => p.AppointmentPatientData)
                .HasForeignKey(d => d.AppointmentStatusId)
                .HasConstraintName("fk_appointment_patient_data_appointment_status_appointment_sta");

            entity.HasOne(d => d.Doctor).WithMany(p => p.AppointmentPatientDatumDoctors)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("fk_appointment_patient_data_users_doctor_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.AppointmentPatientData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_appointment_patient_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AppointmentPatientData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_appointment_patient_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.AppointmentPatientDatumUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_appointment_patient_data_users_user_id");
        });

        modelBuilder.Entity<AppointmentRecurrentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_recurrent_type");

            entity.ToTable("appointment_recurrent_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<AppointmentSlotDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_slot_data");

            entity.ToTable("appointment_slot_data");

            entity.HasIndex(e => e.AppointmentDataId, "ix_appointment_slot_data_appointment_data_id");

            entity.HasIndex(e => e.SlotStatusId, "ix_appointment_slot_data_slot_status_id");

            entity.HasIndex(e => e.UserId, "ix_appointment_slot_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentDataId).HasColumnName("appointment_data_id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.End).HasColumnName("end");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Overbooked).HasColumnName("overbooked");
            entity.Property(e => e.SlotStatusId).HasColumnName("slot_status_id");
            entity.Property(e => e.Start).HasColumnName("start");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AppointmentData).WithMany(p => p.AppointmentSlotData)
                .HasForeignKey(d => d.AppointmentDataId)
                .HasConstraintName("fk_appointment_slot_data_appointment_data_appointment_data_id");

            entity.HasOne(d => d.SlotStatus).WithMany(p => p.AppointmentSlotData)
                .HasForeignKey(d => d.SlotStatusId)
                .HasConstraintName("fk_appointment_slot_data_appointment_status_slot_status_id");

            entity.HasOne(d => d.User).WithMany(p => p.AppointmentSlotData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_appointment_slot_data_users_user_id");
        });

        modelBuilder.Entity<AppointmentStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_status");

            entity.ToTable("appointment_status");

            entity.HasIndex(e => e.AppointmentStatusTypeId, "ix_appointment_status_appointment_status_type_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppointmentStatusTypeId).HasColumnName("appointment_status_type_id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Display).HasColumnName("display");

            entity.HasOne(d => d.AppointmentStatusType).WithMany(p => p.AppointmentStatuses)
                .HasForeignKey(d => d.AppointmentStatusTypeId)
                .HasConstraintName("fk_appointment_status_appointment_status_type_appointment_stat");
        });

        modelBuilder.Entity<AppointmentStatusType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_appointment_status_type");

            entity.ToTable("appointment_status_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<ArterialBloodGasDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_arterial_blood_gas_data");

            entity.ToTable("arterial_blood_gas_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_arterial_blood_gas_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_arterial_blood_gas_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_arterial_blood_gas_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_arterial_blood_gas_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_arterial_blood_gas_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.Hco3).HasColumnName("hco3");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.Paco2).HasColumnName("paco2");
            entity.Property(e => e.Pao2).HasColumnName("pao2");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Ph).HasColumnName("ph");
            entity.Property(e => e.Sao2).HasColumnName("sao2");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ArterialBloodGasData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_arterial_blood_gas_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ArterialBloodGasData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_arterial_blood_gas_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ArterialBloodGasData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_arterial_blood_gas_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ArterialBloodGasData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_arterial_blood_gas_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ArterialBloodGasData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_arterial_blood_gas_data_visits_visit_id");
        });

        modelBuilder.Entity<CapnographyDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_capnography_data");

            entity.ToTable("capnography_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_capnography_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_capnography_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_capnography_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_capnography_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_capnography_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EndTidal).HasColumnName("end_tidal");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.FractionInhaledOxygen).HasColumnName("fraction_inhaled_oxygen");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PositiveEndExpiratoryPressure).HasColumnName("positive_end_expiratory_pressure");
            entity.Property(e => e.PressureInhaledOxygen).HasColumnName("pressure_inhaled_oxygen");
            entity.Property(e => e.RespiratoryRate).HasColumnName("respiratory_rate");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TidalVolume).HasColumnName("tidal_volume");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.CapnographyData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_capnography_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.CapnographyData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_capnography_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CapnographyData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_capnography_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.CapnographyData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_capnography_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.CapnographyData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_capnography_data_visits_visit_id");
        });

        modelBuilder.Entity<CarePlanDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_care_plan_data");

            entity.ToTable("care_plan_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_care_plan_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_care_plan_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_care_plan_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_care_plan_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_care_plan_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.CarePlanData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_care_plan_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.CarePlanData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_care_plan_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CarePlanData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_care_plan_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.CarePlanData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_care_plan_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.CarePlanData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_care_plan_data_visits_visit_id");
        });

        modelBuilder.Entity<ComorbidityDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_comorbidity_data");

            entity.ToTable("comorbidity_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_comorbidity_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_comorbidity_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_comorbidity_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_comorbidity_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_comorbidity_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.Iqr).HasColumnName("iqr");
            entity.Property(e => e.IsCopd).HasColumnName("is_copd");
            entity.Property(e => e.IsDiabetesMellitus).HasColumnName("is_diabetes_mellitus");
            entity.Property(e => e.IsHeartDisease).HasColumnName("is_heart_disease");
            entity.Property(e => e.IsHypertension).HasColumnName("is_hypertension");
            entity.Property(e => e.IsImmunosuppression).HasColumnName("is_immunosuppression");
            entity.Property(e => e.IsMalignancy).HasColumnName("is_malignancy");
            entity.Property(e => e.IsNoComorbidities).HasColumnName("is_no_comorbidities");
            entity.Property(e => e.IsRespiratoryDisease).HasColumnName("is_respiratory_disease");
            entity.Property(e => e.IsStroke).HasColumnName("is_stroke");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ComorbidityData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_comorbidity_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ComorbidityData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_comorbidity_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ComorbidityData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_comorbidity_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ComorbidityData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_comorbidity_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ComorbidityData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_comorbidity_data_visits_visit_id");
        });

        modelBuilder.Entity<Complication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_complication");

            entity.ToTable("complication");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<ComplicationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_complication_data");

            entity.ToTable("complication_data");

            entity.HasIndex(e => e.ComplicationId, "ix_complication_data_complication_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_complication_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_complication_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_complication_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_complication_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_complication_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComplicationId).HasColumnName("complication_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsChecked).HasColumnName("is_checked");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Complication).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.ComplicationId)
                .HasConstraintName("fk_complication_data_complication_complication_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_complication_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_complication_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_complication_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_complication_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ComplicationData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_complication_data_visits_visit_id");
        });

        modelBuilder.Entity<Definition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_definitions");

            entity.ToTable("definitions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.FieldDescription).HasColumnName("field_description");
            entity.Property(e => e.FieldExamples).HasColumnName("field_examples");
            entity.Property(e => e.FieldName).HasColumnName("field_name");
            entity.Property(e => e.FieldTable).HasColumnName("field_table");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_departments");

            entity.ToTable("departments");

            entity.HasIndex(e => e.UserId, "ix_departments_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Departments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_departments_users_user_id");
        });

        modelBuilder.Entity<DietType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_diet_type");

            entity.ToTable("diet_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.OtherDisplay).HasColumnName("other_display");
            entity.Property(e => e.System).HasColumnName("system");
        });

        modelBuilder.Entity<DietaryHabitsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dietary_habits_data");

            entity.ToTable("dietary_habits_data");

            entity.HasIndex(e => e.CustomTimingUnitId, "ix_dietary_habits_data_custom_timing_unit_id");

            entity.HasIndex(e => e.DietTypeId, "ix_dietary_habits_data_diet_type_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_dietary_habits_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_dietary_habits_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_dietary_habits_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_dietary_habits_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_dietary_habits_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.CustomTimingUnitId).HasColumnName("custom_timing_unit_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DietTypeId).HasColumnName("diet_type_id");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UnitAmount).HasColumnName("unit_amount");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.CustomTimingUnit).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.CustomTimingUnitId)
                .HasConstraintName("fk_dietary_habits_data_master_timing_unit_custom_timing_unit_id");

            entity.HasOne(d => d.DietType).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.DietTypeId)
                .HasConstraintName("fk_dietary_habits_data_diet_type_diet_type_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_dietary_habits_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_dietary_habits_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_dietary_habits_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_dietary_habits_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.DietaryHabitsData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_dietary_habits_data_visits_visit_id");
        });

        modelBuilder.Entity<DischargeDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_discharge_data");

            entity.ToTable("discharge_data");

            entity.HasIndex(e => e.DischargeSituationId, "ix_discharge_data_discharge_situation_id");

            entity.HasIndex(e => e.DischargeTypeId, "ix_discharge_data_discharge_type_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_discharge_data_episode_care_id");

            entity.HasIndex(e => e.TenantId, "ix_discharge_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_discharge_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DischargeSituationId).HasColumnName("discharge_situation_id");
            entity.Property(e => e.DischargeSituationNotes).HasColumnName("discharge_situation_notes");
            entity.Property(e => e.DischargeTypeId).HasColumnName("discharge_type_id");
            entity.Property(e => e.DischargeTypeNotes).HasColumnName("discharge_type_notes");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.DischargeSituation).WithMany(p => p.DischargeData)
                .HasForeignKey(d => d.DischargeSituationId)
                .HasConstraintName("fk_discharge_data_discharge_situations_discharge_situation_id");

            entity.HasOne(d => d.DischargeType).WithMany(p => p.DischargeData)
                .HasForeignKey(d => d.DischargeTypeId)
                .HasConstraintName("fk_discharge_data_discharge_types_discharge_type_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.DischargeData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_discharge_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.DischargeData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_discharge_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.DischargeData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_discharge_data_users_user_id");
        });

        modelBuilder.Entity<DischargeSituation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_discharge_situations");

            entity.ToTable("discharge_situations");

            entity.HasIndex(e => e.TranslationId, "ix_discharge_situations_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.DischargeSituations)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_discharge_situations_translations_translation_id");
        });

        modelBuilder.Entity<DischargeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_discharge_types");

            entity.ToTable("discharge_types");

            entity.HasIndex(e => e.TranslationId, "ix_discharge_types_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.DischargeTypes)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_discharge_types_translations_translation_id");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_document_types");

            entity.ToTable("document_types");

            entity.HasIndex(e => e.TranslationId, "ix_document_types_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.DocumentTypes)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_document_types_translations_translation_id");
        });

        modelBuilder.Entity<EhdsiAbsentOrUnknownAllergy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_absent_or_unknown_allergy");

            entity.ToTable("ehdsi_absent_or_unknown_allergy");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_absent_or_unknown_allergy_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAbsentOrUnknownAllergies)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_absent_or_unknown_allergy_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAbsentOrUnknownDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_absent_or_unknown_device");

            entity.ToTable("ehdsi_absent_or_unknown_device");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_absent_or_unknown_device_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAbsentOrUnknownDevices)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_absent_or_unknown_device_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAbsentOrUnknownMedication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_absent_or_unknown_medication");

            entity.ToTable("ehdsi_absent_or_unknown_medication");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_absent_or_unknown_medication_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAbsentOrUnknownMedications)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_absent_or_unknown_medication_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAbsentOrUnknownProblem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_absent_or_unknown_problem");

            entity.ToTable("ehdsi_absent_or_unknown_problem");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_absent_or_unknown_problem_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAbsentOrUnknownProblems)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_absent_or_unknown_problem_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAbsentOrUnknownProcedure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_absent_or_unknown_procedure");

            entity.ToTable("ehdsi_absent_or_unknown_procedure");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_absent_or_unknown_procedure_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAbsentOrUnknownProcedures)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_absent_or_unknown_procedure_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiActiveIngredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_active_ingredient");

            entity.ToTable("ehdsi_active_ingredient");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_active_ingredient_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiActiveIngredients)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_active_ingredient_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAdministrativeGender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_administrative_gender");

            entity.ToTable("ehdsi_administrative_gender");

            entity.HasIndex(e => e.TranslationId, "ix_ehdsi_administrative_gender_translation_id");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_administrative_gender_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.EhdsiAdministrativeGenders)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_ehdsi_administrative_gender_translations_translation_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAdministrativeGenders)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_administrative_gender_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAdverseEventType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_adverse_event_type");

            entity.ToTable("ehdsi_adverse_event_type");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_adverse_event_type_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAdverseEventTypes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_adverse_event_type_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAllergenNoDrug>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_allergen_no_drug");

            entity.ToTable("ehdsi_allergen_no_drug");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_allergen_no_drug_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAllergenNoDrugs)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_allergen_no_drug_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAllergiesCustom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_allergies_custom");

            entity.ToTable("ehdsi_allergies_custom");

            entity.HasIndex(e => e.AllergyCategoryId, "ix_ehdsi_allergies_custom_allergy_category_id");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_allergies_custom_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllergyCategoryId).HasColumnName("allergy_category_id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.AllergyCategory).WithMany(p => p.EhdsiAllergiesCustoms)
                .HasForeignKey(d => d.AllergyCategoryId)
                .HasConstraintName("fk_ehdsi_allergies_custom_allergy_categories_allergy_category_");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAllergiesCustoms)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_allergies_custom_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAllergyCertainty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_allergy_certainty");

            entity.ToTable("ehdsi_allergy_certainty");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_allergy_certainty_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAllergyCertainties)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_allergy_certainty_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiAllergyStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_allergy_status");

            entity.ToTable("ehdsi_allergy_status");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_allergy_status_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiAllergyStatuses)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_allergy_status_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiBloodGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_blood_group");

            entity.ToTable("ehdsi_blood_group");

            entity.HasIndex(e => e.TranslationId, "ix_ehdsi_blood_group_translation_id");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_blood_group_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.EhdsiBloodGroups)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_ehdsi_blood_group_translations_translation_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiBloodGroups)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_blood_group_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiBloodPressure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_blood_pressure");

            entity.ToTable("ehdsi_blood_pressure");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_blood_pressure_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiBloodPressures)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_blood_pressure_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiCertainty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_certainty");

            entity.ToTable("ehdsi_certainty");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_certainty_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiCertainties)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_certainty_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiCodeProb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_code_prob");

            entity.ToTable("ehdsi_code_prob");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_code_prob_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiCodeProbs)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_code_prob_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiConfidentiality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_confidentiality");

            entity.ToTable("ehdsi_confidentiality");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_confidentiality_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiConfidentialities)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_confidentiality_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_country");

            entity.ToTable("ehdsi_country");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_country_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiCountries)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_country_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiCriticality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_criticality");

            entity.ToTable("ehdsi_criticality");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_criticality_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiCriticalities)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_criticality_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiCurrentPregnancyStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_current_pregnancy_status");

            entity.ToTable("ehdsi_current_pregnancy_status");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_current_pregnancy_status_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiCurrentPregnancyStatuses)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_current_pregnancy_status_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiDisplayLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_display_label");

            entity.ToTable("ehdsi_display_label");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_display_label_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiDisplayLabels)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_display_label_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiDocumentCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_document_code");

            entity.ToTable("ehdsi_document_code");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_document_code_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiDocumentCodes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_document_code_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiDoseForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_dose_form");

            entity.ToTable("ehdsi_dose_form");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_dose_form_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiDoseForms)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_dose_form_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiHealthcareProfessionalRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_healthcare_professional_role");

            entity.ToTable("ehdsi_healthcare_professional_role");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_healthcare_professional_role_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiHealthcareProfessionalRoles)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_healthcare_professional_role_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiHospitalDischargeReportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_hospital_discharge_report_type");

            entity.ToTable("ehdsi_hospital_discharge_report_type");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_hospital_discharge_report_type_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiHospitalDischargeReportTypes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_hospital_discharge_report_type_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiIllnessandDisorder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_illnessand_disorder");

            entity.ToTable("ehdsi_illnessand_disorder");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_illnessand_disorder_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiIllnessandDisorders)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_illnessand_disorder_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiLaboratoryReportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_laboratory_report_type");

            entity.ToTable("ehdsi_laboratory_report_type");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_laboratory_report_type_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiLaboratoryReportTypes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_laboratory_report_type_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_language");

            entity.ToTable("ehdsi_language");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_language_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiLanguages)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_language_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiMedicalDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_medical_device");

            entity.ToTable("ehdsi_medical_device");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_medical_device_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiMedicalDevices)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_medical_device_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiMedicalImagesType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_medical_images_type");

            entity.ToTable("ehdsi_medical_images_type");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_medical_images_type_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiMedicalImagesTypes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_medical_images_type_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiMedicalImagingReportType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_medical_imaging_report_type");

            entity.ToTable("ehdsi_medical_imaging_report_type");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_medical_imaging_report_type_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiMedicalImagingReportTypes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_medical_imaging_report_type_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiNullFlavor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_null_flavor");

            entity.ToTable("ehdsi_null_flavor");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_null_flavor_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiNullFlavors)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_null_flavor_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiOutcomeOfPregnancy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_outcome_of_pregnancy");

            entity.ToTable("ehdsi_outcome_of_pregnancy");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_outcome_of_pregnancy_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiOutcomeOfPregnancies)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_outcome_of_pregnancy_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_package");

            entity.ToTable("ehdsi_package");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_package_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiPackages)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_package_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiPersonalRelationship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_personal_relationship");

            entity.ToTable("ehdsi_personal_relationship");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_personal_relationship_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiPersonalRelationships)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_personal_relationship_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiPregnancyInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_pregnancy_information");

            entity.ToTable("ehdsi_pregnancy_information");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_pregnancy_information_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiPregnancyInformations)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_pregnancy_information_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiProcedure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_procedure");

            entity.ToTable("ehdsi_procedure");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_procedure_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiProcedures)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_procedure_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiQuantityUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_quantity_unit");

            entity.ToTable("ehdsi_quantity_unit");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_quantity_unit_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiQuantityUnits)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_quantity_unit_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiRareDisease>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_rare_disease");

            entity.ToTable("ehdsi_rare_disease");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_rare_disease_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiRareDiseases)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_rare_disease_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiReactionAllergy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_reaction_allergy");

            entity.ToTable("ehdsi_reaction_allergy");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_reaction_allergy_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiReactionAllergies)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_reaction_allergy_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiResolutionOutcome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_resolution_outcome");

            entity.ToTable("ehdsi_resolution_outcome");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_resolution_outcome_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiResolutionOutcomes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_resolution_outcome_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiRoleClass>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_role_class");

            entity.ToTable("ehdsi_role_class");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_role_class_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiRoleClasses)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_role_class_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiRouteofAdministration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_routeof_administration");

            entity.ToTable("ehdsi_routeof_administration");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_routeof_administration_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiRouteofAdministrations)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_routeof_administration_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_section");

            entity.ToTable("ehdsi_section");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_section_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiSections)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_section_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiSeverity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_severity");

            entity.ToTable("ehdsi_severity");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_severity_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiSeverities)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_severity_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiSocialHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_social_history");

            entity.ToTable("ehdsi_social_history");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_social_history_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiSocialHistories)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_social_history_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiStatusCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_status_code");

            entity.ToTable("ehdsi_status_code");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_status_code_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiStatusCodes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_status_code_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiSubstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_substance");

            entity.ToTable("ehdsi_substance");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_substance_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiSubstances)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_substance_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiSubstitutionCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_substitution_code");

            entity.ToTable("ehdsi_substitution_code");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_substitution_code_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiSubstitutionCodes)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_substitution_code_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiTelecomAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_telecom_address");

            entity.ToTable("ehdsi_telecom_address");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_telecom_address_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiTelecomAddresses)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_telecom_address_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiTimingEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_timing_event");

            entity.ToTable("ehdsi_timing_event");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_timing_event_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiTimingEvents)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_timing_event_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_unit");

            entity.ToTable("ehdsi_unit");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_unit_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiUnits)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_unit_value_set_value_set_id");
        });

        modelBuilder.Entity<EhdsiVaccine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ehdsi_vaccine");

            entity.ToTable("ehdsi_vaccine");

            entity.HasIndex(e => e.ValueSetId, "ix_ehdsi_vaccine_value_set_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeSystemId).HasColumnName("code_system_id");
            entity.Property(e => e.CodeSystemVersion).HasColumnName("code_system_version");
            entity.Property(e => e.ConceptCode).HasColumnName("concept_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.MvcVersion).HasColumnName("mvc_version");
            entity.Property(e => e.ValueSetId).HasColumnName("value_set_id");

            entity.HasOne(d => d.ValueSet).WithMany(p => p.EhdsiVaccines)
                .HasForeignKey(d => d.ValueSetId)
                .HasConstraintName("fk_ehdsi_vaccine_value_set_value_set_id");
        });

        modelBuilder.Entity<EpisodeCare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_episode_cares");

            entity.ToTable("episode_cares");

            entity.HasIndex(e => e.PatientId, "ix_episode_cares_patient_id");

            entity.HasIndex(e => e.PotentialDiagnosisId, "ix_episode_cares_potential_diagnosis_id");

            entity.HasIndex(e => e.StatusId, "ix_episode_cares_status_id");

            entity.HasIndex(e => e.TenantId, "ix_episode_cares_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_episode_cares_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActivationDate).HasColumnName("activation_date");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsHospitalized).HasColumnName("is_hospitalized");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PotentialDiagnosisId).HasColumnName("potential_diagnosis_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.EpisodeCares)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_episode_cares_patients_patient_id");

            entity.HasOne(d => d.PotentialDiagnosis).WithMany(p => p.EpisodeCares)
                .HasForeignKey(d => d.PotentialDiagnosisId)
                .HasConstraintName("fk_episode_cares_ehdsi_illnessand_disorder_potential_diagnosis");

            entity.HasOne(d => d.Status).WithMany(p => p.EpisodeCares)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("fk_episode_cares_status_status_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EpisodeCares)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_episode_cares_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.EpisodeCares)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_episode_cares_users_user_id");
        });

        modelBuilder.Entity<Etiology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_etiology");

            entity.ToTable("etiology");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<EtiologyDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_etiology_data");

            entity.ToTable("etiology_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_etiology_data_episode_care_id");

            entity.HasIndex(e => e.EtiologyId, "ix_etiology_data_etiology_id");

            entity.HasIndex(e => e.PatientId, "ix_etiology_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_etiology_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_etiology_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_etiology_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.EtiologyId).HasColumnName("etiology_id");
            entity.Property(e => e.IsChecked).HasColumnName("is_checked");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_etiology_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Etiology).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.EtiologyId)
                .HasConstraintName("fk_etiology_data_etiology_etiology_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_etiology_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_etiology_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_etiology_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.EtiologyData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_etiology_data_visits_visit_id");
        });

        modelBuilder.Entity<ExternalDoctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_external_doctors");

            entity.ToTable("external_doctors");

            entity.HasIndex(e => e.AddressDataId, "ix_external_doctors_address_data_id");

            entity.HasIndex(e => e.TenantId, "ix_external_doctors_tenant_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressDataId).HasColumnName("address_data_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.HomeNumber)
                .HasMaxLength(50)
                .HasColumnName("home_number");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .HasColumnName("registration_number");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.AddressData).WithMany(p => p.ExternalDoctors)
                .HasForeignKey(d => d.AddressDataId)
                .HasConstraintName("fk_external_doctors_address_data_address_data_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ExternalDoctors)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_external_doctors_tenant_tenant_id");

            entity.HasMany(d => d.ExternalDoctorSpecialties).WithMany(p => p.ExternalDoctors)
                .UsingEntity<Dictionary<string, object>>(
                    "ExternalDoctorsSpecialtiesLink",
                    r => r.HasOne<ExternalDoctorSpecialty>().WithMany()
                        .HasForeignKey("ExternalDoctorSpecialtyId")
                        .HasConstraintName("fk_external_doctors_specialties_link_external_doctor_specialti"),
                    l => l.HasOne<ExternalDoctor>().WithMany()
                        .HasForeignKey("ExternalDoctorId")
                        .HasConstraintName("fk_external_doctors_specialties_link_external_doctors_external"),
                    j =>
                    {
                        j.HasKey("ExternalDoctorId", "ExternalDoctorSpecialtyId").HasName("pk_external_doctors_specialties_link");
                        j.ToTable("external_doctors_specialties_link");
                        j.HasIndex(new[] { "ExternalDoctorSpecialtyId" }, "ix_external_doctors_specialties_link_external_doctor_specialty");
                        j.IndexerProperty<int>("ExternalDoctorId").HasColumnName("external_doctor_id");
                        j.IndexerProperty<int>("ExternalDoctorSpecialtyId").HasColumnName("external_doctor_specialty_id");
                    });
        });

        modelBuilder.Entity<ExternalDoctorSpecialty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_external_doctor_specialties");

            entity.ToTable("external_doctor_specialties");

            entity.HasIndex(e => e.TranslationId, "ix_external_doctor_specialties_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasDefaultValueSql("''::text")
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("''::text")
                .HasColumnName("description");
            entity.Property(e => e.GroupHead)
                .HasDefaultValueSql("''::text")
                .HasColumnName("group_head");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.ExternalDoctorSpecialties)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_external_doctor_specialties_translations_translation_id");
        });

        modelBuilder.Entity<ExternalDoctorsCyma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_external_doctors_cyma");

            entity.ToTable("external_doctors_cyma");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.Address1).HasColumnName("address1");
            entity.Property(e => e.Address2).HasColumnName("address2");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.GesyNumber).HasColumnName("gesy_number");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LandLinePhone).HasColumnName("land_line_phone");
            entity.Property(e => e.MobilePhone).HasColumnName("mobile_phone");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.RegistrationNumber).HasColumnName("registration_number");
            entity.Property(e => e.SocialInsurance).HasColumnName("social_insurance");
            entity.Property(e => e.Specialty1definitionId).HasColumnName("specialty1definition_id");
            entity.Property(e => e.Specialty2definitionId).HasColumnName("specialty2definition_id");
            entity.Property(e => e.Specialty3definitionId).HasColumnName("specialty3definition_id");
            entity.Property(e => e.StatusDefinitionId).HasColumnName("status_definition_id");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.UpdateDate).HasColumnName("update_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<FoodDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_food_data");

            entity.ToTable("food_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_food_data_episode_care_id");

            entity.HasIndex(e => e.FoodTypeId, "ix_food_data_food_type_id");

            entity.HasIndex(e => e.PatientId, "ix_food_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_food_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_food_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_food_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.FoodTypeId).HasColumnName("food_type_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PortionEatenPercentage).HasColumnName("portion_eaten_percentage");
            entity.Property(e => e.PortionSize).HasColumnName("portion_size");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_food_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.FoodType).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.FoodTypeId)
                .HasConstraintName("fk_food_data_food_type_food_type_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_food_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_food_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_food_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.FoodData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_food_data_visits_visit_id");
        });

        modelBuilder.Entity<FoodType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_food_type");

            entity.ToTable("food_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Display).HasColumnName("display");
            entity.Property(e => e.OtherDisplay).HasColumnName("other_display");
            entity.Property(e => e.System).HasColumnName("system");
        });

        modelBuilder.Entity<GlasgowDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_glasgow_data");

            entity.ToTable("glasgow_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_glasgow_data_episode_care_id");

            entity.HasIndex(e => e.EyeOpeningId, "ix_glasgow_data_eye_opening_id");

            entity.HasIndex(e => e.MotorResponseId, "ix_glasgow_data_motor_response_id");

            entity.HasIndex(e => e.PatientId, "ix_glasgow_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_glasgow_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_glasgow_data_user_id");

            entity.HasIndex(e => e.VerbalResponseId, "ix_glasgow_data_verbal_response_id");

            entity.HasIndex(e => e.VisitId, "ix_glasgow_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.EyeOpeningId).HasColumnName("eye_opening_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MotorResponseId).HasColumnName("motor_response_id");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TotalScore).HasColumnName("total_score");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VerbalResponseId).HasColumnName("verbal_response_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_glasgow_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.EyeOpening).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.EyeOpeningId)
                .HasConstraintName("fk_glasgow_data_glasgow_eye_opening_eye_opening_id");

            entity.HasOne(d => d.MotorResponse).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.MotorResponseId)
                .HasConstraintName("fk_glasgow_data_glasgow_motor_response_motor_response_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_glasgow_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_glasgow_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_glasgow_data_users_user_id");

            entity.HasOne(d => d.VerbalResponse).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.VerbalResponseId)
                .HasConstraintName("fk_glasgow_data_glasgow_verbal_response_verbal_response_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.GlasgowData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_glasgow_data_visits_visit_id");
        });

        modelBuilder.Entity<GlasgowEyeOpening>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_glasgow_eye_opening");

            entity.ToTable("glasgow_eye_opening");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<GlasgowMotorResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_glasgow_motor_response");

            entity.ToTable("glasgow_motor_response");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<GlasgowVerbalResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_glasgow_verbal_response");

            entity.ToTable("glasgow_verbal_response");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<GlucoseDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_glucose_data");

            entity.ToTable("glucose_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_glucose_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_glucose_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_glucose_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_glucose_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_glucose_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.GlucoseValue).HasColumnName("glucose_value");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.GlucoseData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_glucose_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.GlucoseData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_glucose_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.GlucoseData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_glucose_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.GlucoseData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_glucose_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.GlucoseData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_glucose_data_visits_visit_id");
        });

        modelBuilder.Entity<HysteroscopyAnatomicalPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_hysteroscopy_anatomical_position");

            entity.ToTable("hysteroscopy_anatomical_position");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<HysteroscopyAnatomicalSubPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_hysteroscopy_anatomical_sub_position");

            entity.ToTable("hysteroscopy_anatomical_sub_position");

            entity.HasIndex(e => e.AnatomicalPositionId, "ix_hysteroscopy_anatomical_sub_position_anatomical_position_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnatomicalPositionId).HasColumnName("anatomical_position_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.AnatomicalPosition).WithMany(p => p.HysteroscopyAnatomicalSubPositions)
                .HasForeignKey(d => d.AnatomicalPositionId)
                .HasConstraintName("fk_hysteroscopy_anatomical_sub_position_hysteroscopy_anatomica");
        });

        modelBuilder.Entity<HysteroscopyFileDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_hysteroscopy_file_data");

            entity.ToTable("hysteroscopy_file_data");

            entity.HasIndex(e => e.AnatomicalPositionId, "ix_hysteroscopy_file_data_anatomical_position_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_hysteroscopy_file_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_hysteroscopy_file_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_hysteroscopy_file_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_hysteroscopy_file_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_hysteroscopy_file_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnatomicalPositionId).HasColumnName("anatomical_position_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.FileType).HasColumnName("file_type");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.AnatomicalPosition).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.AnatomicalPositionId)
                .HasConstraintName("fk_hysteroscopy_file_data_hysteroscopy_anatomical_position_ana");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_hysteroscopy_file_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_hysteroscopy_file_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_hysteroscopy_file_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_hysteroscopy_file_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.HysteroscopyFileData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_hysteroscopy_file_data_visits_visit_id");
        });

        modelBuilder.Entity<ImagingDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_imaging_data");

            entity.ToTable("imaging_data");

            entity.HasIndex(e => e.CategoryId, "ix_imaging_data_category_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_imaging_data_episode_care_id");

            entity.HasIndex(e => e.ModalityId, "ix_imaging_data_modality_id");

            entity.HasIndex(e => e.PatientId, "ix_imaging_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_imaging_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_imaging_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_imaging_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.ExamTitle).HasColumnName("exam_title");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.ModalityId).HasColumnName("modality_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ReportPath).HasColumnName("report_path");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Category).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_imaging_data_master_categories_category_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_imaging_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Modality).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.ModalityId)
                .HasConstraintName("fk_imaging_data_master_category_modalities_modality_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_imaging_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_imaging_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_imaging_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ImagingData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_imaging_data_visits_visit_id");
        });

        modelBuilder.Entity<ImagingFilePath>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_imaging_file_paths");

            entity.ToTable("imaging_file_paths");

            entity.HasIndex(e => e.ImagingDataId, "ix_imaging_file_paths_imaging_data_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImagingDataId).HasColumnName("imaging_data_id");
            entity.Property(e => e.Path).HasColumnName("path");

            entity.HasOne(d => d.ImagingData).WithMany(p => p.ImagingFilePaths)
                .HasForeignKey(d => d.ImagingDataId)
                .HasConstraintName("fk_imaging_file_paths_imaging_data_imaging_data_id");
        });

        modelBuilder.Entity<ImagingPredictionDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_imaging_prediction_data");

            entity.ToTable("imaging_prediction_data");

            entity.HasIndex(e => e.ImagingFileId, "ix_imaging_prediction_data_imaging_file_id");

            entity.HasIndex(e => e.TenantId, "ix_imaging_prediction_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_imaging_prediction_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContourImagePath).HasColumnName("contour_image_path");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.ImagingFileId).HasColumnName("imaging_file_id");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PredictionImagePath).HasColumnName("prediction_image_path");
            entity.Property(e => e.ProcessedImagePath).HasColumnName("processed_image_path");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ImagingFile).WithMany(p => p.ImagingPredictionData)
                .HasForeignKey(d => d.ImagingFileId)
                .HasConstraintName("fk_imaging_prediction_data_imaging_file_paths_imaging_file_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ImagingPredictionData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_imaging_prediction_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ImagingPredictionData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_imaging_prediction_data_users_user_id");
        });

        modelBuilder.Entity<IpsCdaDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_ips_cda_data");

            entity.ToTable("ips_cda_data");

            entity.HasIndex(e => e.PatientId, "ix_ips_cda_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_ips_cda_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_ips_cda_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.IpsCdaData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_ips_cda_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.IpsCdaData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_ips_cda_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.IpsCdaData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_ips_cda_data_users_user_id");
        });

        modelBuilder.Entity<Laboratory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_laboratory");

            entity.ToTable("laboratory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.MinValue).HasColumnName("min_value");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<LaboratoryDataItem>(entity =>
        {
            entity.HasKey(e => new { e.LaboratoryDataId, e.LaboratoryId }).HasName("pk_laboratory_data_items");

            entity.ToTable("laboratory_data_items");

            entity.HasIndex(e => e.LaboratoryId, "ix_laboratory_data_items_laboratory_id");

            entity.Property(e => e.LaboratoryDataId).HasColumnName("laboratory_data_id");
            entity.Property(e => e.LaboratoryId).HasColumnName("laboratory_id");
            entity.Property(e => e.Value).HasColumnName("value");

            entity.HasOne(d => d.LaboratoryData).WithMany(p => p.LaboratoryDataItems)
                .HasForeignKey(d => d.LaboratoryDataId)
                .HasConstraintName("fk_laboratory_data_items_laboratory_data_laboratory_data_id");

            entity.HasOne(d => d.Laboratory).WithMany(p => p.LaboratoryDataItems)
                .HasForeignKey(d => d.LaboratoryId)
                .HasConstraintName("fk_laboratory_data_items_laboratory_laboratory_id");
        });

        modelBuilder.Entity<LaboratoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_laboratory_data");

            entity.ToTable("laboratory_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_laboratory_data_episode_care_id");

            entity.HasIndex(e => e.LaboratoryGroupId, "ix_laboratory_data_laboratory_group_id");

            entity.HasIndex(e => e.PatientId, "ix_laboratory_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_laboratory_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_laboratory_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_laboratory_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LaboratoryGroupId).HasColumnName("laboratory_group_id");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_laboratory_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.LaboratoryGroup).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.LaboratoryGroupId)
                .HasConstraintName("fk_laboratory_data_laboratory_group_laboratory_group_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_laboratory_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_laboratory_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_laboratory_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.LaboratoryData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_laboratory_data_visits_visit_id");
        });

        modelBuilder.Entity<LaboratoryFilesDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_laboratory_files_data");

            entity.ToTable("laboratory_files_data");

            entity.HasIndex(e => e.CategoryId, "ix_laboratory_files_data_category_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_laboratory_files_data_episode_care_id");

            entity.HasIndex(e => e.ExamTitleId, "ix_laboratory_files_data_exam_title_id");

            entity.HasIndex(e => e.PatientId, "ix_laboratory_files_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_laboratory_files_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_laboratory_files_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_laboratory_files_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.ExamTitleId).HasColumnName("exam_title_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Category).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_laboratory_files_data_master_categories_category_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_laboratory_files_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.ExamTitle).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.ExamTitleId)
                .HasConstraintName("fk_laboratory_files_data_master_exam_titles_exam_title_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_laboratory_files_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_laboratory_files_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_laboratory_files_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.LaboratoryFilesData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_laboratory_files_data_visits_visit_id");
        });

        modelBuilder.Entity<LaboratoryGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_laboratory_group");

            entity.ToTable("laboratory_group");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasMany(d => d.Tenants).WithMany(p => p.LaboratoryGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "LaboratoryGroupTenant",
                    r => r.HasOne<Tenant>().WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_laboratory_group_tenant_tenant_tenant_id"),
                    l => l.HasOne<LaboratoryGroup>().WithMany()
                        .HasForeignKey("LaboratoryGroupId")
                        .HasConstraintName("fk_laboratory_group_tenant_laboratory_group_laboratory_group_id"),
                    j =>
                    {
                        j.HasKey("LaboratoryGroupId", "TenantId").HasName("pk_laboratory_group_tenant");
                        j.ToTable("laboratory_group_tenant");
                        j.HasIndex(new[] { "TenantId" }, "ix_laboratory_group_tenant_tenant_id");
                        j.IndexerProperty<int>("LaboratoryGroupId").HasColumnName("laboratory_group_id");
                        j.IndexerProperty<int>("TenantId").HasColumnName("tenant_id");
                    });
        });

        modelBuilder.Entity<LaboratoryGroupLaboratory>(entity =>
        {
            entity.HasKey(e => new { e.LaboratoryId, e.LaboratoryGroupId }).HasName("pk_laboratory_group_laboratory");

            entity.ToTable("laboratory_group_laboratory");

            entity.HasIndex(e => e.LaboratoryGroupId, "ix_laboratory_group_laboratory_laboratory_group_id");

            entity.Property(e => e.LaboratoryId).HasColumnName("laboratory_id");
            entity.Property(e => e.LaboratoryGroupId).HasColumnName("laboratory_group_id");
            entity.Property(e => e.IsRequired).HasColumnName("is_required");

            entity.HasOne(d => d.LaboratoryGroup).WithMany(p => p.LaboratoryGroupLaboratories)
                .HasForeignKey(d => d.LaboratoryGroupId)
                .HasConstraintName("fk_laboratory_group_laboratory_laboratory_group_laboratory_gro");

            entity.HasOne(d => d.Laboratory).WithMany(p => p.LaboratoryGroupLaboratories)
                .HasForeignKey(d => d.LaboratoryId)
                .HasConstraintName("fk_laboratory_group_laboratory_laboratory_laboratory_id");
        });

        modelBuilder.Entity<Locale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_locale");

            entity.ToTable("locale");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MasterCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_master_categories");

            entity.ToTable("master_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryCode).HasColumnName("category_code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MasterCategoryModality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_master_category_modalities");

            entity.ToTable("master_category_modalities");

            entity.HasIndex(e => e.CategoryId, "ix_master_category_modalities_category_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.Category).WithMany(p => p.MasterCategoryModalities)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_master_category_modalities_master_categories_category_id");
        });

        modelBuilder.Entity<MasterExamTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_master_exam_titles");

            entity.ToTable("master_exam_titles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MasterTimingUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_master_timing_unit");

            entity.ToTable("master_timing_unit");

            entity.HasIndex(e => e.UnitId, "ix_master_timing_unit_unit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.Unit).WithMany(p => p.MasterTimingUnits)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("fk_master_timing_unit_ehdsi_unit_unit_id");
        });

        modelBuilder.Entity<MedicalAlertDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medical_alert_data");

            entity.ToTable("medical_alert_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medical_alert_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_medical_alert_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_medical_alert_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medical_alert_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medical_alert_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicalAlertData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medical_alert_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalAlertData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medical_alert_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicalAlertData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medical_alert_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicalAlertData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medical_alert_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicalAlertData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medical_alert_data_visits_visit_id");
        });

        modelBuilder.Entity<MedicalDeviceAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medical_device_actions");

            entity.ToTable("medical_device_actions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MedicalDeviceUnknownDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medical_device_unknown_data");

            entity.ToTable("medical_device_unknown_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medical_device_unknown_data_episode_care_id");

            entity.HasIndex(e => e.MedicalDeviceId, "ix_medical_device_unknown_data_medical_device_id");

            entity.HasIndex(e => e.PatientId, "ix_medical_device_unknown_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_medical_device_unknown_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medical_device_unknown_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medical_device_unknown_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MedicalDeviceId).HasColumnName("medical_device_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medical_device_unknown_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.MedicalDevice).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.MedicalDeviceId)
                .HasConstraintName("fk_medical_device_unknown_data_ehdsi_absent_or_unknown_device_");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medical_device_unknown_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medical_device_unknown_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medical_device_unknown_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicalDeviceUnknownData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medical_device_unknown_data_visits_visit_id");
        });

        modelBuilder.Entity<MedicalDevicesDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medical_devices_data");

            entity.ToTable("medical_devices_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medical_devices_data_episode_care_id");

            entity.HasIndex(e => e.MedicalDeviceActionId, "ix_medical_devices_data_medical_device_action_id");

            entity.HasIndex(e => e.MedicalDeviceId, "ix_medical_devices_data_medical_device_id");

            entity.HasIndex(e => e.PatientId, "ix_medical_devices_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_medical_devices_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medical_devices_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medical_devices_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MedicalDeviceActionId).HasColumnName("medical_device_action_id");
            entity.Property(e => e.MedicalDeviceId).HasColumnName("medical_device_id");
            entity.Property(e => e.OnSetDate).HasColumnName("on_set_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RemovalDate).HasColumnName("removal_date");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medical_devices_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.MedicalDeviceAction).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.MedicalDeviceActionId)
                .HasConstraintName("fk_medical_devices_data_medical_device_actions_medical_device_");

            entity.HasOne(d => d.MedicalDevice).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.MedicalDeviceId)
                .HasConstraintName("fk_medical_devices_data_ehdsi_medical_device_medical_device_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medical_devices_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medical_devices_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medical_devices_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicalDevicesData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medical_devices_data_visits_visit_id");
        });

        modelBuilder.Entity<MedicalHistoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medical_history_data");

            entity.ToTable("medical_history_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medical_history_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_medical_history_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_medical_history_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medical_history_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medical_history_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicalHistoryData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medical_history_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicalHistoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medical_history_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicalHistoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medical_history_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicalHistoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medical_history_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicalHistoryData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medical_history_data_visits_visit_id");
        });

        modelBuilder.Entity<MedicationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medication_data");

            entity.ToTable("medication_data");

            entity.HasIndex(e => e.ActiveIngredientId, "ix_medication_data_active_ingredient_id");

            entity.HasIndex(e => e.AssignedDoctorId, "ix_medication_data_assigned_doctor_id");

            entity.HasIndex(e => e.AtcId, "ix_medication_data_atc_id");

            entity.HasIndex(e => e.DurationOfTreatmentUnitId, "ix_medication_data_duration_of_treatment_unit_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medication_data_episode_care_id");

            entity.HasIndex(e => e.FrequencyOfIntakeUnitId, "ix_medication_data_frequency_of_intake_unit_id");

            entity.HasIndex(e => e.PackageId, "ix_medication_data_package_id");

            entity.HasIndex(e => e.PatientId, "ix_medication_data_patient_id");

            entity.HasIndex(e => e.ProblemId, "ix_medication_data_problem_id");

            entity.HasIndex(e => e.ProductId, "ix_medication_data_product_id");

            entity.HasIndex(e => e.ProfessionId, "ix_medication_data_profession_id");

            entity.HasIndex(e => e.QuantityUnitId, "ix_medication_data_quantity_unit_id");

            entity.HasIndex(e => e.ReplacementId, "ix_medication_data_replacement_id");

            entity.HasIndex(e => e.RouteOfAdministrationId, "ix_medication_data_route_of_administration_id");

            entity.HasIndex(e => e.TenantId, "ix_medication_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medication_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medication_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveIngredientId).HasColumnName("active_ingredient_id");
            entity.Property(e => e.AdviceToDispenser).HasColumnName("advice_to_dispenser");
            entity.Property(e => e.AssignedDoctorId).HasColumnName("assigned_doctor_id");
            entity.Property(e => e.AtcId).HasColumnName("atc_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DurationOfTreatmentAmount).HasColumnName("duration_of_treatment_amount");
            entity.Property(e => e.DurationOfTreatmentUnitId).HasColumnName("duration_of_treatment_unit_id");
            entity.Property(e => e.EndDateTime).HasColumnName("end_date_time");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.FrequencyOfIntakeAmount).HasColumnName("frequency_of_intake_amount");
            entity.Property(e => e.FrequencyOfIntakeUnitId).HasColumnName("frequency_of_intake_unit_id");
            entity.Property(e => e.InstructionPatient).HasColumnName("instruction_patient");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.PackageId).HasColumnName("package_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProblemId).HasColumnName("problem_id");
            entity.Property(e => e.ProductId)
                .HasMaxLength(48)
                .HasColumnName("product_id");
            entity.Property(e => e.ProfessionId).HasColumnName("profession_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.QuantityUnitId).HasColumnName("quantity_unit_id");
            entity.Property(e => e.ReplacementId).HasColumnName("replacement_id");
            entity.Property(e => e.RouteOfAdministrationId).HasColumnName("route_of_administration_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.ActiveIngredient).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.ActiveIngredientId)
                .HasConstraintName("fk_medication_data_pharm_activesubstances_active_ingredient_id");

            entity.HasOne(d => d.AssignedDoctor).WithMany(p => p.MedicationDatumAssignedDoctors)
                .HasForeignKey(d => d.AssignedDoctorId)
                .HasConstraintName("fk_medication_data_users_assigned_doctor_id");

            entity.HasOne(d => d.Atc).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.AtcId)
                .HasConstraintName("fk_medication_data_pharm_atcs_atc_id");

            entity.HasOne(d => d.DurationOfTreatmentUnit).WithMany(p => p.MedicationDatumDurationOfTreatmentUnits)
                .HasForeignKey(d => d.DurationOfTreatmentUnitId)
                .HasConstraintName("fk_medication_data_master_timing_unit_duration_of_treatment_un");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medication_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.FrequencyOfIntakeUnit).WithMany(p => p.MedicationDatumFrequencyOfIntakeUnits)
                .HasForeignKey(d => d.FrequencyOfIntakeUnitId)
                .HasConstraintName("fk_medication_data_master_timing_unit_frequency_of_intake_unit");

            entity.HasOne(d => d.Package).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("fk_medication_data_pharm_forms_package_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medication_data_patients_patient_id");

            entity.HasOne(d => d.Problem).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.ProblemId)
                .HasConstraintName("fk_medication_data_problem_data_problem_id");

            entity.HasOne(d => d.Product).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_medication_data_pharm_products_product_id");

            entity.HasOne(d => d.Profession).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.ProfessionId)
                .HasConstraintName("fk_medication_data_ehdsi_healthcare_professional_role_professi");

            entity.HasOne(d => d.QuantityUnit).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.QuantityUnitId)
                .HasConstraintName("fk_medication_data_pharm_packagesizeunits_quantity_unit_id");

            entity.HasOne(d => d.Replacement).WithMany(p => p.InverseReplacement)
                .HasForeignKey(d => d.ReplacementId)
                .HasConstraintName("fk_medication_data_medication_data_replacement_id");

            entity.HasOne(d => d.RouteOfAdministration).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.RouteOfAdministrationId)
                .HasConstraintName("fk_medication_data_pharm_routes_route_of_administration_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medication_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicationDatumUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medication_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicationData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medication_data_visits_visit_id");
        });

        modelBuilder.Entity<MedicationUnknownDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_medication_unknown_data");

            entity.ToTable("medication_unknown_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_medication_unknown_data_episode_care_id");

            entity.HasIndex(e => e.MedicationId, "ix_medication_unknown_data_medication_id");

            entity.HasIndex(e => e.PatientId, "ix_medication_unknown_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_medication_unknown_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_medication_unknown_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_medication_unknown_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MedicationId).HasColumnName("medication_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_medication_unknown_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Medication).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.MedicationId)
                .HasConstraintName("fk_medication_unknown_data_ehdsi_absent_or_unknown_medication_");

            entity.HasOne(d => d.Patient).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_medication_unknown_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_medication_unknown_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_medication_unknown_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.MedicationUnknownData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_medication_unknown_data_visits_visit_id");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_module");

            entity.ToTable("module");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OrderBy).HasColumnName("order_by");
            entity.Property(e => e.Path).HasColumnName("path");
        });

        modelBuilder.Entity<ModuleRelationship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_module_relationships");

            entity.ToTable("module_relationships");

            entity.HasIndex(e => e.ChildModuleId, "ix_module_relationships_child_module_id");

            entity.HasIndex(e => e.ParentModuleId, "ix_module_relationships_parent_module_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildModuleId).HasColumnName("child_module_id");
            entity.Property(e => e.ParentModuleId).HasColumnName("parent_module_id");

            entity.HasOne(d => d.ChildModule).WithMany(p => p.ModuleRelationshipChildModules)
                .HasForeignKey(d => d.ChildModuleId)
                .HasConstraintName("fk_module_relationships_module_child_module_id");

            entity.HasOne(d => d.ParentModule).WithMany(p => p.ModuleRelationshipParentModules)
                .HasForeignKey(d => d.ParentModuleId)
                .HasConstraintName("fk_module_relationships_module_parent_module_id");
        });

        modelBuilder.Entity<NeckSizeDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_neck_size_data");

            entity.ToTable("neck_size_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_neck_size_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_neck_size_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_neck_size_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_neck_size_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_neck_size_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.NeckSize).HasColumnName("neck_size");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.NeckSizeData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_neck_size_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.NeckSizeData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_neck_size_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.NeckSizeData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_neck_size_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.NeckSizeData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_neck_size_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.NeckSizeData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_neck_size_data_visits_visit_id");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_packages");

            entity.ToTable("packages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.LicenceNumber).HasColumnName("licence_number");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasMany(d => d.Modules).WithMany(p => p.Packages)
                .UsingEntity<Dictionary<string, object>>(
                    "PackageModule",
                    r => r.HasOne<Module>().WithMany()
                        .HasForeignKey("ModuleId")
                        .HasConstraintName("fk_package_modules_module_module_id"),
                    l => l.HasOne<Package>().WithMany()
                        .HasForeignKey("PackageId")
                        .HasConstraintName("fk_package_modules_packages_package_id"),
                    j =>
                    {
                        j.HasKey("PackageId", "ModuleId").HasName("pk_package_modules");
                        j.ToTable("package_modules");
                        j.HasIndex(new[] { "ModuleId" }, "ix_package_modules_module_id");
                        j.IndexerProperty<int>("PackageId").HasColumnName("package_id");
                        j.IndexerProperty<int>("ModuleId").HasColumnName("module_id");
                    });
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patients");

            entity.ToTable("patients");

            entity.HasIndex(e => e.AddressDataId, "ix_patients_address_data_id");

            entity.HasIndex(e => e.BloodTypeId, "ix_patients_blood_type_id");

            entity.HasIndex(e => e.ClosestRelativesId, "ix_patients_closest_relatives_id");

            entity.HasIndex(e => e.EducationLevelId, "ix_patients_education_level_id");

            entity.HasIndex(e => e.FamilyStatusId, "ix_patients_family_status_id");

            entity.HasIndex(e => e.GenderId, "ix_patients_gender_id");

            entity.HasIndex(e => e.ImmobilityStatusId, "ix_patients_immobility_status_id");

            entity.HasIndex(e => e.PlaceOfBirthId, "ix_patients_place_of_birth_id");

            entity.HasIndex(e => e.RegistrationAgentId, "ix_patients_registration_agent_id");

            entity.HasIndex(e => e.RegistrationStatusId, "ix_patients_registration_status_id");

            entity.HasIndex(e => e.ReligionId, "ix_patients_religion_id");

            entity.HasIndex(e => e.SourceOfIncomeId, "ix_patients_source_of_income_id");

            entity.HasIndex(e => e.TenantId, "ix_patients_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_patients_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressDataId).HasColumnName("address_data_id");
            entity.Property(e => e.AmountOfIncome)
                .HasMaxLength(50)
                .HasColumnName("amount_of_income");
            entity.Property(e => e.BloodTypeId).HasColumnName("blood_type_id");
            entity.Property(e => e.ClosestRelativesId).HasColumnName("closest_relatives_id");
            entity.Property(e => e.ClosestRelativesOther)
                .HasMaxLength(50)
                .HasColumnName("closest_relatives_other");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DateOfAdmission).HasColumnName("date_of_admission");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.EducationLevelId).HasColumnName("education_level_id");
            entity.Property(e => e.EducationLevelOther)
                .HasMaxLength(50)
                .HasColumnName("education_level_other");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FamilyStatusId).HasColumnName("family_status_id");
            entity.Property(e => e.FamilyStatusOther)
                .HasMaxLength(50)
                .HasColumnName("family_status_other");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.GenderId).HasColumnName("gender_id");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.ImmobilityStatusId).HasColumnName("immobility_status_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsImported).HasColumnName("is_imported");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Moh).HasColumnName("moh");
            entity.Property(e => e.Occupation)
                .HasMaxLength(100)
                .HasColumnName("occupation");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PicturePath).HasColumnName("picture_path");
            entity.Property(e => e.PlaceOfBirthDistrict)
                .HasMaxLength(50)
                .HasColumnName("place_of_birth_district");
            entity.Property(e => e.PlaceOfBirthId).HasColumnName("place_of_birth_id");
            entity.Property(e => e.RegistrationAgentId).HasColumnName("registration_agent_id");
            entity.Property(e => e.RegistrationStatusId).HasColumnName("registration_status_id");
            entity.Property(e => e.ReligionId).HasColumnName("religion_id");
            entity.Property(e => e.ReligionOther)
                .HasMaxLength(50)
                .HasColumnName("religion_other");
            entity.Property(e => e.SourceOfIncomeId).HasColumnName("source_of_income_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AddressData).WithMany(p => p.Patients)
                .HasForeignKey(d => d.AddressDataId)
                .HasConstraintName("fk_patients_address_data_address_data_id");

            entity.HasOne(d => d.BloodType).WithMany(p => p.Patients)
                .HasForeignKey(d => d.BloodTypeId)
                .HasConstraintName("fk_patients_ehdsi_blood_group_blood_type_id");

            entity.HasOne(d => d.ClosestRelatives).WithMany(p => p.Patients)
                .HasForeignKey(d => d.ClosestRelativesId)
                .HasConstraintName("fk_patients_patient_closest_relatives_closest_relatives_id");

            entity.HasOne(d => d.EducationLevel).WithMany(p => p.Patients)
                .HasForeignKey(d => d.EducationLevelId)
                .HasConstraintName("fk_patients_patient_education_level_education_level_id");

            entity.HasOne(d => d.FamilyStatus).WithMany(p => p.Patients)
                .HasForeignKey(d => d.FamilyStatusId)
                .HasConstraintName("fk_patients_patient_family_status_family_status_id");

            entity.HasOne(d => d.Gender).WithMany(p => p.Patients)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("fk_patients_ehdsi_administrative_gender_gender_id");

            entity.HasOne(d => d.ImmobilityStatus).WithMany(p => p.Patients)
                .HasForeignKey(d => d.ImmobilityStatusId)
                .HasConstraintName("fk_patients_patient_immobility_status_immobility_status_id");

            entity.HasOne(d => d.PlaceOfBirth).WithMany(p => p.Patients)
                .HasForeignKey(d => d.PlaceOfBirthId)
                .HasConstraintName("fk_patients_ehdsi_country_place_of_birth_id");

            entity.HasOne(d => d.RegistrationAgent).WithMany(p => p.PatientRegistrationAgents)
                .HasForeignKey(d => d.RegistrationAgentId)
                .HasConstraintName("fk_patients_users_registration_agent_id");

            entity.HasOne(d => d.RegistrationStatus).WithMany(p => p.Patients)
                .HasForeignKey(d => d.RegistrationStatusId)
                .HasConstraintName("fk_patients_patient_registration_status_registration_status_id");

            entity.HasOne(d => d.Religion).WithMany(p => p.Patients)
                .HasForeignKey(d => d.ReligionId)
                .HasConstraintName("fk_patients_patient_religion_religion_id");

            entity.HasOne(d => d.SourceOfIncome).WithMany(p => p.Patients)
                .HasForeignKey(d => d.SourceOfIncomeId)
                .HasConstraintName("fk_patients_patient_source_of_income_source_of_income_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Patients)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_patients_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PatientUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_patients_users_user_id");

            entity.HasMany(d => d.ExternalDoctorCymas).WithMany(p => p.Patients)
                .UsingEntity<Dictionary<string, object>>(
                    "PatientExternalDoctorsCymaDatum",
                    r => r.HasOne<ExternalDoctorsCyma>().WithMany()
                        .HasForeignKey("ExternalDoctorCymaId")
                        .HasConstraintName("fk_patient_external_doctors_cyma_data_external_doctors_cyma_ex"),
                    l => l.HasOne<Patient>().WithMany()
                        .HasForeignKey("PatientId")
                        .HasConstraintName("fk_patient_external_doctors_cyma_data_patients_patient_id"),
                    j =>
                    {
                        j.HasKey("PatientId", "ExternalDoctorCymaId").HasName("pk_patient_external_doctors_cyma_data");
                        j.ToTable("patient_external_doctors_cyma_data");
                        j.HasIndex(new[] { "ExternalDoctorCymaId" }, "ix_patient_external_doctors_cyma_data_external_doctor_cyma_id");
                        j.IndexerProperty<int>("PatientId").HasColumnName("patient_id");
                        j.IndexerProperty<int>("ExternalDoctorCymaId").HasColumnName("external_doctor_cyma_id");
                    });

            entity.HasMany(d => d.ExternalDoctors).WithMany(p => p.Patients)
                .UsingEntity<Dictionary<string, object>>(
                    "PatientExternalDoctorDatum",
                    r => r.HasOne<ExternalDoctor>().WithMany()
                        .HasForeignKey("ExternalDoctorId")
                        .HasConstraintName("fk_patient_external_doctor_data_external_doctors_external_doct"),
                    l => l.HasOne<Patient>().WithMany()
                        .HasForeignKey("PatientId")
                        .HasConstraintName("fk_patient_external_doctor_data_patients_patient_id"),
                    j =>
                    {
                        j.HasKey("PatientId", "ExternalDoctorId").HasName("pk_patient_external_doctor_data");
                        j.ToTable("patient_external_doctor_data");
                        j.HasIndex(new[] { "ExternalDoctorId" }, "ix_patient_external_doctor_data_external_doctor_id");
                        j.IndexerProperty<int>("PatientId").HasColumnName("patient_id");
                        j.IndexerProperty<int>("ExternalDoctorId").HasColumnName("external_doctor_id");
                    });

            entity.HasMany(d => d.Insurances).WithMany(p => p.Patients)
                .UsingEntity<Dictionary<string, object>>(
                    "PatientInsurancesDatum",
                    r => r.HasOne<PatientInsurance>().WithMany()
                        .HasForeignKey("InsuranceId")
                        .HasConstraintName("fk_patient_insurances_data_patient_insurance_insurance_id"),
                    l => l.HasOne<Patient>().WithMany()
                        .HasForeignKey("PatientId")
                        .HasConstraintName("fk_patient_insurances_data_patients_patient_id"),
                    j =>
                    {
                        j.HasKey("PatientId", "InsuranceId").HasName("pk_patient_insurances_data");
                        j.ToTable("patient_insurances_data");
                        j.HasIndex(new[] { "InsuranceId" }, "ix_patient_insurances_data_insurance_id");
                        j.IndexerProperty<int>("PatientId").HasColumnName("patient_id");
                        j.IndexerProperty<int>("InsuranceId").HasColumnName("insurance_id");
                    });
        });

        modelBuilder.Entity<PatientClosestRelative>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_closest_relatives");

            entity.ToTable("patient_closest_relatives");

            entity.HasIndex(e => e.TranslationId, "ix_patient_closest_relatives_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientClosestRelatives)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_closest_relatives_translations_translation_id");
        });

        modelBuilder.Entity<PatientDoctor>(entity =>
        {
            entity.HasKey(e => new { e.PatientId, e.DoctorId }).HasName("pk_patient_doctors");

            entity.ToTable("patient_doctors");

            entity.HasIndex(e => e.DoctorId, "ix_patient_doctors_doctor_id");

            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.PrimaryDoctor).HasColumnName("primary_doctor");

            entity.HasOne(d => d.Doctor).WithMany(p => p.PatientDoctors)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("fk_patient_doctors_users_doctor_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientDoctors)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_doctors_patients_patient_id");
        });

        modelBuilder.Entity<PatientDocumentsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_documents_data");

            entity.ToTable("patient_documents_data");

            entity.HasIndex(e => e.DocumentCountryIssuedId, "ix_patient_documents_data_document_country_issued_id");

            entity.HasIndex(e => e.DocumentTypeId, "ix_patient_documents_data_document_type_id");

            entity.HasIndex(e => e.PatientId, "ix_patient_documents_data_patient_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DocumentCountryIssuedId).HasColumnName("document_country_issued_id");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("document_number");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");

            entity.HasOne(d => d.DocumentCountryIssued).WithMany(p => p.PatientDocumentsData)
                .HasForeignKey(d => d.DocumentCountryIssuedId)
                .HasConstraintName("fk_patient_documents_data_ehdsi_country_document_country_issue");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.PatientDocumentsData)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("fk_patient_documents_data_document_types_document_type_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientDocumentsData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_documents_data_patients_patient_id");
        });

        modelBuilder.Entity<PatientEducationLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_education_level");

            entity.ToTable("patient_education_level");

            entity.HasIndex(e => e.TranslationId, "ix_patient_education_level_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientEducationLevels)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_education_level_translations_translation_id");
        });

        modelBuilder.Entity<PatientEmergencyContactsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_emergency_contacts_data");

            entity.ToTable("patient_emergency_contacts_data");

            entity.HasIndex(e => e.AddressDataId, "ix_patient_emergency_contacts_data_address_data_id");

            entity.HasIndex(e => e.ClosestRelativeId, "ix_patient_emergency_contacts_data_closest_relative_id");

            entity.HasIndex(e => e.DocumentCountryIssuedId, "ix_patient_emergency_contacts_data_document_country_issued_id");

            entity.HasIndex(e => e.DocumentTypeId, "ix_patient_emergency_contacts_data_document_type_id");

            entity.HasIndex(e => e.PatientId, "ix_patient_emergency_contacts_data_patient_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressDataId).HasColumnName("address_data_id");
            entity.Property(e => e.ClosestRelativeId).HasColumnName("closest_relative_id");
            entity.Property(e => e.ClosestRelativeOther)
                .HasMaxLength(50)
                .HasColumnName("closest_relative_other");
            entity.Property(e => e.DocumentCountryIssuedId).HasColumnName("document_country_issued_id");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("document_number");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Occupation)
                .HasMaxLength(100)
                .HasColumnName("occupation");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");

            entity.HasOne(d => d.AddressData).WithMany(p => p.PatientEmergencyContactsData)
                .HasForeignKey(d => d.AddressDataId)
                .HasConstraintName("fk_patient_emergency_contacts_data_address_data_address_data_id");

            entity.HasOne(d => d.ClosestRelative).WithMany(p => p.PatientEmergencyContactsData)
                .HasForeignKey(d => d.ClosestRelativeId)
                .HasConstraintName("fk_patient_emergency_contacts_data_patient_closest_relatives_c");

            entity.HasOne(d => d.DocumentCountryIssued).WithMany(p => p.PatientEmergencyContactsData)
                .HasForeignKey(d => d.DocumentCountryIssuedId)
                .HasConstraintName("fk_patient_emergency_contacts_data_ehdsi_country_document_coun");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.PatientEmergencyContactsData)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("fk_patient_emergency_contacts_data_document_types_document_typ");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientEmergencyContactsData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_emergency_contacts_data_patients_patient_id");
        });

        modelBuilder.Entity<PatientFamilyStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_family_status");

            entity.ToTable("patient_family_status");

            entity.HasIndex(e => e.TranslationId, "ix_patient_family_status_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientFamilyStatuses)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_family_status_translations_translation_id");
        });

        modelBuilder.Entity<PatientFileType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_file_type");

            entity.ToTable("patient_file_type");

            entity.HasIndex(e => e.TranslationId, "ix_patient_file_type_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientFileTypes)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_file_type_translations_translation_id");
        });

        modelBuilder.Entity<PatientFilesDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_files_data");

            entity.ToTable("patient_files_data");

            entity.HasIndex(e => e.FileTypeId, "ix_patient_files_data_file_type_id");

            entity.HasIndex(e => e.PatientId, "ix_patient_files_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_patient_files_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_patient_files_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.FilePath).HasColumnName("file_path");
            entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.FileType).WithMany(p => p.PatientFilesData)
                .HasForeignKey(d => d.FileTypeId)
                .HasConstraintName("fk_patient_files_data_patient_file_type_file_type_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientFilesData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_files_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PatientFilesData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_patient_files_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PatientFilesData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_patient_files_data_users_user_id");
        });

        modelBuilder.Entity<PatientImmobilityStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_immobility_status");

            entity.ToTable("patient_immobility_status");

            entity.HasIndex(e => e.TranslationId, "ix_patient_immobility_status_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientImmobilityStatuses)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_immobility_status_translations_translation_id");
        });

        modelBuilder.Entity<PatientInsurance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_insurance");

            entity.ToTable("patient_insurance");

            entity.HasIndex(e => e.CountryId, "ix_patient_insurance_country_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.Country).WithMany(p => p.PatientInsurances)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_patient_insurance_ehdsi_country_country_id");
        });

        modelBuilder.Entity<PatientRegistrationHistoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_registration_history_data");

            entity.ToTable("patient_registration_history_data");

            entity.HasIndex(e => e.PatientId, "ix_patient_registration_history_data_patient_id");

            entity.HasIndex(e => e.RegistrationStatusId, "ix_patient_registration_history_data_registration_status_id");

            entity.HasIndex(e => e.RejectionReasonId, "ix_patient_registration_history_data_rejection_reason_id");

            entity.HasIndex(e => e.TenantId, "ix_patient_registration_history_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_patient_registration_history_data_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RegistrationStatusId).HasColumnName("registration_status_id");
            entity.Property(e => e.RejectionReasonId).HasColumnName("rejection_reason_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientRegistrationHistoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_registration_history_data_patients_patient_id");

            entity.HasOne(d => d.RegistrationStatus).WithMany(p => p.PatientRegistrationHistoryData)
                .HasForeignKey(d => d.RegistrationStatusId)
                .HasConstraintName("fk_patient_registration_history_data_patient_registration_stat");

            entity.HasOne(d => d.RejectionReason).WithMany(p => p.PatientRegistrationHistoryData)
                .HasForeignKey(d => d.RejectionReasonId)
                .HasConstraintName("fk_patient_registration_history_data_patient_rejection_reasons");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PatientRegistrationHistoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_patient_registration_history_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PatientRegistrationHistoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_patient_registration_history_data_users_user_id");
        });

        modelBuilder.Entity<PatientRegistrationStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_registration_status");

            entity.ToTable("patient_registration_status");

            entity.HasIndex(e => e.TranslationId, "ix_patient_registration_status_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientRegistrationStatuses)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_registration_status_translations_translation_id");
        });

        modelBuilder.Entity<PatientRejectionReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_rejection_reasons");

            entity.ToTable("patient_rejection_reasons");

            entity.HasIndex(e => e.TranslationId, "ix_patient_rejection_reasons_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientRejectionReasons)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_rejection_reasons_translations_translation_id");

            entity.HasMany(d => d.Tenants).WithMany(p => p.RejectionReasons)
                .UsingEntity<Dictionary<string, object>>(
                    "PatientRejectionReasonTenant",
                    r => r.HasOne<Tenant>().WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_patient_rejection_reason_tenant_tenant_tenant_id"),
                    l => l.HasOne<PatientRejectionReason>().WithMany()
                        .HasForeignKey("RejectionReasonId")
                        .HasConstraintName("fk_patient_rejection_reason_tenant_patient_rejection_reasons_r"),
                    j =>
                    {
                        j.HasKey("RejectionReasonId", "TenantId").HasName("pk_patient_rejection_reason_tenant");
                        j.ToTable("patient_rejection_reason_tenant");
                        j.HasIndex(new[] { "TenantId" }, "ix_patient_rejection_reason_tenant_tenant_id");
                        j.IndexerProperty<int>("RejectionReasonId").HasColumnName("rejection_reason_id");
                        j.IndexerProperty<int>("TenantId").HasColumnName("tenant_id");
                    });
        });

        modelBuilder.Entity<PatientReligion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_religion");

            entity.ToTable("patient_religion");

            entity.HasIndex(e => e.TranslationId, "ix_patient_religion_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientReligions)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_religion_translations_translation_id");
        });

        modelBuilder.Entity<PatientSourceOfIncome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_source_of_income");

            entity.ToTable("patient_source_of_income");

            entity.HasIndex(e => e.TranslationId, "ix_patient_source_of_income_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.Translation).WithMany(p => p.PatientSourceOfIncomes)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_patient_source_of_income_translations_translation_id");
        });

        modelBuilder.Entity<Pdqv3patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pdqv3patients");

            entity.ToTable("pdqv3patients");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FamilyName).HasColumnName("family_name");
            entity.Property(e => e.GenderCode).HasColumnName("gender_code");
            entity.Property(e => e.GenderDisplay).HasColumnName("gender_display");
            entity.Property(e => e.GivenName).HasColumnName("given_name");
            entity.Property(e => e.MatchScore).HasColumnName("match_score");
            entity.Property(e => e.PatientIdExtension).HasColumnName("patient_id_extension");
            entity.Property(e => e.PatientIdRoot).HasColumnName("patient_id_root");
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.ProviderOrgIdRoot).HasColumnName("provider_org_id_root");
            entity.Property(e => e.ProviderOrgName).HasColumnName("provider_org_name");
            entity.Property(e => e.ProviderOrgTelecom).HasColumnName("provider_org_telecom");
            entity.Property(e => e.SourceSystemId).HasColumnName("source_system_id");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.StreetAddress).HasColumnName("street_address");
        });

        modelBuilder.Entity<Pdqv3patientIdentifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pdqv3patient_identifiers");

            entity.ToTable("pdqv3patient_identifiers");

            entity.HasIndex(e => e.Pdqv3patientsId, "ix_pdqv3patient_identifiers_pdqv3patients_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdentifierExtension).HasColumnName("identifier_extension");
            entity.Property(e => e.IdentifierRoot).HasColumnName("identifier_root");
            entity.Property(e => e.Pdqv3patientsId).HasColumnName("pdqv3patients_id");

            entity.HasOne(d => d.Pdqv3patients).WithMany(p => p.Pdqv3patientIdentifiers)
                .HasForeignKey(d => d.Pdqv3patientsId)
                .HasConstraintName("fk_pdqv3patient_identifiers_pdqv3patients_pdqv3patients_id");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_permissions");

            entity.ToTable("permissions");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<PharmActivesubstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_activesubstances");

            entity.ToTable("pharm_activesubstances");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveSubstance)
                .HasMaxLength(24)
                .HasColumnName("active_substance");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.Quantity)
                .HasMaxLength(12)
                .HasColumnName("quantity");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");
        });

        modelBuilder.Entity<PharmActivesubstancelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_activesubstancelists");

            entity.ToTable("pharm_activesubstancelists");

            entity.HasIndex(e => e.PharmActivesubstanceId, "ix_pharm_activesubstancelists_pharm_activesubstance_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drugid)
                .HasMaxLength(24)
                .HasColumnName("drugid");
            entity.Property(e => e.PharmActivesubstanceId).HasColumnName("pharm_activesubstance_id");

            entity.HasOne(d => d.PharmActivesubstance).WithMany(p => p.PharmActivesubstancelists)
                .HasForeignKey(d => d.PharmActivesubstanceId)
                .HasConstraintName("fk_pharm_activesubstancelists_pharm_activesubstances_pharm_act");
        });

        modelBuilder.Entity<PharmAtc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_atcs");

            entity.ToTable("pharm_atcs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Atc)
                .HasMaxLength(48)
                .HasColumnName("atc");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PharmAtclist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_atclists");

            entity.ToTable("pharm_atclists");

            entity.HasIndex(e => e.PharmAtcId, "ix_pharm_atclists_pharm_atc_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drugid)
                .HasMaxLength(24)
                .HasColumnName("drugid");
            entity.Property(e => e.PharmAtcId).HasColumnName("pharm_atc_id");

            entity.HasOne(d => d.PharmAtc).WithMany(p => p.PharmAtclists)
                .HasForeignKey(d => d.PharmAtcId)
                .HasConstraintName("fk_pharm_atclists_pharm_atcs_pharm_atc_id");
        });

        modelBuilder.Entity<PharmDoseFormMapping>(entity =>
        {
            entity.HasKey(e => e.DfId).HasName("pk_pharm_dose_form_mappings");

            entity.ToTable("pharm_dose_form_mappings");

            entity.Property(e => e.DfId).HasColumnName("df_id");
            entity.Property(e => e.MvcDoseForm)
                .HasMaxLength(64)
                .HasColumnName("mvc_dose_form");
            entity.Property(e => e.PharmDoseForm)
                .HasMaxLength(64)
                .HasColumnName("pharm_dose_form");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PharmForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_forms");

            entity.ToTable("pharm_forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .HasColumnName("description");
            entity.Property(e => e.Strength)
                .HasMaxLength(128)
                .HasColumnName("strength");
        });

        modelBuilder.Entity<PharmFormlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_formlists");

            entity.ToTable("pharm_formlists");

            entity.HasIndex(e => e.PharmFormId, "ix_pharm_formlists_pharm_form_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drugid)
                .HasMaxLength(24)
                .HasColumnName("drugid");
            entity.Property(e => e.PharmFormId).HasColumnName("pharm_form_id");

            entity.HasOne(d => d.PharmForm).WithMany(p => p.PharmFormlists)
                .HasForeignKey(d => d.PharmFormId)
                .HasConstraintName("fk_pharm_formlists_pharm_forms_pharm_form_id");
        });

        modelBuilder.Entity<PharmPackagesizeunit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_packagesizeunits");

            entity.ToTable("pharm_packagesizeunits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodingId).HasColumnName("coding_id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
        });

        modelBuilder.Entity<PharmPackagesizeunitlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_packagesizeunitlists");

            entity.ToTable("pharm_packagesizeunitlists");

            entity.HasIndex(e => e.PharmPackagesizeunitId, "ix_pharm_packagesizeunitlists_pharm_packagesizeunit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drugid)
                .HasMaxLength(24)
                .HasColumnName("drugid");
            entity.Property(e => e.PharmPackagesizeunitId).HasColumnName("pharm_packagesizeunit_id");

            entity.HasOne(d => d.PharmPackagesizeunit).WithMany(p => p.PharmPackagesizeunitlists)
                .HasForeignKey(d => d.PharmPackagesizeunitId)
                .HasConstraintName("fk_pharm_packagesizeunitlists_pharm_packagesizeunits_pharm_pac");
        });

        modelBuilder.Entity<PharmProduct>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("pk_pharm_products");

            entity.ToTable("pharm_products");

            entity.Property(e => e.Pk)
                .HasMaxLength(48)
                .HasColumnName("pk");
            entity.Property(e => e.Barcode)
                .HasMaxLength(96)
                .HasColumnName("barcode");
            entity.Property(e => e.Drugid)
                .HasMaxLength(48)
                .HasColumnName("drugid");
            entity.Property(e => e.PackageDescription)
                .HasMaxLength(256)
                .HasColumnName("package_description");
            entity.Property(e => e.PackageSize)
                .HasMaxLength(24)
                .HasColumnName("package_size");
            entity.Property(e => e.Packnr)
                .HasMaxLength(12)
                .HasColumnName("packnr");
            entity.Property(e => e.ProductName)
                .HasMaxLength(256)
                .HasColumnName("product_name");
        });

        modelBuilder.Entity<PharmQuantityunit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_quantityunits");

            entity.ToTable("pharm_quantityunits");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.QuantityUnit)
                .HasMaxLength(128)
                .HasColumnName("quantity_unit");
        });

        modelBuilder.Entity<PharmRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_routes");

            entity.ToTable("pharm_routes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(128)
                .HasColumnName("description");
            entity.Property(e => e.Route)
                .HasMaxLength(128)
                .HasColumnName("route");
        });

        modelBuilder.Entity<PharmRoutelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pharm_routelists");

            entity.ToTable("pharm_routelists");

            entity.HasIndex(e => e.PharmRouteId, "ix_pharm_routelists_pharm_route_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Drugid)
                .HasMaxLength(24)
                .HasColumnName("drugid");
            entity.Property(e => e.PharmRouteId).HasColumnName("pharm_route_id");

            entity.HasOne(d => d.PharmRoute).WithMany(p => p.PharmRoutelists)
                .HasForeignKey(d => d.PharmRouteId)
                .HasConstraintName("fk_pharm_routelists_pharm_routes_pharm_route_id");
        });

        modelBuilder.Entity<PregnancyHistoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pregnancy_history_data");

            entity.ToTable("pregnancy_history_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_pregnancy_history_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_pregnancy_history_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_pregnancy_history_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_pregnancy_history_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_pregnancy_history_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OutcomeDate).HasColumnName("outcome_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.PregnancyHistoryData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_pregnancy_history_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PregnancyHistoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_pregnancy_history_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PregnancyHistoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_pregnancy_history_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PregnancyHistoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_pregnancy_history_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.PregnancyHistoryData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_pregnancy_history_data_visits_visit_id");
        });

        modelBuilder.Entity<PregnancyOutcomeDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pregnancy_outcome_data");

            entity.ToTable("pregnancy_outcome_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_pregnancy_outcome_data_episode_care_id");

            entity.HasIndex(e => e.OutcomeId, "ix_pregnancy_outcome_data_outcome_id");

            entity.HasIndex(e => e.PatientId, "ix_pregnancy_outcome_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_pregnancy_outcome_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_pregnancy_outcome_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_pregnancy_outcome_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.NumberOfChildren).HasColumnName("number_of_children");
            entity.Property(e => e.OutcomeId).HasColumnName("outcome_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_pregnancy_outcome_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Outcome).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.OutcomeId)
                .HasConstraintName("fk_pregnancy_outcome_data_ehdsi_outcome_of_pregnancy_outcome_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_pregnancy_outcome_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_pregnancy_outcome_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_pregnancy_outcome_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.PregnancyOutcomeData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_pregnancy_outcome_data_visits_visit_id");
        });

        modelBuilder.Entity<PregnancyStatusDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pregnancy_status_data");

            entity.ToTable("pregnancy_status_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_pregnancy_status_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_pregnancy_status_data_patient_id");

            entity.HasIndex(e => e.PregnancyEstimatedId, "ix_pregnancy_status_data_pregnancy_estimated_id");

            entity.HasIndex(e => e.StatusId, "ix_pregnancy_status_data_status_id");

            entity.HasIndex(e => e.TenantId, "ix_pregnancy_status_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_pregnancy_status_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_pregnancy_status_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DateOfObservation).HasColumnName("date_of_observation");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.EstimatedDate).HasColumnName("estimated_date");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PregnancyEstimatedId).HasColumnName("pregnancy_estimated_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_pregnancy_status_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_pregnancy_status_data_patients_patient_id");

            entity.HasOne(d => d.PregnancyEstimated).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.PregnancyEstimatedId)
                .HasConstraintName("fk_pregnancy_status_data_ehdsi_pregnancy_information_pregnancy");

            entity.HasOne(d => d.Status).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("fk_pregnancy_status_data_ehdsi_current_pregnancy_status_status");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_pregnancy_status_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_pregnancy_status_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.PregnancyStatusData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_pregnancy_status_data_visits_visit_id");
        });

        modelBuilder.Entity<ProblemDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_problem_data");

            entity.ToTable("problem_data");

            entity.HasIndex(e => e.DiagnosisAssertionId, "ix_problem_data_diagnosis_assertion_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_problem_data_episode_care_id");

            entity.HasIndex(e => e.IllnessAndDisorderId, "ix_problem_data_illness_and_disorder_id");

            entity.HasIndex(e => e.PatientId, "ix_problem_data_patient_id");

            entity.HasIndex(e => e.ProblemId, "ix_problem_data_problem_id");

            entity.HasIndex(e => e.RareDiseaseId, "ix_problem_data_rare_disease_id");

            entity.HasIndex(e => e.StatusCodeId, "ix_problem_data_status_code_id");

            entity.HasIndex(e => e.TenantId, "ix_problem_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_problem_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_problem_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DiagnosisAssertionId).HasColumnName("diagnosis_assertion_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IllnessAndDisorderId).HasColumnName("illness_and_disorder_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDate).HasColumnName("on_set_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProblemId).HasColumnName("problem_id");
            entity.Property(e => e.RareDiseaseId).HasColumnName("rare_disease_id");
            entity.Property(e => e.ReplacementId).HasColumnName("replacement_id");
            entity.Property(e => e.ResolutionCircumstancesText).HasColumnName("resolution_circumstances_text");
            entity.Property(e => e.StatusCodeId).HasColumnName("status_code_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.DiagnosisAssertion).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.DiagnosisAssertionId)
                .HasConstraintName("fk_problem_data_ehdsi_certainty_diagnosis_assertion_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_problem_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.IllnessAndDisorder).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.IllnessAndDisorderId)
                .HasConstraintName("fk_problem_data_ehdsi_illnessand_disorder_illness_and_disorder");

            entity.HasOne(d => d.Patient).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_problem_data_patients_patient_id");

            entity.HasOne(d => d.Problem).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.ProblemId)
                .HasConstraintName("fk_problem_data_ehdsi_code_prob_problem_id");

            entity.HasOne(d => d.RareDisease).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.RareDiseaseId)
                .HasConstraintName("fk_problem_data_ehdsi_rare_disease_rare_disease_id");

            entity.HasOne(d => d.StatusCode).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.StatusCodeId)
                .HasConstraintName("fk_problem_data_ehdsi_status_code_status_code_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_problem_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_problem_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ProblemData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_problem_data_visits_visit_id");
        });

        modelBuilder.Entity<ProblemUnknownDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_problem_unknown_data");

            entity.ToTable("problem_unknown_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_problem_unknown_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_problem_unknown_data_patient_id");

            entity.HasIndex(e => e.ProblemId, "ix_problem_unknown_data_problem_id");

            entity.HasIndex(e => e.TenantId, "ix_problem_unknown_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_problem_unknown_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_problem_unknown_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProblemId).HasColumnName("problem_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_problem_unknown_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_problem_unknown_data_patients_patient_id");

            entity.HasOne(d => d.Problem).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.ProblemId)
                .HasConstraintName("fk_problem_unknown_data_ehdsi_absent_or_unknown_problem_proble");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_problem_unknown_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_problem_unknown_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ProblemUnknownData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_problem_unknown_data_visits_visit_id");
        });

        modelBuilder.Entity<ProcedureDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_procedure_data");

            entity.ToTable("procedure_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_procedure_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_procedure_data_patient_id");

            entity.HasIndex(e => e.ProcedureId, "ix_procedure_data_procedure_id");

            entity.HasIndex(e => e.TenantId, "ix_procedure_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_procedure_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_procedure_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BodySite).HasColumnName("body_site");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_procedure_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_procedure_data_patients_patient_id");

            entity.HasOne(d => d.Procedure).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.ProcedureId)
                .HasConstraintName("fk_procedure_data_ehdsi_procedure_procedure_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_procedure_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_procedure_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ProcedureData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_procedure_data_visits_visit_id");
        });

        modelBuilder.Entity<ProcedureUnknownDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_procedure_unknown_data");

            entity.ToTable("procedure_unknown_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_procedure_unknown_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_procedure_unknown_data_patient_id");

            entity.HasIndex(e => e.ProcedureId, "ix_procedure_unknown_data_procedure_id");

            entity.HasIndex(e => e.TenantId, "ix_procedure_unknown_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_procedure_unknown_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_procedure_unknown_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProcedureId).HasColumnName("procedure_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_procedure_unknown_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_procedure_unknown_data_patients_patient_id");

            entity.HasOne(d => d.Procedure).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.ProcedureId)
                .HasConstraintName("fk_procedure_unknown_data_ehdsi_absent_or_unknown_procedure_pr");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_procedure_unknown_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_procedure_unknown_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.ProcedureUnknownData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_procedure_unknown_data_visits_visit_id");
        });

        modelBuilder.Entity<QuestionPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_question_pages");

            entity.ToTable("question_pages", "quest");

            entity.HasIndex(e => e.QuestionnaireTemplateId, "ix_question_pages_questionnaire_template_id");

            entity.HasIndex(e => e.TitleTranslationId, "ix_question_pages_title_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.QuestionnaireTemplateId).HasColumnName("questionnaire_template_id");
            entity.Property(e => e.TitleTranslationId).HasColumnName("title_translation_id");

            entity.HasOne(d => d.QuestionnaireTemplate).WithMany(p => p.QuestionPages)
                .HasForeignKey(d => d.QuestionnaireTemplateId)
                .HasConstraintName("fk_question_pages_questionnaire_templates_questionnaire_templa");

            entity.HasOne(d => d.TitleTranslation).WithMany(p => p.QuestionPages)
                .HasForeignKey(d => d.TitleTranslationId)
                .HasConstraintName("fk_question_pages_translations_title_translation_id");
        });

        modelBuilder.Entity<QuestionTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_question_templates");

            entity.ToTable("question_templates", "quest");

            entity.HasIndex(e => e.DescriptionTranslationId, "ix_question_templates_description_translation_id");

            entity.HasIndex(e => e.QuestionPageId, "ix_question_templates_question_page_id");

            entity.HasIndex(e => e.QuestionTypeId, "ix_question_templates_question_type_id");

            entity.HasIndex(e => e.QuestionnaireTemplateId, "ix_question_templates_questionnaire_template_id");

            entity.HasIndex(e => e.TitleTranslationId, "ix_question_templates_title_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DescriptionTranslationId).HasColumnName("description_translation_id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.QuestionPageId).HasColumnName("question_page_id");
            entity.Property(e => e.QuestionTypeId).HasColumnName("question_type_id");
            entity.Property(e => e.QuestionnaireTemplateId).HasColumnName("questionnaire_template_id");
            entity.Property(e => e.TitleTranslationId).HasColumnName("title_translation_id");

            entity.HasOne(d => d.DescriptionTranslation).WithMany(p => p.QuestionTemplateDescriptionTranslations)
                .HasForeignKey(d => d.DescriptionTranslationId)
                .HasConstraintName("fk_question_templates_translations_description_translation_id");

            entity.HasOne(d => d.QuestionPage).WithMany(p => p.QuestionTemplates)
                .HasForeignKey(d => d.QuestionPageId)
                .HasConstraintName("fk_question_templates_question_pages_question_page_id");

            entity.HasOne(d => d.QuestionType).WithMany(p => p.QuestionTemplates)
                .HasForeignKey(d => d.QuestionTypeId)
                .HasConstraintName("fk_question_templates_question_types_question_type_id");

            entity.HasOne(d => d.QuestionnaireTemplate).WithMany(p => p.QuestionTemplates)
                .HasForeignKey(d => d.QuestionnaireTemplateId)
                .HasConstraintName("fk_question_templates_questionnaire_templates_questionnaire_te");

            entity.HasOne(d => d.TitleTranslation).WithMany(p => p.QuestionTemplateTitleTranslations)
                .HasForeignKey(d => d.TitleTranslationId)
                .HasConstraintName("fk_question_templates_translations_title_translation_id");
        });

        modelBuilder.Entity<QuestionTemplateValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_question_template_values");

            entity.ToTable("question_template_values", "quest");

            entity.HasIndex(e => e.QuestionTemplateId, "ix_question_template_values_question_template_id");

            entity.HasIndex(e => e.TranslationId, "ix_question_template_values_translation_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.QuestionTemplateId).HasColumnName("question_template_id");
            entity.Property(e => e.TranslationId).HasColumnName("translation_id");

            entity.HasOne(d => d.QuestionTemplate).WithMany(p => p.QuestionTemplateValues)
                .HasForeignKey(d => d.QuestionTemplateId)
                .HasConstraintName("fk_question_template_values_question_templates_question_templa");

            entity.HasOne(d => d.Translation).WithMany(p => p.QuestionTemplateValues)
                .HasForeignKey(d => d.TranslationId)
                .HasConstraintName("fk_question_template_values_translations_translation_id");
        });

        modelBuilder.Entity<QuestionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_question_types");

            entity.ToTable("question_types", "quest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<QuestionnaireDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_questionnaire_data");

            entity.ToTable("questionnaire_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_questionnaire_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_questionnaire_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_questionnaire_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_questionnaire_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_questionnaire_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activated).HasColumnName("activated");
            entity.Property(e => e.AnswerId).HasColumnName("answer_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QuestionnaireTemplateId).HasColumnName("questionnaire_template_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.QuestionnaireData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_questionnaire_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.QuestionnaireData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_questionnaire_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.QuestionnaireData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_questionnaire_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.QuestionnaireData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_questionnaire_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.QuestionnaireData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_questionnaire_data_visits_visit_id");
        });

        modelBuilder.Entity<QuestionnaireTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_questionnaire_templates");

            entity.ToTable("questionnaire_templates", "quest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_regions");

            entity.ToTable("regions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<RespiratoryClinicalExamination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_respiratory_clinical_examination");

            entity.ToTable("respiratory_clinical_examination");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<RespiratoryClinicalExaminationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_respiratory_clinical_examination_data");

            entity.ToTable("respiratory_clinical_examination_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_respiratory_clinical_examination_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_respiratory_clinical_examination_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_respiratory_clinical_examination_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_respiratory_clinical_examination_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_respiratory_clinical_examination_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.RespiratoryClinicalExaminationData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_respiratory_clinical_examination_data_episode_cares_episode");

            entity.HasOne(d => d.Patient).WithMany(p => p.RespiratoryClinicalExaminationData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_respiratory_clinical_examination_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.RespiratoryClinicalExaminationData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_respiratory_clinical_examination_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.RespiratoryClinicalExaminationData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_respiratory_clinical_examination_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.RespiratoryClinicalExaminationData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_respiratory_clinical_examination_data_visits_visit_id");

            entity.HasMany(d => d.RespiratoryClinicalExaminations).WithMany(p => p.RespiratoryClinicalExaminationData)
                .UsingEntity<Dictionary<string, object>>(
                    "RespiratoryClinicalExaminationDataItem",
                    r => r.HasOne<RespiratoryClinicalExamination>().WithMany()
                        .HasForeignKey("RespiratoryClinicalExaminationId")
                        .HasConstraintName("fk_respiratory_clinical_examination_data_items_respiratory_cli1"),
                    l => l.HasOne<RespiratoryClinicalExaminationDatum>().WithMany()
                        .HasForeignKey("RespiratoryClinicalExaminationDataId")
                        .HasConstraintName("fk_respiratory_clinical_examination_data_items_respiratory_cli"),
                    j =>
                    {
                        j.HasKey("RespiratoryClinicalExaminationDataId", "RespiratoryClinicalExaminationId").HasName("pk_respiratory_clinical_examination_data_items");
                        j.ToTable("respiratory_clinical_examination_data_items");
                        j.HasIndex(new[] { "RespiratoryClinicalExaminationId" }, "ix_respiratory_clinical_examination_data_items_respiratory_cli");
                        j.IndexerProperty<int>("RespiratoryClinicalExaminationDataId").HasColumnName("respiratory_clinical_examination_data_id");
                        j.IndexerProperty<int>("RespiratoryClinicalExaminationId").HasColumnName("respiratory_clinical_examination_id");
                    });
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles");

            entity.ToTable("roles");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OrderBy).HasColumnName("order_by");

            entity.HasMany(d => d.Modules).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "ModuleRole",
                    r => r.HasOne<Module>().WithMany()
                        .HasForeignKey("ModuleId")
                        .HasConstraintName("fk_module_roles_module_module_id"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_module_roles_roles_role_id"),
                    j =>
                    {
                        j.HasKey("RoleId", "ModuleId").HasName("pk_module_roles");
                        j.ToTable("module_roles");
                        j.HasIndex(new[] { "ModuleId" }, "ix_module_roles_module_id");
                        j.IndexerProperty<Guid>("RoleId").HasColumnName("role_id");
                        j.IndexerProperty<int>("ModuleId").HasColumnName("module_id");
                    });

            entity.HasMany(d => d.Permissions).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RolePermission",
                    r => r.HasOne<Permission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("fk_role_permissions_permissions_permission_id"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_role_permissions_roles_role_id"),
                    j =>
                    {
                        j.HasKey("RoleId", "PermissionId").HasName("pk_role_permissions");
                        j.ToTable("role_permissions");
                        j.HasIndex(new[] { "PermissionId" }, "ix_role_permissions_permission_id");
                        j.IndexerProperty<Guid>("RoleId").HasColumnName("role_id");
                        j.IndexerProperty<Guid>("PermissionId").HasColumnName("permission_id");
                    });
        });

        modelBuilder.Entity<SelfReportBodyPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_body_part");

            entity.ToTable("self_report_body_part");

            entity.HasIndex(e => e.SelfReportDataId, "ix_self_report_body_part_self_report_data_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.SelfReportDataId).HasColumnName("self_report_data_id");
            entity.Property(e => e.Slug).HasColumnName("slug");

            entity.HasOne(d => d.SelfReportData).WithMany(p => p.SelfReportBodyParts)
                .HasForeignKey(d => d.SelfReportDataId)
                .HasConstraintName("fk_self_report_body_part_self_report_data_self_report_data_id");
        });

        modelBuilder.Entity<SelfReportDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_data");

            entity.ToTable("self_report_data");

            entity.HasIndex(e => e.MedicationFrequencyId, "ix_self_report_data_medication_frequency_id");

            entity.HasIndex(e => e.PainLevelId, "ix_self_report_data_pain_level_id");

            entity.HasIndex(e => e.PatientId, "ix_self_report_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_self_report_data_tenant_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MedicationFrequencyId).HasColumnName("medication_frequency_id");
            entity.Property(e => e.PainLevelId).HasColumnName("pain_level_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.MedicationFrequency).WithMany(p => p.SelfReportData)
                .HasForeignKey(d => d.MedicationFrequencyId)
                .HasConstraintName("fk_self_report_data_self_report_medication_frequency_medicatio");

            entity.HasOne(d => d.PainLevel).WithMany(p => p.SelfReportData)
                .HasForeignKey(d => d.PainLevelId)
                .HasConstraintName("fk_self_report_data_self_report_pain_level_pain_level_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.SelfReportData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_self_report_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SelfReportData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_self_report_data_tenant_tenant_id");
        });

        modelBuilder.Entity<SelfReportMedicationFrequency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_medication_frequency");

            entity.ToTable("self_report_medication_frequency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<SelfReportPainLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_pain_level");

            entity.ToTable("self_report_pain_level");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Range).HasColumnName("range");
        });

        modelBuilder.Entity<SelfReportSymptom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_symptoms");

            entity.ToTable("self_report_symptoms");

            entity.HasIndex(e => e.SelfReportDataId, "ix_self_report_symptoms_self_report_data_id");

            entity.HasIndex(e => e.SymptomLookupId, "ix_self_report_symptoms_symptom_lookup_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SelfReportDataId).HasColumnName("self_report_data_id");
            entity.Property(e => e.SymptomLookupId).HasColumnName("symptom_lookup_id");

            entity.HasOne(d => d.SelfReportData).WithMany(p => p.SelfReportSymptoms)
                .HasForeignKey(d => d.SelfReportDataId)
                .HasConstraintName("fk_self_report_symptoms_self_report_data_self_report_data_id");

            entity.HasOne(d => d.SymptomLookup).WithMany(p => p.SelfReportSymptoms)
                .HasForeignKey(d => d.SymptomLookupId)
                .HasConstraintName("fk_self_report_symptoms_self_report_symptom_lookup_symptom_loo");
        });

        modelBuilder.Entity<SelfReportSymptomLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_symptom_lookup");

            entity.ToTable("self_report_symptom_lookup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<SelfReportTimeOfDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_time_of_day");

            entity.ToTable("self_report_time_of_day");

            entity.HasIndex(e => e.SelfReportDataId, "ix_self_report_time_of_day_self_report_data_id");

            entity.HasIndex(e => e.TimeOfDayLookupId, "ix_self_report_time_of_day_time_of_day_lookup_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SelfReportDataId).HasColumnName("self_report_data_id");
            entity.Property(e => e.TimeOfDayLookupId).HasColumnName("time_of_day_lookup_id");

            entity.HasOne(d => d.SelfReportData).WithMany(p => p.SelfReportTimeOfDays)
                .HasForeignKey(d => d.SelfReportDataId)
                .HasConstraintName("fk_self_report_time_of_day_self_report_data_self_report_data_id");

            entity.HasOne(d => d.TimeOfDayLookup).WithMany(p => p.SelfReportTimeOfDays)
                .HasForeignKey(d => d.TimeOfDayLookupId)
                .HasConstraintName("fk_self_report_time_of_day_self_report_time_of_day_lookup_time");
        });

        modelBuilder.Entity<SelfReportTimeOfDayLookup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_self_report_time_of_day_lookup");

            entity.ToTable("self_report_time_of_day_lookup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<SmartHealthLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_smart_health_links");

            entity.ToTable("smart_health_links");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccessCount)
                .HasDefaultValue(0)
                .HasColumnName("access_count");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("creation_date");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DeletedDate).HasColumnName("deleted_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.FailedAccessCount)
                .HasDefaultValue(0)
                .HasColumnName("failed_access_count");
            entity.Property(e => e.FileName).HasColumnName("file_name");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.Manifest).HasColumnName("manifest");
            entity.Property(e => e.Passcode).HasColumnName("passcode");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
        });

        modelBuilder.Entity<SocialHistoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_social_history_data");

            entity.ToTable("social_history_data");

            entity.HasIndex(e => e.CustomTimingUnitId, "ix_social_history_data_custom_timing_unit_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_social_history_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_social_history_data_patient_id");

            entity.HasIndex(e => e.SocialHistoryId, "ix_social_history_data_social_history_id");

            entity.HasIndex(e => e.TenantId, "ix_social_history_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_social_history_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_social_history_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.CustomTimingUnitId).HasColumnName("custom_timing_unit_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.SocialHistoryId).HasColumnName("social_history_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UnitAmount).HasColumnName("unit_amount");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.CustomTimingUnit).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.CustomTimingUnitId)
                .HasConstraintName("fk_social_history_data_master_timing_unit_custom_timing_unit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_social_history_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_social_history_data_patients_patient_id");

            entity.HasOne(d => d.SocialHistory).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.SocialHistoryId)
                .HasConstraintName("fk_social_history_data_ehdsi_social_history_social_history_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_social_history_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_social_history_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.SocialHistoryData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_social_history_data_visits_visit_id");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_status");

            entity.ToTable("status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tenant");

            entity.ToTable("tenant");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasMany(d => d.Departments).WithMany(p => p.Tenants)
                .UsingEntity<Dictionary<string, object>>(
                    "TenantDepartment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("fk_tenant_departments_departments_department_id"),
                    l => l.HasOne<Tenant>().WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_tenant_departments_tenant_tenant_id"),
                    j =>
                    {
                        j.HasKey("TenantId", "DepartmentId").HasName("pk_tenant_departments");
                        j.ToTable("tenant_departments");
                        j.HasIndex(new[] { "DepartmentId" }, "ix_tenant_departments_department_id");
                        j.IndexerProperty<int>("TenantId").HasColumnName("tenant_id");
                        j.IndexerProperty<int>("DepartmentId").HasColumnName("department_id");
                    });

            entity.HasMany(d => d.Packages).WithMany(p => p.Tenants)
                .UsingEntity<Dictionary<string, object>>(
                    "TenantPackage",
                    r => r.HasOne<Package>().WithMany()
                        .HasForeignKey("PackageId")
                        .HasConstraintName("fk_tenant_packages_packages_package_id"),
                    l => l.HasOne<Tenant>().WithMany()
                        .HasForeignKey("TenantId")
                        .HasConstraintName("fk_tenant_packages_tenant_tenant_id"),
                    j =>
                    {
                        j.HasKey("TenantId", "PackageId").HasName("pk_tenant_packages");
                        j.ToTable("tenant_packages");
                        j.HasIndex(new[] { "PackageId" }, "ix_tenant_packages_package_id");
                        j.IndexerProperty<int>("TenantId").HasColumnName("tenant_id");
                        j.IndexerProperty<int>("PackageId").HasColumnName("package_id");
                    });
        });

        modelBuilder.Entity<TenantSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tenant_settings");

            entity.ToTable("tenant_settings");

            entity.HasIndex(e => e.AddressDataId, "ix_tenant_settings_address_data_id");

            entity.HasIndex(e => e.TenantId, "ix_tenant_settings_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_tenant_settings_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressDataId).HasColumnName("address_data_id");
            entity.Property(e => e.CompanyEmail).HasColumnName("company_email");
            entity.Property(e => e.CompanyName).HasColumnName("company_name");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.FavIconPath).HasColumnName("fav_icon_path");
            entity.Property(e => e.IncludeAppPatient).HasColumnName("include_app_patient");
            entity.Property(e => e.IncludePreRegistration).HasColumnName("include_pre_registration");
            entity.Property(e => e.InvoiceLogoPath).HasColumnName("invoice_logo_path");
            entity.Property(e => e.IsPilotStudy).HasColumnName("is_pilot_study");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.LogoPath).HasColumnName("logo_path");
            entity.Property(e => e.MaxUserLimit).HasColumnName("max_user_limit");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AddressData).WithMany(p => p.TenantSettings)
                .HasForeignKey(d => d.AddressDataId)
                .HasConstraintName("fk_tenant_settings_address_data_address_data_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantSettings)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_tenant_settings_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.TenantSettings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_tenant_settings_users_user_id");
        });

        modelBuilder.Entity<TracheostomyConsistencyOfTube>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_consistency_of_tubes");

            entity.ToTable("tracheostomy_consistency_of_tubes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TracheostomyCtParametersDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_ct_parameters_data");

            entity.ToTable("tracheostomy_ct_parameters_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_tracheostomy_ct_parameters_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_tracheostomy_ct_parameters_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_tracheostomy_ct_parameters_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_tracheostomy_ct_parameters_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_tracheostomy_ct_parameters_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnatomicalVariations).HasColumnName("anatomical_variations");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DepthOfTrachea).HasColumnName("depth_of_trachea");
            entity.Property(e => e.DistanceBetweenTrachealCartilages).HasColumnName("distance_between_tracheal_cartilages");
            entity.Property(e => e.DistanceFromCricothyroidToCarina).HasColumnName("distance_from_cricothyroid_to_carina");
            entity.Property(e => e.DistanceFromSkinToTrachea).HasColumnName("distance_from_skin_to_trachea");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.TracheostomyCtParametersData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_tracheostomy_ct_parameters_data_episode_cares_episode_care_");

            entity.HasOne(d => d.Patient).WithMany(p => p.TracheostomyCtParametersData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_tracheostomy_ct_parameters_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TracheostomyCtParametersData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_tracheostomy_ct_parameters_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.TracheostomyCtParametersData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_tracheostomy_ct_parameters_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.TracheostomyCtParametersData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_tracheostomy_ct_parameters_data_visits_visit_id");
        });

        modelBuilder.Entity<TracheostomyCuffDiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_cuff_diameters");

            entity.ToTable("tracheostomy_cuff_diameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TracheostomyInnerDiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_inner_diameters");

            entity.ToTable("tracheostomy_inner_diameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TracheostomyOuterDiameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_outer_diameters");

            entity.ToTable("tracheostomy_outer_diameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TracheostomyTubeCharacteristicsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_tube_characteristics_data");

            entity.ToTable("tracheostomy_tube_characteristics_data");

            entity.HasIndex(e => e.ConsistencyOfTubeId, "ix_tracheostomy_tube_characteristics_data_consistency_of_tube_");

            entity.HasIndex(e => e.CuffDiameterId, "ix_tracheostomy_tube_characteristics_data_cuff_diameter_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_tracheostomy_tube_characteristics_data_episode_care_id");

            entity.HasIndex(e => e.InnerDiameterId, "ix_tracheostomy_tube_characteristics_data_inner_diameter_id");

            entity.HasIndex(e => e.OuterDiameterId, "ix_tracheostomy_tube_characteristics_data_outer_diameter_id");

            entity.HasIndex(e => e.PatientId, "ix_tracheostomy_tube_characteristics_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_tracheostomy_tube_characteristics_data_tenant_id");

            entity.HasIndex(e => e.TubeLengthId, "ix_tracheostomy_tube_characteristics_data_tube_length_id");

            entity.HasIndex(e => e.TubeTypeId, "ix_tracheostomy_tube_characteristics_data_tube_type_id");

            entity.HasIndex(e => e.UserId, "ix_tracheostomy_tube_characteristics_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_tracheostomy_tube_characteristics_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConsistencyOfTubeId).HasColumnName("consistency_of_tube_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.CuffDiameterId).HasColumnName("cuff_diameter_id");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.InnerDiameterId).HasColumnName("inner_diameter_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OuterDiameterId).HasColumnName("outer_diameter_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TubeLengthId).HasColumnName("tube_length_id");
            entity.Property(e => e.TubeTypeId).HasColumnName("tube_type_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.ConsistencyOfTube).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.ConsistencyOfTubeId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_consist");

            entity.HasOne(d => d.CuffDiameter).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.CuffDiameterId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_cuff_di");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_episode_cares_episod");

            entity.HasOne(d => d.InnerDiameter).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.InnerDiameterId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_inner_d");

            entity.HasOne(d => d.OuterDiameter).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.OuterDiameterId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_outer_d");

            entity.HasOne(d => d.Patient).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tenant_tenant_id");

            entity.HasOne(d => d.TubeLength).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.TubeLengthId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_tube_le");

            entity.HasOne(d => d.TubeType).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.TubeTypeId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_tracheostomy_tube_ty");

            entity.HasOne(d => d.User).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.TracheostomyTubeCharacteristicsData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_tracheostomy_tube_characteristics_data_visits_visit_id");
        });

        modelBuilder.Entity<TracheostomyTubeInspection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_tube_inspection");

            entity.ToTable("tracheostomy_tube_inspection");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<TracheostomyTubeInspectionDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_tube_inspection_data");

            entity.ToTable("tracheostomy_tube_inspection_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_tracheostomy_tube_inspection_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_tracheostomy_tube_inspection_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_tracheostomy_tube_inspection_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_tracheostomy_tube_inspection_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_tracheostomy_tube_inspection_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.TracheostomyTubeInspectionData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_tracheostomy_tube_inspection_data_episode_cares_episode_car");

            entity.HasOne(d => d.Patient).WithMany(p => p.TracheostomyTubeInspectionData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_tracheostomy_tube_inspection_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TracheostomyTubeInspectionData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_tracheostomy_tube_inspection_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.TracheostomyTubeInspectionData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_tracheostomy_tube_inspection_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.TracheostomyTubeInspectionData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_tracheostomy_tube_inspection_data_visits_visit_id");

            entity.HasMany(d => d.TracheostomyTubeInspections).WithMany(p => p.TracheostomyTubeInspectionData)
                .UsingEntity<Dictionary<string, object>>(
                    "TracheostomyTubeInspectionDataItem",
                    r => r.HasOne<TracheostomyTubeInspection>().WithMany()
                        .HasForeignKey("TracheostomyTubeInspectionId")
                        .HasConstraintName("fk_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i1"),
                    l => l.HasOne<TracheostomyTubeInspectionDatum>().WithMany()
                        .HasForeignKey("TracheostomyTubeInspectionDataId")
                        .HasConstraintName("fk_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i"),
                    j =>
                    {
                        j.HasKey("TracheostomyTubeInspectionDataId", "TracheostomyTubeInspectionId").HasName("pk_tracheostomy_tube_inspection_data_items");
                        j.ToTable("tracheostomy_tube_inspection_data_items");
                        j.HasIndex(new[] { "TracheostomyTubeInspectionId" }, "ix_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i");
                        j.IndexerProperty<int>("TracheostomyTubeInspectionDataId").HasColumnName("tracheostomy_tube_inspection_data_id");
                        j.IndexerProperty<int>("TracheostomyTubeInspectionId").HasColumnName("tracheostomy_tube_inspection_id");
                    });
        });

        modelBuilder.Entity<TracheostomyTubeLength>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_tube_lengths");

            entity.ToTable("tracheostomy_tube_lengths");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<TracheostomyTubeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_tracheostomy_tube_types");

            entity.ToTable("tracheostomy_tube_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Translation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_translations");

            entity.ToTable("translations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DefaultLabel).HasColumnName("default_label");
            entity.Property(e => e.En).HasColumnName("en");
            entity.Property(e => e.Gr).HasColumnName("gr");
        });

        modelBuilder.Entity<Translation1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_translations");

            entity.ToTable("translations", "quest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.En).HasColumnName("en");
            entity.Property(e => e.Gr).HasColumnName("gr");
        });

        modelBuilder.Entity<TravelHistoryDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_travel_history_data");

            entity.ToTable("travel_history_data");

            entity.HasIndex(e => e.CountryId, "ix_travel_history_data_country_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_travel_history_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_travel_history_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_travel_history_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_travel_history_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_travel_history_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArrivalDate).HasColumnName("arrival_date");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DepartureDate).HasColumnName("departure_date");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.Country).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_travel_history_data_ehdsi_country_country_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_travel_history_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_travel_history_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_travel_history_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_travel_history_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.TravelHistoryData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_travel_history_data_visits_visit_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Locale).HasColumnName("locale");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.RequiredActions).HasColumnName("required_actions");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.Username).HasColumnName("username");

            entity.HasMany(d => d.Permissions).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserPermission",
                    r => r.HasOne<Permission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("fk_user_permissions_permissions_permission_id"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_permissions_users_user_id"),
                    j =>
                    {
                        j.HasKey("UserId", "PermissionId").HasName("pk_user_permissions");
                        j.ToTable("user_permissions");
                        j.HasIndex(new[] { "PermissionId" }, "ix_user_permissions_permission_id");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("user_id");
                        j.IndexerProperty<Guid>("PermissionId").HasColumnName("permission_id");
                    });

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_user_roles_roles_role_id"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_roles_users_user_id"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("pk_user_roles");
                        j.ToTable("user_roles");
                        j.HasIndex(new[] { "RoleId" }, "ix_user_roles_role_id");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("user_id");
                        j.IndexerProperty<Guid>("RoleId").HasColumnName("role_id");
                    });
        });

        modelBuilder.Entity<VaccinationDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_vaccination_data");

            entity.ToTable("vaccination_data");

            entity.HasIndex(e => e.AdministeringCenterId, "ix_vaccination_data_administering_center_id");

            entity.HasIndex(e => e.CountryId, "ix_vaccination_data_country_id");

            entity.HasIndex(e => e.DiseaseTargetedId, "ix_vaccination_data_disease_targeted_id");

            entity.HasIndex(e => e.DoctorId, "ix_vaccination_data_doctor_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_vaccination_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_vaccination_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_vaccination_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_vaccination_data_user_id");

            entity.HasIndex(e => e.VaccineId, "ix_vaccination_data_vaccine_id");

            entity.HasIndex(e => e.VisitId, "ix_vaccination_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdministeringCenterId).HasColumnName("administering_center_id");
            entity.Property(e => e.BatchLotNumber).HasColumnName("batch_lot_number");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DiseaseTargetedId).HasColumnName("disease_targeted_id");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.MarketingAuthorizationHolder).HasColumnName("marketing_authorization_holder");
            entity.Property(e => e.MedicinalProductName).HasColumnName("medicinal_product_name");
            entity.Property(e => e.NextDate).HasColumnName("next_date");
            entity.Property(e => e.NumSeriesDoses).HasColumnName("num_series_doses");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.AdministeringCenter).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.AdministeringCenterId)
                .HasConstraintName("fk_vaccination_data_tenant_settings_administering_center_id");

            entity.HasOne(d => d.Country).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_vaccination_data_ehdsi_country_country_id");

            entity.HasOne(d => d.DiseaseTargeted).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.DiseaseTargetedId)
                .HasConstraintName("fk_vaccination_data_ehdsi_illnessand_disorder_disease_targeted");

            entity.HasOne(d => d.Doctor).WithMany(p => p.VaccinationDatumDoctors)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("fk_vaccination_data_users_doctor_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_vaccination_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_vaccination_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_vaccination_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.VaccinationDatumUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_vaccination_data_users_user_id");

            entity.HasOne(d => d.Vaccine).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.VaccineId)
                .HasConstraintName("fk_vaccination_data_ehdsi_vaccine_vaccine_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.VaccinationData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_vaccination_data_visits_visit_id");
        });

        modelBuilder.Entity<ValueSet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_value_set");

            entity.ToTable("value_set");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_visits");

            entity.ToTable("visits");

            entity.HasIndex(e => e.DoctorId, "ix_visits_doctor_id");

            entity.HasIndex(e => e.EpisodeCareId, "ix_visits_episode_care_id");

            entity.HasIndex(e => e.PotentialDiagnosisId, "ix_visits_potential_diagnosis_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsCompleted).HasColumnName("is_completed");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PotentialDiagnosisId).HasColumnName("potential_diagnosis_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Visits)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("fk_visits_users_doctor_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.Visits)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_visits_episode_cares_episode_care_id");

            entity.HasOne(d => d.PotentialDiagnosis).WithMany(p => p.Visits)
                .HasForeignKey(d => d.PotentialDiagnosisId)
                .HasConstraintName("fk_visits_ehdsi_illnessand_disorder_potential_diagnosis_id");
        });

        modelBuilder.Entity<VitalSignDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_vital_sign_data");

            entity.ToTable("vital_sign_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_vital_sign_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_vital_sign_data_patient_id");

            entity.HasIndex(e => e.TenantId, "ix_vital_sign_data_tenant_id");

            entity.HasIndex(e => e.UserId, "ix_vital_sign_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_vital_sign_data_visit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.DiastolicBloodPressure).HasColumnName("diastolic_blood_pressure");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.HeartRate).HasColumnName("heart_rate");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OnSetDateTime).HasColumnName("on_set_date_time");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RespiratoryRate).HasColumnName("respiratory_rate");
            entity.Property(e => e.SpO2).HasColumnName("sp_o2");
            entity.Property(e => e.SystolicBloodPressure).HasColumnName("systolic_blood_pressure");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.UrineOutput).HasColumnName("urine_output");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.VitalSignData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_vital_sign_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.VitalSignData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_vital_sign_data_patients_patient_id");

            entity.HasOne(d => d.Tenant).WithMany(p => p.VitalSignData)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("fk_vital_sign_data_tenant_tenant_id");

            entity.HasOne(d => d.User).WithMany(p => p.VitalSignData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_vital_sign_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.VitalSignData)
                .HasForeignKey(d => d.VisitId)
                .HasConstraintName("fk_vital_sign_data_visits_visit_id");
        });

        modelBuilder.Entity<WeightDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_patient_weight_data");

            entity.ToTable("weight_data");

            entity.HasIndex(e => e.EpisodeCareId, "ix_patient_weight_data_episode_care_id");

            entity.HasIndex(e => e.PatientId, "ix_patient_weight_data_patient_id");

            entity.HasIndex(e => e.UserId, "ix_patient_weight_data_user_id");

            entity.HasIndex(e => e.VisitId, "ix_patient_weight_data_visit_id");

            entity.HasIndex(e => e.TenantId, "ix_weight_data_tenant_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EpisodeCareId).HasColumnName("episode_care_id");
            entity.Property(e => e.IsSubmitted).HasColumnName("is_submitted");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TenantId)
                .HasDefaultValue(0)
                .HasColumnName("tenant_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.EpisodeCare).WithMany(p => p.WeightData)
                .HasForeignKey(d => d.EpisodeCareId)
                .HasConstraintName("fk_patient_weight_data_episode_cares_episode_care_id");

            entity.HasOne(d => d.Patient).WithMany(p => p.WeightData)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("fk_patient_weight_data_patients_patient_id");

            entity.HasOne(d => d.User).WithMany(p => p.WeightData)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_patient_weight_data_users_user_id");

            entity.HasOne(d => d.Visit).WithMany(p => p.WeightData)
                .HasForeignKey(d => d.VisitId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_weight_data_visits_visit_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
