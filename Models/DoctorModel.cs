using System.ComponentModel.DataAnnotations;

public class DoctorModel {
    [Key]
    public string DoctorId {get;set;} // mã bác sỹ
    public string DoctorName {get;set;} // tên bác sỹ
    public string HospitalId {get;set;} // mã cơ sở khám bệnh
}