using System.ComponentModel.DataAnnotations;

public class MedicalServiceModel {
    [Key]
    public string MedicalServiceTypeId{get;set;} // mã loại dịch vụ y tế
    public string MedicalServiceId {get;set;} // mã dịch vụ y tế
    public string MedicalServiceName {get;set;} // tên dịch vụ
    public string MedicalProfessionId {get;set;} // mã chuyên môn khám
}