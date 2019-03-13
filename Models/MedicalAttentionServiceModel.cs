using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class MedicalAttentionServiceModel {
    [Key]
    public string MedicalServiceId {get;set;} // mã dịch vụ khám
    public string PatientCode{get;set;} // mã lần khám
    public DateTime BeganTreamentDateTime {get;set;} // thời gian chỉ định khám
    public DateTime ReveicedTreamentDateTime {get;set;} // thời gian bắt đầu vào khám
    public DateTime EndedTreamentDateTime {get;set;} // thời gian kết thúc khám
    public int Quantity {get;set;} // số lượng
    public decimal Price {get;set;} // đơn giá
    public bool HealthInsurranceSuggest{get;set;} // đề nghị thanh toán theo BHYT
    public bool HealthInsurrancePayment{get;set;} // thanh toán theo BHYT
    public string MedicalEquipmentId{get;set;} // mã thiết bị khám
    public int IsResidentTreament{get;set;} // nội trú/ngoại trú
    public string DoctorId{get;set;} // bác sỹ khám
    public string ClinicId{get;set;} // mã phòng khám
    public string OutpatientDeptId{get;set;} // mã khoa khám
    public string HospitalId{get;set;} // mã cơ sở khám
}