using System.Collections.Generic;

public class TreatmentFactModel {
    public string PatientCode {get;set;} // mã lần khám
    public PatientInfoModel patient; // thông tin bệnh nhân
    public List<MedicalAttentionServiceModel> treamentServices {get;set;} // thông tin các dịch vụ khám
    public List<string> diseaseIds {get;set;} // danh sách mã bệnh
    public int IllnessStateName {get;set;} // mã tình trạng bệnh
}