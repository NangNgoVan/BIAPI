using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class MedicalAttentionServiceModel {
    public string MedicalServiceId {get;set;}
    public string PatientCode{get;set;}
    public DateTime BeganTreamentDateTime {get;set;}
    public DateTime ReveicedTreamentDateTime {get;set;}
    public DateTime EndedTreamentDateTime {get;set;}
    public int Quantity {get;set;}
    public decimal Price {get;set;}
    public bool HealthInsurranceSuggest{get;set;}
    public bool HealthInsurrancePayment{get;set;}
    public string MedicalEquipmentId{get;set;}
    public int IsResidentTreament{get;set;}
    public string DoctorId{get;set;}
    public string ClinicId{get;set;}
    public string OutpaymentDeptId{get;set;}
    public string HospitalId{get;set;}
}