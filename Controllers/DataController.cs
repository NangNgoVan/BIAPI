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
        /// Lấy danh sách các bệnh.
        ///</summary>
        [Produces("application/json")]
        [Route("medicalDiseases")]
        [HttpPost]
        public ResultModel MedicalDiseases([FromBody] List<MedicalDiseaseModel> data) {
            return DataService.LoadDimMedicalDisease(data);
        }

        /// <summary>
        ///     Lấy danh sách các loại bệnh.
        ///</summary>
        [Produces("application/json")]
        [Route("medicalDiseaseTypes")]
        [HttpPost]
        public ResultModel MedicalDiseaseTypes([FromBody] List<MedicalDiseaseTypeModel> data) {
            return DataService.LoadDimMedicalDiseaseType(data);
        }

        /// <summary>
        ///     Lấy danh sách phòng khám bệnh.
        /// </summary>
        [Produces("application/json")]
        [Route("clinics")]
        [HttpPost]
        public ResultModel Clinics([FromBody] List<ClinicModel> data){
            return DataService.LoadDimClinic(data);
        }

        /// <summary>
        ///     Lấy danh sách khoa khám bệnh.
        /// </summary>
        [Produces("application/json")]
        [Route("outpatientDepts")]
        [HttpPost]
        public ResultModel OutpatientDepts([FromBody] List<OutpatientDeptModel> data){
            return DataService.LoadDimOupatientDept(data);
        }

        /// <summary>Lấy danh sách cơ sở khám bệnh.</summary>
        [Produces("application/json")]
        [Route("hospitals")]
        [HttpPost]
        public ResultModel Hospitals([FromBody] List<HospitalModel> data){
            return DataService.LoadDimHospital(data);
        }

        /// <summary>Lấy danh sách thiết bị y tế.</summary>
        [Produces("application/json")]
        [Route("medicalEquipments")]
        [HttpPost]
        public ResultModel MedicalEquipments([FromBody] List<MedicalEquipmentModel> data){
            return DataService.LoadDimMedicalEquipment(data);
        }

         /// <summary>Lấy danh sách chuyên môn khám.</summary>
        [Produces("application/json")]
        [Route("medicalProfessions")]
        [HttpPost]
        public ResultModel MedicalProfessions([FromBody] List<MedicalProfessionModel> data){
            return DataService.LoadDimMedicalProfession(data);
        }

        /// <summary>Lấy danh sách bác sỹ.</summary>
        [Produces("application/json")]
        [Route("doctors")]
        [HttpPost]
        public ResultModel Doctors([FromBody] List<DoctorModel> data){
            var result = DataService.LoadDimDoctor(data);
            return result;
        }

        /// <summary>Lấy danh sách tình trạng bệnh.</summary>
        [Produces("application/json")]
        [Route("illnessStates")]
        [HttpPost]
        public ResultModel IllnessStates([FromBody] List<IllnessStateModel> data){
            return DataService.LoadDimIllnessState(data);
        }

        /// <summary>Lấy danh sách dịch vụ y tế.</summary>
        [Produces("application/json")]
        [Route("medicalServices")]
        [HttpPost]
        public ResultModel MedicalServices([FromBody] List<MedicalServiceModel> data) {
            return DataService.LoadDimMedicalService(data);
        }

        /// <summary>Lấy danh sách nhóm dịch vụ y tế.</summary>
        [Produces("application/json")]
        [Route("medicalGroupServices")]
        [HttpPost]
        public ResultModel MedicalServiceGroups([FromBody] List<MedicalServiceGroupModel> data) {
            return DataService.LoadDimMedicalServiceGroup(data);
        }

        /// <summary>Lấy danh sách loại dịch vụ y tế.</summary>
        [Produces("application/json")]
        [Route("medicalServiceTypes")]
        [HttpPost]
        public ResultModel MedicalServiceTypes([FromBody] List<MedicalServiceTypeModel> data) {
            return DataService.LoadDimMedicalServiceType(data);
        }

        /// <summary>Thông tin khám chữa bệnh hàng ngày.</summary>
        ///
        [Produces("application/json")]
        [Route("medicalAttentionServices")]
        [HttpPost]
        public ResultModel MedicalAttentionServices([FromBody] List<TreatmentFactModel> data) {
            return DataService.ETLMedicalAttentionServiceFact(data);
        }
    }
}
