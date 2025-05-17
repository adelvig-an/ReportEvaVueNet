namespace Model
{
    public class ExpertModel : ContactModel
    {
        public string NumberSRA { get; set; } = string.Empty; //Номер в реестре СРО
        public DateTime DateOn { get; set; } //Дата регистрации в реестре СРО
        public int? SROrganizationId { get; set; }
        public SROrganizationModel? SROrganization { get; set; }
        public int? ExpertQualificationId { get; set; }
        public ExpertQualificationModel? ExpertQualification { get; set; }
        public int? InsurancePolicyId { get; set; }
        public InsurancePolicyModel? InsurancePolicy { get; set; }
        public virtual ICollection<ExpertOrganizationModel>? ExpertOrganizations { get; set; }
    }
}
