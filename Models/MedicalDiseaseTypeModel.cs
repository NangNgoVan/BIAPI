using System.ComponentModel.DataAnnotations;

public class MedicalDiseaseTypeModel {
    [Key]
    public string DiseaseTypeId {get;set;} // mã loại bệnh
    public string DiseaseTypeName {get;set;} // tên loại bệnh
}