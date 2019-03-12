using System.ComponentModel.DataAnnotations;

public class MedicalServiceGroupModel {
    [Key]
    public string MedicalServiceGroupId {get;set;} // mã nhóm dịch vụ y tế
    public string MedicalServiceGroupName {get;set;} // tên nhóm dịch vụ y tế
    public string MedicalServicetypeId {get;set;} // mã loại dịch vụ y tế
}