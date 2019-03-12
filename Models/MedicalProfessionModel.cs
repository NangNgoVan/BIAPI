using System.ComponentModel.DataAnnotations;

public class MedicalProfessionModel {
    [Key]
    public string MedicalProfessionId {get;set;} // mã chuyên môn khám
    public string MedicalProfessionName {get;set;} // tên chuyên môn khám
}