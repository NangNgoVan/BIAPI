using System;
using System.ComponentModel.DataAnnotations;

public class PatientInfoModel {
    [Key]
    public string PatientId {get;set;} // mã bệnh nhân
    public string PatientName{get;set;} // tên bệnh nhân
    public string PatientAddress{get;set;} // địa chỉ
    public DateTime PatientBirthDate {get;set;} // ngày sinh
    public string PatientSex {get;set;} // giới tính
}