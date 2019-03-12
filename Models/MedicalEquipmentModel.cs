using System.ComponentModel.DataAnnotations;

public class MedicalEquipmentModel {
    [Key]
    public string MedicalEquipmentId {get;set;} // mã thiết bị y tế
    public string MedicalEquipmentName {get;set;} // tên thiết bị y tế
}