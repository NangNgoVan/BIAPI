using System.ComponentModel.DataAnnotations;

public class IllnessStateModel {
    [Key]
    public string IllnessStateId {get;set;} // mã tình trạng bệnh
    public string IllnessStateName {get;set;} // tên tình trạng bệnh
}