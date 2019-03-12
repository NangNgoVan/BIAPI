using System;
using System.Collections.Generic;
using BIApi.DBContext;
public class DataService {
    private static readonly DB dbCtx = new DB();

    public static ResultModel LoadDimDoctor (List<DoctorModel> data){
        var result = new ResultModel();
         try {
            foreach(var doctor in data) {
                dbCtx.Doctors.Add(doctor);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        } catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }

    public static ResultModel LoadDimMedicalDisease(List<MedicalDiseaseModel> data){
        var result = new ResultModel();
        try {
            foreach(var disease in data) {
                dbCtx.MedicalDiseases.Add(disease);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimMedicalDiseaseType(List<MedicalDiseaseTypeModel> data){
        var result = new ResultModel();
        try {
            foreach(var diseaseType in data) {
                dbCtx.MedicalDiseaseTypes.Add(diseaseType);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimClinic(List<ClinicModel> data){
        var result = new ResultModel();
        try {
            foreach(var clinic in data) {
                dbCtx.Clinics.Add(clinic);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimOupatientDept(List<OutpatientDeptModel> data){
        var result = new ResultModel();
        try {
            foreach(var outpatientDept in data) {
                dbCtx.OutpatientDepts.Add(outpatientDept);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimHospital(List<HospitalModel> data){
        var result = new ResultModel();
        try {
            foreach(var hospital in data) {
                dbCtx.Hospitals.Add(hospital);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimMedicalEquipment(List<MedicalEquipmentModel> data){
        var result = new ResultModel();
        try {
            foreach(var medicalEquipment in data) {
                dbCtx.MedicalEquipments.Add(medicalEquipment);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
     public static ResultModel LoadDimMedicalProfession(List<MedicalProfessionModel> data){
        var result = new ResultModel();
        try {
            foreach(var medicalProfession in data) {
                dbCtx.MedicalProfessions.Add(medicalProfession);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimIllnessState(List<IllnessStateModel> data){
        var result = new ResultModel();
        try {
            foreach(var illnessState in data) {
                dbCtx.IllnessStates.Add(illnessState);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimMedicalService(List<MedicalServiceModel> data){
        var result = new ResultModel();
        try {
            foreach(var medicalService in data) {
                dbCtx.MedicalServices.Add(medicalService);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimMedicalServiceGroup(List<MedicalServiceGroupModel> data){
        var result = new ResultModel();
        try {
            foreach(var medicalServiceGroup in data) {
                dbCtx.MedicalServiceGroups.Add(medicalServiceGroup);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel LoadDimMedicalServiceType(List<MedicalServiceTypeModel> data){
        var result = new ResultModel();
        try {
            foreach(var medicalServiceType in data) {
                dbCtx.MedicalServiceTypes.Add(medicalServiceType);
            }
            dbCtx.SaveChanges();
            result.IsError = false;
            result.Data = data;
        }
        catch(Exception e) {
            result.IsError = true;
            result.Message = e.Message;
        }
        return result;
    }
    public static ResultModel ETLMedicalAttentionServiceFact(List<TreatmentFactModel> data){
        var result = new ResultModel();
        // ...
        return result;
    }
}