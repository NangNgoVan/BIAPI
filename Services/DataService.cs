using BIApi.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;

public class DataService {
    private static readonly DB dbCtx = new DB();

    public static ResultModel LoadDimDoctor (List<DoctorModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.Doctors;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var doctor in data)
                {
                    var entry = dbCtx.Doctors.Find(doctor.DoctorId);
                    if (entry == null)
                    {
                        dbCtx.Doctors.Add(doctor);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }
           
        return result;

    }
    public static ResultModel LoadDimMedicalDisease(List<MedicalDiseaseModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalDiseases;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var disease in data)
                {
                    var entry = dbCtx.MedicalDiseases.Find(disease.DiseaseId);
                    if (entry == null)
                    {
                        dbCtx.MedicalDiseases.Add(disease);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalDiseaseType(List<MedicalDiseaseTypeModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalDiseaseTypes;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var diseaseType in data)
                {
                    var entry = dbCtx.MedicalDiseaseTypes.Find(diseaseType.DiseaseTypeId);
                    if (entry == null)
                    {
                        dbCtx.MedicalDiseaseTypes.Add(diseaseType);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimClinic(List<ClinicModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.Clinics;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var clinic in data)
                {
                    var entry = dbCtx.Clinics.Find(clinic.ClinicId, clinic.OutPatientDeptId, clinic.HospitalId);
                    if (entry == null)
                    {
                        dbCtx.Clinics.Add(clinic);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimOupatientDept(List<OutpatientDeptModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.OutpatientDepts;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var outpatientDept in data)
                {
                    var entry = dbCtx.OutpatientDepts.Find(outpatientDept.OutpatientDeptId, outpatientDept.HospitalId);
                    if (entry == null)
                    {
                        dbCtx.OutpatientDepts.Add(outpatientDept);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimHospital(List<HospitalModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.Hospitals;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var hosptital in data)
                {
                    var entry = dbCtx.Hospitals.Find(hosptital.HospitalId);
                    if (entry == null)
                    {
                        dbCtx.Hospitals.Add(hosptital);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalEquipment(List<MedicalEquipmentModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalEquipments;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var equipment in data)
                {
                    var entry = dbCtx.MedicalEquipments.Find(equipment.MedicalEquipmentId);
                    if (entry == null)
                    {
                        dbCtx.MedicalEquipments.Add(equipment);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalProfession(List<MedicalProfessionModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalProfessions;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var medicalProfession in data)
                {
                    var entry = dbCtx.MedicalProfessions.Find(medicalProfession.MedicalProfessionId);
                    if (entry == null)
                    {
                        dbCtx.MedicalProfessions.Add(medicalProfession);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimIllnessState(List<IllnessStateModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.IllnessStates;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var illnessState in data)
                {
                    var entry = dbCtx.IllnessStates.Find(illnessState.IllnessStateId);
                    if (entry == null)
                    {
                        dbCtx.IllnessStates.Add(illnessState);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalService(List<MedicalServiceModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalServices;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var medicalService in data)
                {
                    var entry = dbCtx.MedicalServices.Find(medicalService.MedicalServiceId);
                    if (entry == null)
                    {
                        dbCtx.MedicalServices.Add(medicalService);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalServiceGroup(List<MedicalServiceGroupModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalServiceGroups;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var medicalServiceGroup in data)
                {
                    var entry = dbCtx.MedicalServiceGroups.Find(medicalServiceGroup.MedicalServiceGroupId);
                    if (entry == null)
                    {
                        dbCtx.MedicalServiceGroups.Add(medicalServiceGroup);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadDimMedicalServiceType(List<MedicalServiceTypeModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                // truncate
                var items = dbCtx.MedicalServiceTypes;
                dbCtx.RemoveRange(items);
                dbCtx.SaveChanges();
                foreach (var medicalServiceType in data)
                {
                    var entry = dbCtx.MedicalServiceTypes.Find(medicalServiceType.MedicalServiceTypeId);
                    if (entry == null)
                    {
                        dbCtx.MedicalServiceTypes.Add(medicalServiceType);
                    }

                }
                dbCtx.SaveChanges();
                transaction.Commit();
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
            }
            catch (Exception e)
            {
                result.IsError = true;
                result.Message = e.Message;
            }
        }

        return result;
    }
    public static ResultModel LoadMedicalAttentionServiceFact(List<TreatmentJsonModel> data){
        var result = new ResultModel();
        using (var transaction = dbCtx.Database.BeginTransaction())
        {
            try
            {
                foreach(var treatmentFactItem in data)
                {
                    // patient info
                    var patientEntry = dbCtx.PatientInfos.Find(treatmentFactItem.patient.PatientId);
                    if (patientEntry == null)
                    {
                        dbCtx.PatientInfos.Add(treatmentFactItem.patient);
                    }
                    else
                    {
                        dbCtx.PatientInfos.Remove(patientEntry);
                        dbCtx.PatientInfos.Add(treatmentFactItem.patient);
                    }  
                    dbCtx.SaveChanges();
                    // medical service
                    // truncate
                    var medicalServiceLists = dbCtx.MedicalAttentionServices.Where(m => m.PatientCode == treatmentFactItem.PatientCode);
                    dbCtx.MedicalAttentionServices.RemoveRange(medicalServiceLists);
                    // insert
                    foreach (var medicalAttentionJsonItem in treatmentFactItem.treamentServices)
                    {
                        var medicalAttentionServiceItem = (MedicalAttentionServiceModel)medicalAttentionJsonItem;
                        medicalAttentionServiceItem.PatientCode = treatmentFactItem.PatientCode;
                        var entry = dbCtx.MedicalAttentionServices.Find(medicalAttentionServiceItem.MedicalServiceId, medicalAttentionServiceItem.PatientCode);
                        if (entry == null)
                        {
                            dbCtx.MedicalAttentionServices.Add(medicalAttentionServiceItem);
                        }
                        else
                        {
                            dbCtx.MedicalAttentionServices.Remove(entry);
                            dbCtx.MedicalAttentionServices.Add(medicalAttentionServiceItem);
                        }
                    }
                    dbCtx.SaveChanges();
                    // medical attension
                    // truncate
                    var medicalAttensionList = dbCtx.MedicalAttentions.Where(m => m.PatientCode == treatmentFactItem.PatientCode);
                    dbCtx.MedicalAttentions.RemoveRange(medicalAttensionList);
                    // insert
                    MedicalAttentionModel medicalAttentionItem = new MedicalAttentionModel
                    {
                        PatientCode = treatmentFactItem.PatientCode,
                        PatientId = treatmentFactItem.patient.PatientId,
                        IllnessStateId = treatmentFactItem.IllnessStateId
                    };
                    var medicalAttentionEntry = dbCtx.MedicalAttentions.Find(medicalAttentionItem.PatientCode);
                    if (medicalAttentionEntry == null)
                    {
                        dbCtx.MedicalAttentions.Add(medicalAttentionItem);
                    }
                    else
                    {
                        dbCtx.MedicalAttentions.Remove(medicalAttentionEntry);
                        dbCtx.MedicalAttentions.Add(medicalAttentionItem);
                    }
                    dbCtx.SaveChanges();
                    // medical attension disease
                    // truncate
                    var medicalAttensionDiseaseList = dbCtx.MedicalAttensionDiseases.Where(m => m.PatientCode == treatmentFactItem.PatientCode);
                    dbCtx.MedicalAttensionDiseases.RemoveRange(medicalAttensionDiseaseList);
                    // insert
                    foreach (var diseaseId in treatmentFactItem.diseaseIds)
                    {
                        MedicalAttensionDiseaseModel medicalAttensionDiseaseItem = new MedicalAttensionDiseaseModel()
                        {
                            PatientCode = treatmentFactItem.PatientCode,
                            DiseaseId = diseaseId
                        };
                        var entry = dbCtx.MedicalAttensionDiseases.Find(treatmentFactItem.PatientCode, diseaseId);
                        if (entry == null)
                        {
                            dbCtx.MedicalAttensionDiseases.Add(medicalAttensionDiseaseItem);
                        }
                        else
                        {
                            dbCtx.MedicalAttensionDiseases.Remove(entry);
                            dbCtx.MedicalAttensionDiseases.Add(medicalAttensionDiseaseItem);
                        }
                    }
                    dbCtx.SaveChanges();
                }

                result.IsError = false;
                result.Message = nameof(BIApi.Enums.Code.SUCCESS);
                result.Data = data;
                transaction.Commit();
            }
            catch(Exception e)
            {
                //
                result.IsError = true;
                result.Message = e.Message;
            }
        }
        return result;
    }
}