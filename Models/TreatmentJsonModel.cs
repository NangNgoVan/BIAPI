using BIApi.Models;
using System;
using System.Collections.Generic;

public class TreatmentJsonModel {
    public string PatientCode {get;set;} // mã lần khám
    public PatientInfoModel patient; // thông tin bệnh nhân
    public List<MedicalAttentionServiceJsonModel> treamentServices {get;set;} // thông tin các dịch vụ khám
    public List<string> diseaseIds {get;set;} // danh sách mã bệnh
    public string IllnessStateId {get;set;} // mã tình trạng bệnh
}
