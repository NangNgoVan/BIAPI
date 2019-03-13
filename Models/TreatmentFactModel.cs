using System;
using System.Collections.Generic;

public class TreatmentFactModel {
    public string PatientCode {get;set;} // mã lần khám
    public PatientInfoModel patient; // thông tin bệnh nhân
    public List<MedicalAttentionServiceJsonModel> treamentServices {get;set;} // thông tin các dịch vụ khám
    public List<string> diseaseIds {get;set;} // danh sách mã bệnh
    public string IllnessStateId {get;set;} // mã tình trạng bệnh
}

public class MedicalAttentionServiceJsonModel
{
    public string MedicalServiceId { get; set; } // mã dịch vụ khám
    public DateTime BeganTreamentDateTime { get; set; } // thời gian chỉ định khám
    public DateTime ReveicedTreamentDateTime { get; set; } // thời gian bắt đầu vào khám
    public DateTime EndedTreamentDateTime { get; set; } // thời gian kết thúc khám
    public int Quantity { get; set; } // số lượng
    public decimal Price { get; set; } // đơn giá
    public bool HealthInsurranceSuggest { get; set; } // đề nghị thanh toán theo BHYT
    public bool HealthInsurrancePayment { get; set; } // thanh toán theo BHYT
    public string MedicalEquipmentId { get; set; } // mã thiết bị khám
    public int IsResidentTreament { get; set; } // nội trú/ngoại trú
    public string DoctorId { get; set; } // bác sỹ khám
    public string ClinicId { get; set; } // mã phòng khám
    public string OutpatientDeptId { get; set; } // mã khoa khám
    public string HospitalId { get; set; } // mã cơ sở khám

    public static implicit operator MedicalAttentionServiceModel(MedicalAttentionServiceJsonModel model)
    {
        return new MedicalAttentionServiceModel()
        {
            MedicalServiceId = model.MedicalServiceId,
            BeganTreamentDateTime = model.BeganTreamentDateTime,
            ReveicedTreamentDateTime = model.ReveicedTreamentDateTime,
            EndedTreamentDateTime = model.EndedTreamentDateTime,
            Quantity = model.Quantity,
            Price = model.Price,
            HealthInsurranceSuggest = model.HealthInsurranceSuggest,
            HealthInsurrancePayment = model.HealthInsurrancePayment,
            MedicalEquipmentId = model.MedicalEquipmentId,
            IsResidentTreament = model.IsResidentTreament,
            DoctorId = model.DoctorId,
            ClinicId = model.ClinicId,
            OutpatientDeptId = model.OutpatientDeptId,
            HospitalId = model.HospitalId
        };
    }
}