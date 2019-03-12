using System.ComponentModel.DataAnnotations;

public class MedicalAttensionDiseaseModel {
    [Key]
    public string PatientCode {get;set;} // mã lần khám
    public string DiseaseId {get;set;} // mã bệnh
}