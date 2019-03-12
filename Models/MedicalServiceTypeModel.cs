using System.ComponentModel.DataAnnotations;

public class MedicalServiceTypeModel {
    [Key]
    public string MedicalServiceTypeId {get;set;} // mã loại dịch vụ y tế
    public string MedicalServiceTypeName {get;set;} // tên loại dịch vụ y tế
}