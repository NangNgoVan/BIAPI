using System.ComponentModel.DataAnnotations;

public class OutpatientDeptModel {
    [Key]
    public string OutpatientDeptId {get;set;} // Mã khoa khám bệnh
    public string OutpatientDeptName {get;set;} // Tên khoa khám bệnh
    public string HospitalId {get;set;} // Mã cơ sở khám bệnh
}