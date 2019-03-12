using System.ComponentModel.DataAnnotations;

public class ClinicModel {
    [Key]
    public string ClinicId {get;set;} // mã phòng khám bệnh
    public string ClinicName {get;set;} // tên phòng khám bệnh
    public string HospitalId {get;set;} // mã cơ sở khám bệnh
    public string OutPatientDeptId {get;set;} // mã khoa khám bệnh
}