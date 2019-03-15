using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BIApi.DBContext;

namespace BIApi.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        /// <summary>
        /// Danh sách các bệnh.
        ///</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalDisease
        ///     [
        ///         {
        ///             "diseaseId": "mã bệnh",
        ///             "diseaseTypeId": "mã loại bệnh",
        ///             "diseaseName": "tên bệnh"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalDiseases")]
        [HttpPost]
        public ResultModel MedicalDiseases([FromBody] List<MedicalDiseaseModel> data) {
            return DataService.LoadDimMedicalDisease(data);
        }

        ///<summary>
        ///     Danh sách các loại bệnh.
        ///</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalDiseaseTypes
        ///     [
        ///         {
        ///             "diseaseTypeId": "mã loại bệnh",
        ///             "diseaseTypeName": "tên loại bệnh" 
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalDiseaseTypes")]
        [HttpPost]
        public ResultModel MedicalDiseaseTypes([FromBody] List<MedicalDiseaseTypeModel> data) {
            return DataService.LoadDimMedicalDiseaseType(data);
        }

        /// <summary>
        ///     Danh sách phòng khám bệnh.
        /// </summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /clinics
        ///     [
        ///         {
        ///             "clinicId": "mã phòng khám",
        ///             "clinicName": "tên phòng khám" ,
        ///             "hospitalId":"mã cơ sở khám",
        ///             "outPatientDeptId":"mã khoa khám"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("clinics")]
        [HttpPost]
        public ResultModel Clinics([FromBody] List<ClinicModel> data){
            return DataService.LoadDimClinic(data);
        }

        /// <summary>
        ///     Danh sách khoa khám bệnh.
        /// </summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /outpatientDepts
        ///     [
        ///         {
        ///             "outpatientDeptId": "mã khoa khám",
        ///             "outpatientDeptName": "tên khoa khám",
        ///             "hospitalId": "mã cơ sở khám"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("outpatientDepts")]
        [HttpPost]
        public ResultModel OutpatientDepts([FromBody] List<OutpatientDeptModel> data){
            return DataService.LoadDimOupatientDept(data);
        }

        /// <summary>Danh sách cơ sở khám bệnh.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /hospitals
        ///     [
        ///         {
        ///             "hospitalId": "mã cơ sở khám",
        ///             "hospitalName": "tên sơ sở khám",
        ///             "bedNumber": (int) số giường bệnh
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("hospitals")]
        [HttpPost]
        public ResultModel Hospitals([FromBody] List<HospitalModel> data){
            return DataService.LoadDimHospital(data);
        }

        /// <summary>Danh sách thiết bị y tế.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalEquipments
        ///     [
        ///         {
        ///             "medicalEquipmentId": "mã thiết bị y tế",
        ///             "medicalEquipmentName": "tên thiết bị y tế"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalEquipments")]
        [HttpPost]
        public ResultModel MedicalEquipments([FromBody] List<MedicalEquipmentModel> data){
            return DataService.LoadDimMedicalEquipment(data);
        }

        /// <summary>Danh sách chuyên môn khám.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalProfessions
        ///     [
        ///         {
        ///             "medicalProfessionId": "mã chuyên môn khám",
        ///             "medicalProfessionName": "tên chuyên môn khám"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalProfessions")]
        [HttpPost]
        public ResultModel MedicalProfessions([FromBody] List<MedicalProfessionModel> data){
            return DataService.LoadDimMedicalProfession(data);
        }

        /// <summary>Danh sách bác sỹ.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /doctors
        ///     [
        ///         {
        ///             "doctorId": "mã bác sỹ",
        ///             "doctorName": "tên bác sỹ",
        ///             "hospitalId": "mã cơ sở khám"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("doctors")]
        [HttpPost]
        public ResultModel Doctors([FromBody] List<DoctorModel> data){
            var result = DataService.LoadDimDoctor(data);
            return result;
        }

        /// <summary>Danh sách tình trạng bệnh.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /illnessStates
        ///     [
        ///         {
        ///             "illnessStateId": "mã tình trạng bệnh",
        ///             "illnessStateName": "tên tình trạng bệnh",
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("illnessStates")]
        [HttpPost]
        public ResultModel IllnessStates([FromBody] List<IllnessStateModel> data){
            return DataService.LoadDimIllnessState(data);
        }

        /// <summary>Danh sách dịch vụ y tế.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalServices
        ///     [
        ///         {
        ///             "medicalServiceTypeId": "mã loại dịch vụ y tế",
        ///             "medicalServiceId": "mã dịch vụ y tế",
        ///             "medicalServiceName": "tên dịch vụ y tế",
        ///             "medicalProfessionId": "mã chuyên môn khám"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalServices")]
        [HttpPost]
        public ResultModel MedicalServices([FromBody] List<MedicalServiceModel> data) {
            return DataService.LoadDimMedicalService(data);
        }

        /// <summary>Danh sách nhóm dịch vụ y tế.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalGroupServices
        ///     [
        ///         {
        ///             "medicalServiceGroupId": "mã nhóm dịch vụ y tế",
        ///             "medicalServiceGroupName": "tên nhóm dịch vụ y tế",
        ///             "medicalServicetypeId": "mã loại dịch vụ y tế"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalGroupServices")]
        [HttpPost]
        public ResultModel MedicalServiceGroups([FromBody] List<MedicalServiceGroupModel> data) {
            return DataService.LoadDimMedicalServiceGroup(data);
        }

        /// <summary>Danh sách loại dịch vụ y tế.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalServiceTypes
        ///     [
        ///         {
        ///             "medicalServiceTypeId": "mã loại dịch vụ y tế",
        ///             "medicalServiceTypeName": "tên loại dịch vụ y tế"
        ///         },
        ///         ...
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalServiceTypes")]
        [HttpPost]
        public ResultModel MedicalServiceTypes([FromBody] List<MedicalServiceTypeModel> data) {
            return DataService.LoadDimMedicalServiceType(data);
        }

        /// <summary>Thông tin khám chữa bệnh hàng ngày.</summary>
        /// <remarks>
        /// Json:
        ///
        ///     POST /medicalAttensionServices
        ///     [
        ///         {
        ///             "patient": {
        ///                 "patientId": "mã bệnh nhân",
        ///                 "patientName": "tên bệnh nhân",
        ///                 "patientAddress": "địa chỉ",
        ///                 "patientBirthDate": "ngày sinh",
        ///                 "patientSex": "giới tính"
        ///             }
        ///             "patientCode": "mã lần khám",
        ///             "treamentServices": [
        ///                 {
        ///                     "medicalServiceId": "mã dịch vụ khám",
        ///                     "beganTreamentDateTime": "thời gian chỉ định khám",
        ///                     "reveicedTreamentDateTime": "thời gian thực hiện khám",
        ///                     "endedTreamentDateTime": "thời gian kết thúc khám",
        ///                     "quantity": (int) số lượng,
        ///                     "price": (decimal) đơn giá,
        ///                     "healthInsurranceSuggest": "đề nghị thanh toán theo BHYT (0-không, 1-có)",
        ///                     "healthInsurrancePayment": "thanh toán theo BHYT (0-không, 1-có)",
        ///                     "medicalEquipmentId": "mã thiết bị khám",
        ///                     "isResidentTreament": "1-nội trú/0-ngoại trú",
        ///                     "doctorId": "mã bác sỹ",
        ///                     "clinicId": "mã phòng khám",
        ///                     "outpatientDeptId": "mã khoa khám",
        ///                     "hospitalId": "mã cơ sở khám"
        ///                 },
        ///                 ...
        ///             ],
        ///             "diseaseIds" : [
        ///                 "mã bệnh",
        ///                 ...
        ///             ],
        ///             "illnessStateId": "mã trạng thái bệnh"
        ///         }
        ///
        ///     ]
        ///
        /// </remarks>
        [Produces("application/json")]
        [Route("medicalAttensionServices")]
        [HttpPost]
        public ResultModel MedicalAttentionServices([FromBody] List<TreatmentJsonModel> data) {
            return DataService.LoadMedicalAttentionServiceFact(data);
        }
    }
}
