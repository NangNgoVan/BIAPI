using System.ComponentModel.DataAnnotations;

public class MedicalDiseaseModel {
    [Key]
    public string DiseaseId {get;set;} // mã bệnh
    public string  DiseaseTypeId{get;set;} // mã loại bệnh
    public string DiseaseName{get;set;} // tên bệnh
}