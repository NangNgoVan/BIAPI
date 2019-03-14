using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MedicalAttensionDiseaseModel {
    public string PatientCode {get;set;} // mã lần khám
    public string DiseaseId {get;set;} // mã bệnh

    //[ForeignKey("PatientCode")]
    //public MedicalAttentionModel MedicalAttention { get; set; }
}