using Microsoft.EntityFrameworkCore;

namespace BIApi.DBContext {
    public class DB : DbContext
    {
        public DbSet<PatientInfoModel> PatientInfos {get;set;} // bệnh nhân
        public DbSet<OutpatientDeptModel> OutpatientDepts {get;set;} // khoa khám bệnh
        public DbSet<MedicalServiceTypeModel> MedicalServiceTypes {get;set;} // loại dịch vụ y tế
        public DbSet<MedicalServiceModel> MedicalServices {get;set;} // dịch vụ
        public DbSet<MedicalServiceGroupModel> MedicalServiceGroups {get;set;} // nhóm loại dịch vụ y tế
        public DbSet<MedicalProfessionModel> MedicalProfessions {get;set;} // chuyên môn khám
        public DbSet<MedicalEquipmentModel> MedicalEquipments {get;set;} // thiết bị khám chữa
        public DbSet<MedicalDiseaseTypeModel> MedicalDiseaseTypes {get;set;} // loại bệnh
        public DbSet<MedicalDiseaseModel> MedicalDiseases {get;set;} // bệnh
        public DbSet<MedicalAttentionServiceModel> MedicalAttentionServices {get;set;} // dịch vụ khám bệnh 1 lần khám
        public DbSet<MedicalAttentionModel> MedicalAttentions {get;set;} // lần khám
        public DbSet<ClinicModel> Clinics {get;set;} // phòng khám
        public DbSet<HospitalModel> Hospitals {get;set;} // cơ sở khám
        public DbSet<IllnessStateModel> IllnessStates {get;set;} // tình trạng bệnh
        public DbSet<MedicalAttensionDiseaseModel> MedicalAttensionDiseases {get;set;} // danh sách bệnh trong 1 lần khám
        public DbSet<DoctorModel> Doctors {get;set;} // bác sỹ khám
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PatientInfoModel>().ToTable("dim_patient_infos");
            modelBuilder.Entity<OutpatientDeptModel>().ToTable("dim_outpatient_depts");
            modelBuilder.Entity<MedicalServiceTypeModel>().ToTable("dim_medical_service_types");
            modelBuilder.Entity<MedicalServiceModel>().ToTable("dim_medical_services");
            modelBuilder.Entity<MedicalServiceGroupModel>().ToTable("dim_medical_service_groups");
            modelBuilder.Entity<MedicalProfessionModel>().ToTable("dim_medical_professions");
            modelBuilder.Entity<MedicalEquipmentModel>().ToTable("dim_medical_equipments");
            modelBuilder.Entity<MedicalDiseaseTypeModel>().ToTable("dim_medical_disease_types");
            modelBuilder.Entity<MedicalDiseaseModel>().ToTable("dim_medical_diseases");
            modelBuilder.Entity<MedicalAttentionServiceModel>().ToTable("fact_medical_attention_services");
            modelBuilder.Entity<MedicalAttentionModel>().ToTable("bridge_medical_attention");
            modelBuilder.Entity<ClinicModel>().ToTable("dim_clinics");
            modelBuilder.Entity<HospitalModel>().ToTable("dim_hospitals");
            modelBuilder.Entity<IllnessStateModel>().ToTable("dim_illness_states");
            modelBuilder.Entity<MedicalAttensionDiseaseModel>().ToTable("bridge_medical_attension_diseases");
            modelBuilder.Entity<DoctorModel>().ToTable("dim_doctors");

            modelBuilder.Entity<OutpatientDeptModel>()
                .HasKey(k => new { k.HospitalId, k.OutpatientDeptId });
            modelBuilder.Entity<ClinicModel>()
                .HasKey(k => new { k.ClinicId, k.HospitalId, k.OutPatientDeptId });
            modelBuilder.Entity<MedicalAttensionDiseaseModel>()
                .HasKey(k => new { k.PatientCode, k.DiseaseId });
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder
                .UseSqlServer(@"Data Source=MY-AK7EGE7HDPMU\SQLEXPRESS;Database=BI_VIETBA_DW;Integrated Security=False;User Id=nang;Password=123456; MultipleActiveResultSets=True");
        }
    }
}