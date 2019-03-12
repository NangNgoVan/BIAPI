using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class MedicalAttentionModel {
    [Key]
    public string PatientCode {get;set;} // mã lần khám bệnh
    public string PatientId {get;set;} // mã bệnh nhân
    public string IllnessStateId {get;set;} // mã tình trạng bệnh
}