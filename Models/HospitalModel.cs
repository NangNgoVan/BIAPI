using System.ComponentModel.DataAnnotations;

public class HospitalModel {
    [Key]
    public string HospitalId {get;set;} // mã cơ sở khám bệnh
    public string HospitalName {get;set;} // tên cơ sở
    public int BedNumber {get;set;} // số giường bệnh
}